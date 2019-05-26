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
    public partial class ManageCustomers : Form
    {
        private string dbFilePath;
        private decimal employeeID;
        private SqlConnection databaseConn;
        private HashSet<decimal> IDList;

        public ManageCustomers(string aDBFilePath, decimal aEmployeeID)
        {
            InitializeComponent();
            dbFilePath = aDBFilePath;
            employeeID = aEmployeeID;

            //Establish connection to database
            databaseConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + dbFilePath + ";Integrated Security=True");

            IDList = new HashSet<decimal>(); //Hashsets prevent duplicate entries and are more space efficient with larger amounts of data
        }

        private void ManageEmployeeScreen_load(object sender, EventArgs e)
        {
            this.customerInfoTableAdapter.Fill(this.hTVDatabaseDataSet_CustomerInfo.CustomerInfo);//Load data into viewable table
            Update_Fields(); //Call this so data is filled at the start of the form opening, rather than just when the first click is made
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Update_Fields_EventHandler(object sender, EventArgs e)
        {
            Update_Fields(); //Separated event version of method and standard method so MainScreen_Load could update the fields at the loading of the window
        }

        private void Populate_IDs()
        {
            IDList.Clear(); //Clear all existing elements incase we need to re-populate later.

            SqlDataAdapter IDCount = new SqlDataAdapter("SELECT CustomerID FROM CustomerInfo WHERE EXISTS (SELECT CustomerID FROM CustomerInfo);", databaseConn);
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
                ModifyButton.Text = "Modify";
                DeleteButton.Enabled = true; //Here to re-enable the cursor and visibility of the Delete button if required
                DeleteButton.Cursor = Cursors.Default;

                //Load only 1 row into memory, as loading the entire table could be disastrous with large tables :)
                SqlDataAdapter fields = new SqlDataAdapter("SELECT * FROM CustomerInfo WHERE CustomerID = '" + TableIndexBox.Value.ToString() + "' ", databaseConn);
                DataTable fieldsTable = new DataTable();

                try
                {
                    fields.Fill(fieldsTable);

                    //Try import found values over:
                    CustomerIDBox.Text = fieldsTable.Rows[0][0].ToString();
                    FirstNameText.Text = fieldsTable.Rows[0][1].ToString();
                    LastNameText.Text = fieldsTable.Rows[0][2].ToString();
                    AddressText.Text = fieldsTable.Rows[0][4].ToString();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Caught an exception locating data from table: " + ex.Message);
                }
            }
            else
            {
                ModifyButton.Text = "Add"; //We're adding new values now instead of modifying old ones
                DeleteButton.Enabled = false; //We also can't delete values that don't yet exist, so we should make the delete button greyed out
                DeleteButton.Cursor = Cursors.Cross;

                CustomerIDBox.Text = TableIndexBox.Value.ToString();
                FirstNameText.Text = "";
                LastNameText.Text = "";
                AddressText.Text = "12 Nowhere Road, 3000, VIC, Australia";
            }
        }

        //From tutorial: https://ourcodeworld.com/articles/read/507/how-to-allow-only-numbers-inside-a-textbox-in-winforms-c-sharp
        private void NumericOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private bool Check_Value_Entry()
        {
            //Check all values individually to make sure they're not empty
            bool result = true;

            if (this.CustomerIDBox.Text.Trim() == "")
            {
                result = false;
            }
            if (this.FirstNameText.Text.Trim() == "" || !Regex.IsMatch(this.AddressText.Text.Trim(), @"^[#.a-zA-Z\s,-]+$")) //Real names should not have numerical values!
            {
                result = false;
            }
            if (this.LastNameText.Text.Trim() == "" || !Regex.IsMatch(this.AddressText.Text.Trim(), @"^[#.a-zA-Z\s,-]+$")) //Real names should not have numerical values!
            {
                result = false;
            }
            if (this.AddressText.Text.Trim() == "" || !Regex.IsMatch(this.AddressText.Text.Trim(), @"^[#.0-9a-zA-Z\s,-]+$")) //Addresses should start with 1-4 digit numbers.
            {
                result = false;
            }


            if (!result)
            {
                MessageBox.Show("Data you have entered is invalid. Please check you are entering correct data and try again!");
            }

            return result;
        }

        private void Update_Database_Window()
        {
            //No matter what I try, this doesn't seem to work.
            try
            {
                this.hTVDatabaseDataSet_CustomerInfo.CustomerInfo.Clear();
                this.customerInfoTableAdapter.Fill(this.hTVDatabaseDataSet_CustomerInfo.CustomerInfo); //Load data again
                Populate_IDs();
                Debug.WriteLine("Updated GUI Table successfully.");
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Update of database window failed: " + ex.Message);
            }
        }

        private void Modify_Button(object sender, EventArgs e)
        {
            if (!IDList.Contains(TableIndexBox.Value))
            {
                if (Check_Value_Entry()) //Ensure that appropriate/not empty values are being submitted to the database.
                {
                    string query = "INSERT INTO [CustomerInfo] VALUES ('" + this.CustomerIDBox.Text.Trim() + "', '" + this.FirstNameText.Text.Trim() + "', '" + this.LastNameText.Text.Trim() + "', '" + this.AddressText.Text.Trim() + "');";
                    SqlCommand sqlCommand = new SqlCommand(query, databaseConn);
                    SqlDataReader DataReader;

                    try
                    {
                        databaseConn.Open();
                        DataReader = sqlCommand.ExecuteReader();
                        MessageBox.Show("Successfully added data to database.");
                        DataReader.Close(); //Close DataReader now operation has successfully completed.
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("An error occurred: " + exc.Message);
                    }
                }
            }
            else
            {
                string query = "UPDATE CustomerInfo SET FirstName = '" + this.FirstNameText.Text.Trim() + "', LastName = '" + this.LastNameText.Text.Trim() + "', ContactPhone = '" + this.AddressText.Text.Trim() + "' WHERE CustomerID = " + TableIndexBox.Value + ";";
                SqlCommand sqlCommand = new SqlCommand(query, databaseConn);
                SqlDataReader DataReader;

                try
                {
                    databaseConn.Open();
                    DataReader = sqlCommand.ExecuteReader();
                    MessageBox.Show("Successfully modified database information.");
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

        private void Delete_Button(object sender, EventArgs e)
        {
            if (!IDList.Contains(TableIndexBox.Value))
            {
                MessageBox.Show("Cannot delete nonexistent data.");
            }
            else
            {
                string query = "DELETE FROM CustomerInfo WHERE CustomerID = " + TableIndexBox.Value.ToString() + ";";
                SqlCommand sqlCommand = new SqlCommand(query, databaseConn);
                SqlDataReader DataReader;

                try
                {
                    databaseConn.Open();
                    DataReader = sqlCommand.ExecuteReader();
                    MessageBox.Show("Successfully deleted a row.");
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
            MainMenu mainMenuForm = new MainMenu(dbFilePath, employeeID);
            mainMenuForm.Closed += (s, args) => this.Close();
            mainMenuForm.Show();
        }
    }
}
