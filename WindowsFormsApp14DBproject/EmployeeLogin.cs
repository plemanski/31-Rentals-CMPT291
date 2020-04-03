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
    public partial class EmployeeLogin : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-CEF6NO7;Initial Catalog=Cars5_291;Integrated Security=True");
        SqlCommand cmd;
        DataSet ds = new DataSet();


        public EmployeeLogin()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            //If there is no input then call invalidate 
            if (empID.Text == "")
            {
                Invalidate();
            }


            else
            {
                try
                {
                    //Get employeeID and check if it is in the dataset 
                    int txtempID = int.Parse(empID.Text);

                    con.Open();
                    string selectID = "SELECT * FROM dbo.Employee WHERE employeeID=" + txtempID;
                    cmd = new SqlCommand(selectID, con);
                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    data.Fill(ds);
                    int i = ds.Tables[0].Rows.Count;


                    //If valid ID, open updateInventory and close employeeLogin screen 
                    if (i > 0)
                    {

                        UpdateInventory updateQueue = new UpdateInventory(txtempID);
                        updateQueue.MdiParent = this.MdiParent;
                        LayoutMdi(MdiLayout.Cascade);
                        this.Visible = false;
                        updateQueue.Show();
                        ds.Clear();
                        this.Close();
                    }


                    else //when user entered invalid ID
                    {
                        Invalidate();
                    }

                    con.Close();

                }
                catch (Exception)
                {
                    Invalidate();
                }
            }
        }

        //If the employee ID is invalid, show error message
        private new void Invalidate()
        {
            invalid.Visible = true;
        }
    }
}
