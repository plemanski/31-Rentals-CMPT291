using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14DBproject
{
    public partial class Rent : Form
    {
        // Local databse connection name
      //  string connName = @"Data Source=DESKTOP-C2L51Q9;Initial Catalog=project;Integrated Security=True";
        //string connName = "Data Source=DESKTOP-JI43H5D;Initial Catalog=CarRental;Integrated Security=True;Pooling=False";
        string connName = @"Data Source=DESKTOP-CEF6NO7;Initial Catalog=Cars5_291;Integrated Security=True";


        // Object that allows us to connect to the database
        SqlDataAdapter dataAdapter;

        // Table that will hold the data used to fill datagrid view
        DataTable infoTable;

        // Create global variables that will hold transaction details
        // These transaction details will be pushed to the Transactions table
        // These transaction details will also be used to generate a receipt

        DateTime beginDate; // Rental period begins
        DateTime endDate;  // Rental period end
        int period;        // Length of rental period
        int carID;         // Car ID
        int locID;         // Original location
        int branchID;      // Will be used to hold return location
        int customerID;     // Customer ID
        String customerName; // Customer name
        int pickUpLocationID; // Pickup location ID: Example, Edmonton North has ID = 1
        int dropOfLocationID; // Drop off location ID
        private receiptForm receipt; // A new form that will be used to generate a receipt 
        string make;
        int typeID;


        public Rent()
        {
            InitializeComponent();
            
        }

        /* The following block of Code allows user to enter their gold
         * star membership number if they check the goldstar checkbox*/
        private void goldStarMember_CheckedChanged(object sender, EventArgs e)
        {
      
        }

        /* The following will disable the drop off location comboBox if the
         * dropoff location is the same as pick up location checkbox is checked.*/

        private void checkDropPickSame_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDropPickSame.Checked)
            {
                dropOffLocations.Enabled = false;
            }
            else
            {   
                dropOffLocations.Enabled = true;
            }
        }

        private void Rent_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1; // Sets the source of the data to be displayed in the gridview
            receipt = new receiptForm();  // New receipt form is loaded but it will not be shown yet


        }

        private void GetDataCars(string myQuery)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(myQuery, connName); //Executes the sql query on the specified connection
                infoTable = new DataTable(); // A table that holds the query results
                infoTable.Locale = System.Globalization.CultureInfo.InvariantCulture; // Ensures it's not geograph specific
                dataAdapter.Fill(infoTable); // 
                bindingSource2.DataSource = infoTable;

            }
            catch (SqlException sqlEX)
            {
                MessageBox.Show(sqlEX.ToString());
            }
        
       }

      


         /* First step in the query. Customer will input dates of rental.
          * He will then select pickup and drop locations. Those locations
          * are identified by their index numbers. Example, Edmonton North is index 1 on the comboBox
          * and has ID = 1 on the database.
          * Clicking the button will return list of cars with location that matches user and are not rented (Rented = 'N')*/
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource2; // Sets the source of the data to be displayed in the gridview
            string pickupIndexValue = pickUpLocations.SelectedIndex.ToString();
            string returnIndexValue = dropOffLocations.SelectedIndex.ToString();

            //
            beginDate = dateTimeBegin.Value.Date;
            string sqlFormattedbeginDate = beginDate.ToString("yyyy-MM-dd HH:mm:ss");
            endDate = dateTimeEnd.Value.Date;
            string sqlFormattedendDate = endDate.ToString("yyyy-MM-dd HH:mm:ss");
            String diff = (endDate - beginDate).TotalDays.ToString();
            period = int.Parse(diff);

            if (period < 0)
            {
                MessageBox.Show("This date configuration is unavailable, please select new dates.");
                return;
            }

            // I used 1 or 0 supposed to Y or N for my rented column if there is an error its probably because i forgot to change it back to 'Y'
            GetDataCars(@"Select carID, make, color, locID, typeID from dbo.Cars Where rented= 0 and locID="+pickupIndexValue);
            pickUpLocationID = int.Parse(pickupIndexValue);
            if (checkDropPickSame.Checked) {
                dropOfLocationID = pickUpLocationID;
                    }
            else 
            { dropOfLocationID = int.Parse(returnIndexValue); 
            }


         
        }
        /*Whatever selection the user makes, the dat3a will be stored. Every detail 
         * needed for the transaction is stored below. These variables will be used
         * to store data to the transaction table*/ 

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                // Data from the grid
                 carID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["carIDDataGridViewTextBoxColumn"].FormattedValue.ToString());
                 locID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["locIDDataGridViewTextBoxColumn"].FormattedValue.ToString());

                //the make is hard coded, probably would be better to get the make from the column name. Could lead to issues. -Omar
                make = dataGridView1.Rows[e.RowIndex].Cells["makeDataGridViewTextBoxColumn1"].FormattedValue.ToString();
                typeID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["typeIDDataGridViewTextBoxColumn"].FormattedValue.ToString());


                //Data from user input
                /*
                beginDate = dateTimeBegin.Value.Date;
                 string sqlFormattedbeginDate = beginDate.ToString("yyyy-MM-dd HH:mm:ss");
                 endDate = dateTimeEnd.Value.Date;
                 string sqlFormattedendDate = endDate.ToString("yyyy-MM-dd HH:mm:ss");
                 String diff = (endDate - beginDate).TotalDays.ToString();
                 period = int.Parse(diff);
               

                if(period < 0)
                {
                    MessageBox.Show("This date configuration is unavailable, please select new dates.");
                }

                */

                 
                if(customerNameInput.Text == null)
                {
                    MessageBox.Show("Please Enter Your Name");
                }
                else
                {
                    customerName = customerNameInput.Text.ToString();
                }

                if (customerIDInput.Text != null)
                {
                    customerID = int.Parse(customerIDInput.Text.ToString());
                }
                else
                {
                    MessageBox.Show("Please Enter Your ID");
                }
                 MessageBox.Show(carID.ToString());


                 if (checkDropPickSame.Checked)
                {
                    string pickLocationComboBoxIndex = pickUpLocations.SelectedIndex.ToString();
                    pickUpLocationID = int.Parse(pickLocationComboBoxIndex);
                    dropOfLocationID = pickUpLocationID;
                }
                else
                {
                    string pickLocationComboBoxIndex = pickUpLocations.SelectedIndex.ToString();
                    string dropLocationComboBoxIndex = dropOffLocations.SelectedIndex.ToString();
                    pickUpLocationID = int.Parse(pickLocationComboBoxIndex);
                    dropOfLocationID = int.Parse(dropLocationComboBoxIndex);
                }
                branchID = dropOfLocationID;

            }
            else
            {
                MessageBox.Show("Please make a selection!");
            }
        }



        /**
         * The rate is calculated on a daily basis, The car makes will be the keys and the rate will be the 
         * value returned. 
         * 
         * Returns car make rate multiplied by the period of the rental
         */

        private int calculateRate()
        {
            int retVal = 0;
            int drate = int.Parse(getQueryResult("SELECT dRate FROM Type WHERE typeID =" + typeID));
            int div30 = 1;
            int div7 = 1;
            int extra = 1;

            //days
            if (period < 7)
            {
                //MessageBox.Show(period.ToString());
                retVal = drate * period;
            }

            //weekly
            if (period >= 7 && period < 30)
            {
                if(period == 7)
                {
                    period = 1;
                }

                else
                {
                    div7 = period / 7;
                    extra = period - (7 * div7);

                }

                //MessageBox.Show(period.ToString());
                int rate = int.Parse(getQueryResult("SELECT wRate FROM Type WHERE typeID =" + typeID));
                retVal = (rate * div7) + (extra * drate);
            }

            //monthly
            if (period >= 30)
            {
                if (period == 30)
                {
                    period = 1;
                }

                else
                {
                    div30 = period / 30;
                    extra = period - (30 * div30);
                }

                //MessageBox.Show(period.ToString());

                int rate = int.Parse(getQueryResult("SELECT mRate FROM Type WHERE typeID =" + typeID));
                retVal = (rate * div30) + (extra*drate);
            }


            /*
            if (!checkDropPickSame.Checked) //if not checked
            {
                MessageBox.Show("There will be a location fee charged (+$30)");
                retVal += 30;
            }
            */


            return retVal;

        }


        /**
         * This function takes a query and returns the result as a string
         * it will only return the the first row of the first column.
         * So its ideal for getting the result for a query that only returns 1 value
         */
        private string getQueryResult(string query)
        {
            {
             
                SqlConnection cnn;
                //gets connection string

                //opens the connection to the database
                cnn = new SqlConnection(connName);

                cnn.Open();
                String retVal = "";
              

                SqlCommand cmd = new SqlCommand(query, cnn);

                SqlDataReader dataReader = cmd.ExecuteReader();
                // reads data grabs value from first row and column
                while (dataReader.Read())
                {
                    retVal = retVal + dataReader.GetValue(0);
                }
          
                dataReader.Close();
                cmd.Dispose();
                cnn.Close();

                return retVal;

            }
        }



        
        /**
         * Creates a messageBox that will be used to 
         * show the customers reciept
         */

        private void button2_Click(object sender, EventArgs e)
        {
            // When rent button is clicked, insert the transaction into the transaction table

            String sql = "INSERT INTO dbo.Transactions (beginDate,endDate,carID, branchID,customerID,employeeID) VALUES (@beginDate,@endDate,@carID, @branchID,@customerID,@employeeID);";

            // Create the connection 
            using (SqlConnection cnn = new SqlConnection(connName))
            {
                try
                {
                    // Open the connection to the database. 
                    cnn.Open();


                    // Prepare the command to be executed on the db
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        // Create and set 

                        cmd.Parameters.Add("@beginDate", SqlDbType.DateTime).Value = beginDate;
                        cmd.Parameters.Add("@endDate", SqlDbType.DateTime).Value = endDate;
                        cmd.Parameters.Add("@carID", SqlDbType.NChar).Value = carID;
                        cmd.Parameters.Add("@branchID", SqlDbType.Int).Value = branchID;
                        cmd.Parameters.Add("@customerID", SqlDbType.Int).Value = customerID;
                        cmd.Parameters.Add("@employeeID", SqlDbType.Int).Value = 0; //employeeID = 0 is no employee, online booking
                        //int transactionID = Convert.ToInt32(cmd.ExecuteScalar());

                        //execute the query
                        int rowsAdded = cmd.ExecuteNonQuery();

                        String transactionID = getQueryResult("SELECT TOP 1 * FROM transactions ORDER BY transactionID DESC"); //get last transaction
                       

                        if (rowsAdded > 0)
                        {
                            //update the carsTable rented, rented = 1
                            updateCarsTable();

                            //update customer's number of rentals 
                            updateNumberRentals();


                            //MessageBox.Show("Rental Confirmed!");
                            string branchName = getQueryResult("select [desc] from Branch where branchID = " + branchID);

                            int total = calculateRate();

                            if(checkLocation())
                            {
                                int totalFee=total+30;
                                MessageBox.Show("Success! Heres confirmation of your reservation \n \n \n" +
                               "Name: " + customerName + "\n \n \n" +
                               "***TRANSACTION ID: " + transactionID.ToString() + "  ***\n \n \n" +
                               "Reservation Date: " + beginDate.ToString("dd/MM/yyyy") + "\n \n \n" +
                               "Return Date: " + endDate.ToString("dd/MM/yyyy") + "\n \n \n" +
                               "Car make rented: " + make + "\n \n \n" +
                               "From Branch : " + branchName + "\n \n \n" +
                               "Estimated Total Price (with membership): " + "$" + total+
                               "\n \n \nEstimated Total Price (no membership): " + "$" + totalFee);
                            }

                            else
                            {
                                MessageBox.Show("Success! Heres confirmation of your reservation \n \n \n" +
                               "Name: " + customerName + "\n \n \n" +
                               "***TRANSACTION ID: " + transactionID.ToString() + "  ***\n \n \n" +
                               "Reservation Date: " + beginDate.ToString("dd/MM/yyyy") + "\n \n \n" +
                               "Return Date: " + endDate.ToString("dd/MM/yyyy") + "\n \n \n" +
                               "Car make rented: " + make + "\n \n \n" +
                               "From Branch : " + branchName + "\n \n \n" +
                               "Estimated Total Price: " + "$" + total);
                            }
                        }
                         

                        else
                            MessageBox.Show("Try Again");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR:" + ex.Message);
                }

            }

     
        }

        //This is called when a car is rented, it updates the cars table so the selected car's rentedID will update to 1 
        private void updateCarsTable()
        {
            String updateCars = "UPDATE dbo.Cars SET rented=@rentedID WHERE carID = @carID";

            using (SqlConnection cnn2 = new SqlConnection(connName))
            {
                try
                {
                    using (SqlCommand cmd2 = new SqlCommand(updateCars, cnn2))
                    {
                        cmd2.Parameters.Add("@rentedID", SqlDbType.Int).Value = 1; //1 if it gets rented 
                        cmd2.Parameters.AddWithValue("@carID", carID);

                        cnn2.Open();
                        cmd2.ExecuteNonQuery();
                        cnn2.Close();
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        
        private void updateNumberRentals()
        {
            
            String updateRentals = "UPDATE dbo.Customer SET noRentals=@noRentals WHERE customerID = " + @customerID;
            int noRentals = int.Parse(getQueryResult("Select noRentals from Customer where customerID = " + @customerID));

            using (SqlConnection cnn3 = new SqlConnection(connName))
            {
                try
                {
                    using (SqlCommand cmd3 = new SqlCommand(updateRentals, cnn3))
                    {
                        cmd3.Parameters.Add("@noRentals", SqlDbType.Int).Value = noRentals+=1; //increment number of rentals 
                        cmd3.Parameters.AddWithValue("@customerID", customerID);

                        cnn3.Open();
                        cmd3.ExecuteNonQuery();
                        cnn3.Close();
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private bool checkLocation()
        {
            if (!checkDropPickSame.Checked) //if not checked
            {
                //MessageBox.Show("There will be a location fee charged (+$30)");
                return true;
            }

            else
            {
                return false;
            }
        }
        


    }
}
