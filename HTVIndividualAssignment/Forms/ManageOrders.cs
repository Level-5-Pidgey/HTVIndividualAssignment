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
using System.Media;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace HTVIndividualAssignment
{
    public partial class ManageOrders : Form
    {
        private string dbFilePath;
        private Employee loggedInEmployee;
        private SqlConnection databaseConn;
        private HashSet<decimal> IDList;

        public ManageOrders(string aDBFilePath, Employee aEmployee)
        {
            InitializeComponent();
            loggedInEmployee = aEmployee;
            dbFilePath = aDBFilePath;

            //Establish connection to database
            databaseConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + dbFilePath + ";Integrated Security=True");

            IDList = new HashSet<decimal>(); //Hashsets prevent duplicate entries and are more space efficient with larger amounts of data
        }

        private void Update_Fields_EventHandler(object sender, EventArgs e)
        {
            Update_Fields(); //Separated event version of method and standard method so MainScreen_Load could update the fields at the loading of the window
        }

        private void Populate_IDs()
        {
            IDList.Clear(); //Clear all existing elements incase we need to re-populate later.

            SqlDataAdapter IDCount = new SqlDataAdapter("SELECT OrderID FROM [Order] WHERE EXISTS (SELECT OrderID FROM [Order]);", databaseConn);
            DataTable IDTable = new DataTable();
            IDCount.Fill(IDTable);

            foreach (DataRow dr in IDTable.Rows)
            {
                IDList.Add(Convert.ToDecimal(dr.ItemArray[0].ToString()));
            }
        }

        private void Update_Fields()
        {
            if (IDList.Count == 0) //Collect a list of IDs in the table if there isn't one yet
            {
                Populate_IDs();
            }

            if (IDList.Contains(TableIndexBox.Value))
            {
                DeleteButton.Enabled = true; //Here to re-enable the cursor and visibility of the Delete button if required
                DeleteButton.Cursor = Cursors.Default;

                //Load only 1 row into memory, as loading the entire table could be disastrous with large tables :)
                SqlDataAdapter fields = new SqlDataAdapter("SELECT * FROM [Order] WHERE OrderID = '" + TableIndexBox.Value.ToString() + "' ", databaseConn);
                DataTable fieldsTable = new DataTable();

                try
                {
                    fields.Fill(fieldsTable);

                    //Try import found values over:
                    CustomerIDBox.Text = fieldsTable.Rows[0][1].ToString();
                    EmployeeIDBox.Text = fieldsTable.Rows[0][2].ToString();
                    VehicleIDBox.Text = fieldsTable.Rows[0][3].ToString();
                    AddOnBox1.Text = fieldsTable.Rows[0][4].ToString();
                    AddOnBox2.Text = fieldsTable.Rows[0][5].ToString();
                    AddOnBox3.Text = fieldsTable.Rows[0][6].ToString();
                    CostBox.Text = "$" + fieldsTable.Rows[0][7].ToString();
                    if(Convert.ToBoolean(fieldsTable.Rows[0][8].ToString()))
                    {
                        PaidBox.Checked = true;
                    }
                    else
                    {
                        PaidBox.Checked = false;
                    }
                    TimeBox.Text = fieldsTable.Rows[0][9].ToString();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Caught an exception locating data from table: " + ex.Message);
                }
            }
            else
            {
                //Put empty values in the order fields:
                CustomerIDBox.Text = "";
                EmployeeIDBox.Text = "";
                VehicleIDBox.Text = "";
                AddOnBox1.Text = "[None]";
                AddOnBox2.Text = "[None]";
                AddOnBox3.Text = "[None]";
                CostBox.Text = "$0.0000";
                PaidBox.Checked = false;
                TimeBox.Text = "";

                DeleteButton.Enabled = false; //We also can't delete values that don't yet exist, so we should make the delete button greyed out
                DeleteButton.Cursor = Cursors.Cross;
            }
        }

        private void Update_Database_Window()
        {
            //No matter what I try, this doesn't seem to work.
            try
            {
                this.hTVDatabaseDataSet_Orders.Order.Clear();
                this.orderTableAdapter.Fill(this.hTVDatabaseDataSet_Orders.Order);
                Populate_IDs();
                Debug.WriteLine("Updated GUI Table successfully.");
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Update of database window failed: " + ex.Message);
            }
        }

        private void Delete_Button(object sender, EventArgs e)
        {
            if (!IDList.Contains(TableIndexBox.Value))
            {
                MessageBox.Show("Cannot delete nonexistent data.");
            }
            else
            {
                string query = "DELETE FROM [Order] WHERE OrderID = " + TableIndexBox.Value.ToString() + ";";
                SqlCommand sqlCommand = new SqlCommand(query, databaseConn);
                SqlDataReader DataReader;

                try
                {
                    databaseConn.Open();
                    DataReader = sqlCommand.ExecuteReader();
                    MessageBox.Show("Successfully deleted this order!");
                    DataReader.Close(); //Close DataReader now operation has successfully completed.
                }
                catch (Exception exc)
                {
                    MessageBox.Show("An error occurred: " + exc.Message);
                }
            }

            //Regardless of what happens, we now want to re-populate the table in the form window.
            Update_Database_Window();
        }

        private void SetPaid_Check(object sender, EventArgs e)
        {
            if (!IDList.Contains(TableIndexBox.Value))
            {
                MessageBox.Show("Cannot set this order to paid -- it does not exist.");
            }
            else
            {
                string query = "UPDATE [Order] SET Paid = ";
                if (PaidBox.Checked)
                {
                    query += "1";
                }
                else
                {
                    query += "0";
                }
                query += " WHERE OrderID = " + TableIndexBox.Value + ";";
                SqlCommand sqlCommand = new SqlCommand(query, databaseConn);
                SqlDataReader DataReader;

                try
                {
                    databaseConn.Open();
                    DataReader = sqlCommand.ExecuteReader();
                    MessageBox.Show("Order status changed!");
                    DataReader.Close(); //Close DataReader now operation has successfully completed.
                    databaseConn.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("An error occurred: " + exc.Message);
                }
            }

            //Regardless of what happens, we now want to re-populate the table in the form window.
            Update_Database_Window();
        }

        //Safely override closing of window
        //From post: https://stackoverflow.com/a/1669341
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            //If the user isn't trying to close this form in a shutdown manner, open up the main menu form again
            //Create Menu window if the user logs in successfully
            //From: https://stackoverflow.com/a/13459878
            this.Hide();
            MainMenu mainMenuForm = new MainMenu(dbFilePath, loggedInEmployee);
            mainMenuForm.ShowDialog();
            mainMenuForm.Show();
        }

        private void ManageOrders_Load(object sender, EventArgs e)
        {
            this.orderTableAdapter.Fill(this.hTVDatabaseDataSet_Orders.Order);
            Update_Fields();
        }
    }
}
