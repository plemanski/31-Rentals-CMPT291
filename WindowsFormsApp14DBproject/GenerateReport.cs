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
    public partial class GenerateReport : Form
    {

        string connetionString = "Data Source=DESKTOP-CEF6NO7;Initial Catalog=Cars5_291;Integrated Security=True";

        public GenerateReport()
        {
            InitializeComponent();
        }

        private void GenerateReport_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }




        private void GenerateTable(string query, DataGridView dataGridName)
        {

            using (SqlConnection sqlConnection = new SqlConnection(connetionString))
            {

                //Opens the connection to the database
                sqlConnection.Open();

                //makes  new data table that will be used to display data on the datagrid
                DataTable table = new DataTable();

                //gets the data from the query inserted from the user
                SqlDataAdapter sqlData = new SqlDataAdapter(query, sqlConnection);

                //fills the data into the table
                sqlData.Fill(table);
                dataGridName.DataSource = table;



            }


        }



        private void button1_Click(object sender, EventArgs e)
        {

            /**
         * Top 5 employees is determined by the top 5 people who done the most transactions, the top 5 function is used on the selected column. The column is also in descending order.
         * The employee ID's are returned. From those ID's the employee table data is returned to the user.
         * 
         */
            if (comboBox1.SelectedIndex == 0)
            {
                string top5 = "select * " +
                           " from Employee "
                           + " where employeeID in " +
                           " (select  top 5 employeeID " +
                           " from Transactions group by employeeID " +
                           " order by count(employeeID) DESC )";

                GenerateTable(top5, dataGridView1);
            }

            /**
             * BEST customer are select from the customer table. They are the ones with the most purchases. 
             * 
             */

            if (comboBox1.SelectedIndex == 1)
            {


                string bestCustomerquery = "select customerID, name " +
               "from Customer where customerID in " +
               "(select top 1 with TIES customerID" +
               " from Transactions " +
               "group by customerID " +
               "order by count(CustomerID) DESC)";
                GenerateTable(bestCustomerquery, dataGridView1);

            }

            /**
             * The worst branch is determined by the least amount of rentals a branch does. To get this result, the query tallies the amount of transactions each branch does.
             * Then it orders the branch by ascending order. Then the top 1 branch ID's with ties is returned. Once the ID's of the branches is returned. The Branch ID is used to
             * get branch information from the branch table. Such as the description, location and ID.
             * 
             */

            if (comboBox1.SelectedIndex == 2)
            {
                string worstBranchquery = (" select * from Branch where branchID in( select top 1 with TIES branchID from Transactions " +

                   "group by branchID order by count(BranchID) asc)");

                GenerateTable(worstBranchquery, dataGridView1);

            }

            if (comboBox1.SelectedIndex == 3)
            {
                /**
                 * The cars are grouped by their make and their occurances are counted. The first of the column has the highest count. So the count is taken from the first
                 * row. Howver there can be ties for the most rented car so ties are included.
                 */
                string mostPopular = "select top 1 with TIES make from Cars    group by make        order by count(make) DESC ";
                GenerateTable(mostPopular, dataGridView1);

            }

            if (comboBox1.SelectedIndex == 4)
            {
                /**
                 * This query selects the begindDate and endDate columns and takes the difference between the two columns using the DATEDIFF function.
                 * Then the average is calcuated and the days of average rented days is returned.
                 */
                string averageRentedFor = "select AVG(DATEDIFF (day, beginDate, endDate)) as Days from Transactions; ";
                GenerateTable(averageRentedFor, dataGridView1);


            }





        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}