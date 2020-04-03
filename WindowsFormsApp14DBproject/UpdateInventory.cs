using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp14DBproject
{
    public partial class UpdateInventory : Form
    {
        const int LATE_FEE = 45;
        const int LOC_FEE = 30;
        int empID;
        readonly String connectionStr = "Data Source=DESKTOP-CEF6NO7;Initial Catalog=Cars5_291;Integrated Security=True";

        public UpdateInventory(int selectID)
        {
            InitializeComponent();
            searchCarsButton.Click += new EventHandler(SearchCarsButton_Click);
            addCarButton.Click += new EventHandler(AddCarButton_Click);
            updateCarsButton.Click += new EventHandler(UpdateCarsButton_Click);
            deleteCarsButton.Click += new EventHandler(DeleteCarsButton_Click);
            checkOutButton.Click += new EventHandler(CheckOutButton_Click);

            empID = selectID;
        }

        public void FillQuery(string sql, SqlCommand cmd)
        {
            if (string.IsNullOrWhiteSpace(carID.Text) == false)
            {
                cmd.Parameters.AddWithValue("@carID", carID.Text);
            }
            if (string.IsNullOrWhiteSpace(locID.Text) == false)
            {
                cmd.Parameters.AddWithValue("@locID", locID.Text);
            }
            if (string.IsNullOrWhiteSpace(color.Text) == false)
            {
                cmd.Parameters.AddWithValue("@color", color.Text);
            }
            if (string.IsNullOrWhiteSpace(licensePlate.Text) == false)
            {
                cmd.Parameters.AddWithValue("@licensePlate", licensePlate.Text);
            }
            if (string.IsNullOrWhiteSpace(make.Text) == false)
            {
                cmd.Parameters.AddWithValue("@make", make.Text);
            }
            if (string.IsNullOrWhiteSpace(typeID.Text) == false)
            {
                cmd.Parameters.AddWithValue("@typeID", typeID.Text);
            }
            if (string.IsNullOrWhiteSpace(fkBranchID.Text) == false)
            {
                cmd.Parameters.AddWithValue("@branchID", fkBranchID.Text);
            }
            if (string.IsNullOrWhiteSpace(customerName.Text) == false)
            {
                cmd.Parameters.AddWithValue("@customerName", customerName.Text);
            }
            if (string.IsNullOrWhiteSpace(transactionID.Text) == false)
            {
                cmd.Parameters.AddWithValue("@transactionID", transactionID.Text);
            }

            cmd.Parameters.AddWithValue("@employeeID", empID);
            cmd.Parameters.AddWithValue("@beginDate", dateTimeUpdated.Value);
            cmd.Parameters.AddWithValue("@endDate", dateTimePicker1.Value);
        }

        private void SearchCarsButton_Click(object sender, EventArgs e)
        {
            //Well this is ugly and needs to be fixed. One of these fields should be required?
            string sql = "SELECT * FROM cars ";
            if (string.IsNullOrWhiteSpace(typeID.Text) == false)
            {
                sql += "WHERE typeID = @typeID";
            }
            if (string.IsNullOrWhiteSpace(locID.Text) == false)
            {
                sql += " AND locID = @locID ";
            }
            if (string.IsNullOrWhiteSpace(color.Text) == false)
            {
                sql += " AND color = @color ";
            }
            if (string.IsNullOrWhiteSpace(licensePlate.Text) == false)
            {
                sql += " AND licensePlate = @licensePlate ";
            }
            if (string.IsNullOrWhiteSpace(carID.Text) == false)
            {
                sql += " AND carID = @carID ";
            }
            if (string.IsNullOrWhiteSpace(make.Text) == false)
            {
                sql += " AND make = @make ";
            }
            if (string.IsNullOrWhiteSpace(fkBranchID.Text) == false)
            {
                sql += " AND branchID = @branchID ";
            }
            DataQuery(sql);
        }

        private void UpdateCarsButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection dbConnection = new SqlConnection(connectionStr);

                string sql = "Update Cars SET";
                if (string.IsNullOrWhiteSpace(typeID.Text) == false)
                {
                    sql += " typeID = @typeID,";
                }
                if (string.IsNullOrWhiteSpace(locID.Text) == false)
                {
                    sql += " locID = @locID,";
                }
                if (string.IsNullOrWhiteSpace(color.Text) == false)
                {
                    sql += " color = @color,";
                }
                if (string.IsNullOrWhiteSpace(licensePlate.Text) == false)
                {
                    sql += " licensePlate = @licensePlate,";
                }
                if (string.IsNullOrWhiteSpace(make.Text) == false)
                {
                    sql += " make = @make,";
                }
                if (string.IsNullOrWhiteSpace(fkBranchID.Text) == false)
                {
                    sql += " branchID = @branchID,";
                }
                sql.TrimEnd(',');
                sql += " WHERE carID = @carID";

                using (SqlCommand sqlCommand = new SqlCommand(sql, dbConnection))
                {
                    dbConnection.Open();
                    FillQuery(sql, sqlCommand);
                    if (sqlCommand.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Vehicle Updated Successfully");
                        dbConnection.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update vehicle record");
                        dbConnection.Close();
                    }
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }


        private void AddCarButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection dbConnection = new SqlConnection(connectionStr);
                string sql = "INSERT INTO dbo.cars " +
                             "VALUES (@locID, '0', @color, @licensePlate, @make, @typeID, @branchID)";
                using (SqlCommand sqlCommand = new SqlCommand(sql, dbConnection))
                {
                    dbConnection.Open();
                    //Add user input from form fields into query
                    FillQuery(sql, sqlCommand);

                    if (sqlCommand.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Vehicle added successfully");
                    }
                    else
                    {
                        MessageBox.Show("Error: Vehicle not added");
                    }

                    dbConnection.Close();

                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }


        private void DeleteCarsButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(carID.Text) == false)
                {
                    SqlConnection dbConnection = new SqlConnection(connectionStr);

                    string sql = "DELETE FROM cars WHERE carID = @carID";

                    string updateSql = "UPDATE Transactions " +
                        "SET carID=9999 " +
                        "WHERE carID=@carID";

                    using (SqlCommand sqlCommand = new SqlCommand(updateSql, dbConnection))
                    {
                        dbConnection.Open();
                        sqlCommand.Parameters.AddWithValue("@carID", carID.Text);
                        sqlCommand.ExecuteNonQuery();
                        dbConnection.Close();
                    }
                    using (SqlCommand sqlCommand = new SqlCommand(sql, dbConnection))
                    {
                        dbConnection.Open();
                        sqlCommand.Parameters.AddWithValue("@carID", carID.Text);
                        if (sqlCommand.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Vehicle deleted successfully");
                            dbConnection.Close();
                        }
                        else
                        {
                            MessageBox.Show("No vehicle record deleted");
                            dbConnection.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Car ID required to delete a vehicle record");
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            //Begin a rental for a customer
            //Continue a rental booking if customer has transaction ID
            string sqlString = "";
            foreach (Control c in Controls)
            {
                if (c is TextBox && string.IsNullOrWhiteSpace(c.Text) == true && c != transactionID && c != customerID)
                {
                    //If one of the text boxes are empty, exit the method unless it's transaction ID
                    MessageBox.Show(string.Format("{0} can't be empty", c.Name));
                    return;
                }
            }

            if (CustomerExists() == false)
            {
                CreateCustomer();
            }

            
            //If no transaction ID is provided
            if (string.IsNullOrWhiteSpace(transactionID.Text) == true)
            {
                sqlString += "INSERT INTO dbo.transactions (beginDate, endDate, carID, branchID, customerID, employeeID) " +
                    "SELECT @beginDate, @endDate, @carID, @branchID, customer.customerID, @employeeID " +
                    "FROM customer " +
                    "WHERE name = @customerName";

            }

            else
            {
                sqlString += "UPDATE transactions " +
                "SET beginDate = @beginDate, " +
                "endDate = @endDate, " +
                "carID = @carID, " +
                "branchID = @branchID, " +
                "customerID = @customerID " +
                "employeeID = @employeeID " +
                "WHERE transactions.transactionId = @transactionID";
            }

            //Update cars to show rented
            //UpdateRental(int.Parse(carID.Text));



            try
            {
                SqlConnection dbconnection = new SqlConnection(connectionStr);
                using (SqlCommand sqlCommand = new SqlCommand(sqlString, dbconnection))
                {
                    FillQuery(sqlString, sqlCommand);
                    //MessageBox.Show(sqlString);
                    dbconnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    dbconnection.Close();

                }

                //CALCULATIONS
                //NOTE This is so ugly, I couldnt figure out how to put it into the calculate Rates method yikes

                String transactionID = getQueryResult("SELECT TOP 1 * FROM transactions ORDER BY transactionID DESC"); //get last transaction
                DateTime begin = DateTime.Parse(getQueryResult("SELECT beginDate FROM transactions WHERE transactionID=" + int.Parse(transactionID)));
                DateTime end = DateTime.Parse(getQueryResult("SELECT endDate FROM transactions WHERE transactionID=" + int.Parse(transactionID)));
                int dailyRate = int.Parse(getQueryResult("SELECT dRate FROM Type WHERE typeID =" + int.Parse(typeID.Text)));
                int weeklyRate = int.Parse(getQueryResult("SELECT wRate FROM Type WHERE typeID = " + int.Parse(typeID.Text)));
                int monthlyRate = int.Parse(getQueryResult("SELECT mRate FROM Type WHERE typeID = " + int.Parse(typeID.Text)));
                //MessageBox.Show("HERE");

                String diff = (end - begin).TotalDays.ToString();
                int period = int.Parse(diff);

                int retVal = 0;
                int div30 = 1;
                int div7 = 1;
                int extra = 1;

                //days
                if (period < 7)
                {
                    //MessageBox.Show(period.ToString());
                    retVal = dailyRate * period;
                }

                //weekly
                if (period >= 7 && period < 30)
                {
                    if (period == 7)
                    {
                        period = 1;
                    }

                    else
                    {
                        div7 = period / 7;
                        extra = period - (7 * div7);
                    }

                    //MessageBox.Show(period.ToString());
                    retVal = (weeklyRate * div7) + (extra * dailyRate);
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
                    retVal = (monthlyRate * div30) + (extra * dailyRate);
                }



                //Update cars to show rented
                //String transactionID = getQueryResult("SELECT TOP 1 * FROM transactions ORDER BY transactionID DESC"); //get last transaction

                int noRentals = int.Parse(getQueryResult("SELECT noRentals FROM customer WHERE customerID =" + int.Parse(customerID.Text)));
                int currCustomerID = int.Parse(customerID.Text);

                updateNumberRentals(currCustomerID, noRentals); //update noREntals
                noRentals = int.Parse(getQueryResult("SELECT noRentals FROM customer WHERE customerID =" + int.Parse(customerID.Text))); //get updated no rentals 

                checkNoRentals(noRentals, currCustomerID);

                UpdateRental(int.Parse(carID.Text)); //update rented = 1

                MessageBox.Show("Rent Confirmed \n\n\n ***Transaction ID:  "+ transactionID + " ***\n\nEstimated Charge: $"+retVal);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }



        private void checkInButton_Click(object sender, EventArgs e)
        {
            //Requires transaction field to be not null. Fills data grid with result of query
            //Creates a message box with total owed by customer.
            string sqlSelect = "SELECT transactions.beginDate, transactions.endDate, " +
                "transactions.branchID, transactions.customerID, " +
                "customer.membership, type.dRate, type.wRate, type.mRate, " +
                "cars.typeID " +
                "FROM transactions " +
                "INNER JOIN customer " +
                "   on transactions.customerID = customer.customerId " +
                "INNER JOIN cars " +
                "   on transactions.carID=cars.carID " +
                "INNER JOIN type " +
                "   on cars.typeID=type.typeID " +
                "WHERE transactions.transactionID = @transactionID";

            DataTable dt = DataQuery(sqlSelect);
            //Difference between beginDate and today's date
            try
            {

                double total = calculateRates(dt);

                int currCarID = int.Parse(getQueryResult("SELECT carID FROM transactions WHERE transactionID ="+ int.Parse(transactionID.Text)));
                int empBranchID = int.Parse(getQueryResult("SELECT branchID FROM employee WHERE employeeID = " + empID));

                updateCheckIn(currCarID, empBranchID);

                MessageBox.Show(String.Format("Thank you for choosing 31 Rentals\n\nTotal Due: $"+ total.ToString()));
                
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        public DataTable DataQuery(string sql)
        {

            //Method performs sql select commands and fills datagridview1
            try
            {
                SqlConnection dbConnection = new SqlConnection(connectionStr);
                using (SqlCommand sqlCommand = new SqlCommand(sql, dbConnection))
                {
                    FillQuery(sql, sqlCommand);
                    dbConnection.Open();
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dbConnection.Close();
                    return dt;
                }

            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
                return new DataTable(null);
            }
        }

        public Boolean CustomerExists()
        {
            string sql = "SELECT * FROM customer " +
                "WHERE name = @customerName";
            if (string.IsNullOrWhiteSpace(customerID.Text) == false)
            {
                sql += " or customerId = @customerID";
            }
            try
            {
                SqlConnection dbConnection = new SqlConnection(connectionStr);
                using (SqlCommand sqlCommand = new SqlCommand(sql, dbConnection))
                {
                    dbConnection.Open();
                    if (string.IsNullOrWhiteSpace(customerID.Text) == false)
                    {
                        sqlCommand.Parameters.AddWithValue("@customerID", customerID.Text);
                    }
                    sqlCommand.Parameters.AddWithValue("@customerName", customerName.Text);
                    if (sqlCommand.ExecuteScalar() != null)
                    {
                        dbConnection.Close();
                        MessageBox.Show("Customer Exists");
                        return true;
                    }
                    else
                    {
                        dbConnection.Close();
                        MessageBox.Show("Customer does not exist");
                        return false;
                    }
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
                return false;
            }
        }

        public Boolean CreateCustomer()
        {
            string sql = "INSERT INTO customer (name, membership, noRentals)" +
                "VALUES (@customerName, 0, 1)";

            try
            {
                SqlConnection dbConnection = new SqlConnection(connectionStr);
                using (SqlCommand sqlCommand = new SqlCommand(sql, dbConnection))
                {
                    dbConnection.Open();
                    FillQuery(sql, sqlCommand);
                    if (sqlCommand.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Customer added succesfully");
                        dbConnection.Close();
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Failed to add customer");
                        dbConnection.Close();
                        return false;
                    }

                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
                return false;
            }

        }

        public bool UpdateRental(int carID)
        {
            string sql = "UPDATE cars " +
                "SET rented = 1 " +
                "WHERE carID =" + carID;
            try
            {
                SqlConnection dbConnection = new SqlConnection(connectionStr);
                using (SqlCommand sqlCommand = new SqlCommand(sql, dbConnection))
                {
                    dbConnection.Open();
                    if (sqlCommand.ExecuteNonQuery() > 0)
                    {
                        dbConnection.Close();
                        return true;
                    }
                    else
                    {
                        dbConnection.Close();
                        return false;
                    }
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
                return false;
            }
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
                cnn = new SqlConnection(connectionStr);

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

        //This is called when a car is checked in, it updates the cars table so the selected car's rentedID will update to 0 
        private void updateCheckIn(int currCarID, int empBranchID)
        {
            String updateCars = "UPDATE dbo.Cars SET rented=@rentedID, branchID = @empBranchID, locID = @newLocID WHERE carID = @carID";


            using (SqlConnection cnn2 = new SqlConnection(connectionStr))
            {
                try
                {
                    using (SqlCommand cmd2 = new SqlCommand(updateCars, cnn2))
                    {
                        cmd2.Parameters.Add("@rentedID", SqlDbType.Int).Value = 0; //return to branch 
                        cmd2.Parameters.Add("@empBranchID", SqlDbType.Int).Value = empBranchID; //update newest branch == employee's branch
                        cmd2.Parameters.Add("@newLocID", SqlDbType.Int).Value = empBranchID; //update location == employee's branch
                        cmd2.Parameters.AddWithValue("@carID", currCarID);
                        

                        cnn2.Open();
                        cmd2.ExecuteNonQuery();
                        cnn2.Close();
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Update check in" + ex.Message);
                }
            }
        }

        private double calculateRates(DataTable dt)
        {
            DateTime beginD = Convert.ToDateTime(dt.Rows[0][0]);
            DateTime endD = Convert.ToDateTime(dt.Rows[0][1]);

            int diffDate = int.Parse((endD - beginD).TotalDays.ToString());

            // count late days 
            int lateDays = Convert.ToInt32(DateTime.Today.Subtract(Convert.ToDateTime(dt.Rows[0][1])).TotalDays);
            int extra = 1; //extra days
            int drate = Convert.ToInt32(dt.Rows[0][5]);
            //MessageBox.Show("DAILY "+drate.ToString());
            int div7 = 1;
            int div30 = 1;

            double totalDue = 0;
            //Calculate Rates
            if (diffDate < 7)
            {

                totalDue = diffDate * Convert.ToInt32(dt.Rows[0][5]);

            }
            if (diffDate >= 7 && diffDate < 30)
            {
                if (diffDate == 7)
                {
                    diffDate = 1;
                }

                else
                {
                    div7 = diffDate / 7;
                    extra = diffDate - (7 * div7);
                    //MessageBox.Show("DAILY EXTRA "+extra);

                }

                int rate = Convert.ToInt32(dt.Rows[0][6]);
                totalDue = (rate * div7) + (extra * drate);
            }

            if (diffDate >= 30)
            {
                if (diffDate == 30)
                {
                    diffDate = 1;
                }

                else
                {
                    div30 = diffDate / 30;
                    extra = diffDate - (30 * div30);
                }


                int rate = Convert.ToInt32(dt.Rows[0][7]);
                totalDue = (rate * div30) + (extra * drate);
            }

            //Find if customer is gold or not
            if (Convert.ToInt32(dt.Rows[0][4]) == 0)
            {

                string empBranch = getQueryResult("SELECT [branchID] FROM Employee WHERE employeeID =" + empID);
                string transBranch = getQueryResult("SELECT [branchID] FROM Transactions WHERE transactionID =" + int.Parse(transactionID.Text));


                int comparison = String.Compare(empBranch, transBranch);

                if (comparison != 0)
                {
                    //loction different fee
                    totalDue += LOC_FEE;
                    MessageBox.Show("ADDED LOCATION FEE: " + LOC_FEE);
                }

            }

            //if endDate doesnt equal today
            if (Convert.ToDateTime(dt.Rows[0][1])!=(DateTime.Today))
            {
                //MessageBox.Show("before " + totalDue);
                totalDue += (LATE_FEE * lateDays);
                //MessageBox.Show("after" + totalDue);
                MessageBox.Show("ADDED LATE FEE: " + LATE_FEE + " per late day(s): " + lateDays);
            }

            return totalDue;

        }

        private void updateNumberRentals(int currCustomerID, int noRentals)
        {


            //int noRentals = int.Parse(getQueryResult("Select noRentals from Customer where customerID = " + currCustomerID));
            String updateRentals = "UPDATE dbo.Customer SET noRentals=@noRentals WHERE customerID = " + currCustomerID;

            using (SqlConnection cnn3 = new SqlConnection(connectionStr))
            {
                try
                {
                    using (SqlCommand cmd3 = new SqlCommand(updateRentals, cnn3))
                    {
                        cmd3.Parameters.Add("@noRentals", SqlDbType.Int).Value = noRentals += 1; //increment number of rentals 
                        cmd3.Parameters.AddWithValue("@customerID", currCustomerID);

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

        private void checkNoRentals(int noRentals, int currCustomerID)

        {

            String updateRentals = "UPDATE dbo.Customer SET membership=@membership WHERE customerID = " + currCustomerID;
            if (noRentals >= 3)
            {
                using (SqlConnection cnn4 = new SqlConnection(connectionStr))
                {
                    try
                    {
                        using (SqlCommand cmd4 = new SqlCommand(updateRentals, cnn4))
                        {
                            cmd4.Parameters.Add("@membership", SqlDbType.Int).Value = 1; //set membership to 1 
                            cmd4.Parameters.AddWithValue("@customerID", currCustomerID);

                            MessageBox.Show("Youve been given a membership");

                            cnn4.Open();
                            cmd4.ExecuteNonQuery();
                            cnn4.Close();
                           
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

        }


    }
}




