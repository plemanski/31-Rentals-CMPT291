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
    public partial class Main : Form
    {
        readonly string connectionStr = "Data Source=DESKTOP-CEF6NO7;Initial Catalog=Cars5_291;Integrated Security=True";
        readonly DateTime BEGIN_Q1 = new DateTime(2020, 1, 1);
        public Main()
        {
            InitializeComponent();
            if (DateTime.Today.Day == BEGIN_Q1.Day && DateTime.Today.Month == BEGIN_Q1.Month)
            {
                string sql = "UPDATE Customer " +
                    "SET noRentals=0";
                SqlConnection dbConnection = new SqlConnection(connectionStr);
                using (SqlCommand sqlCommand = new SqlCommand(sql, dbConnection))
                {
                    dbConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

        // CLicking on Rent in the menu tool strip creates a new child form
        private void rentACarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rent newRental = new Rent(); // Creates a new rent form
            newRental.MdiParent = this;  // Sets the main form as the parent of the new rental form
            LayoutMdi(MdiLayout.Cascade); // Sets the layout of child form in cascade
            newRental.Show(); // show the new form
        }

        private void updateInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //show employee login before the update inventory screen
            EmployeeLogin employee = new EmployeeLogin();
            employee.MdiParent = this;
            LayoutMdi(MdiLayout.Cascade);
            employee.Show();

        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void generateReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateReport report = new GenerateReport(); // Creates a new re
            report.MdiParent = this;  // Sets the main form as the parent of the new rental form
            LayoutMdi(MdiLayout.Cascade); // Sets the layout of child form in cascade
            report.Show(); // show the new form

        }
    }
}
