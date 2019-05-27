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
    public partial class ManageVehicles : Form
    {
        private string dbFilePath;
        private Employee loggedInEmployee;
        private SqlConnection databaseConn;
        private HashSet<decimal> IDList;

        public ManageVehicles(string aDBFilePath, Employee aEmployee)
        {
            InitializeComponent();
            dbFilePath = aDBFilePath;
            loggedInEmployee = aEmployee;

            //Establish connection to database
            databaseConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + dbFilePath + ";Integrated Security=True");

            IDList = new HashSet<decimal>(); //Hashsets prevent duplicate entries and are more space efficient with larger amounts of data
        }

        private void ManageEmployeeScreen_load(object sender, EventArgs e)
        {
            this.inventoryTableAdapter.Fill(this.hTVDatabaseDataSet_Inventory.Inventory);
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

            SqlDataAdapter IDCount = new SqlDataAdapter("SELECT EmployeeID FROM Employee WHERE EXISTS (SELECT EmployeeID FROM Employee);", databaseConn);
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
                SqlDataAdapter fields = new SqlDataAdapter("SELECT * FROM Inventory WHERE VehicleID = '" + TableIndexBox.Value.ToString() + "' ", databaseConn);
                DataTable fieldsTable = new DataTable();

                try
                {
                    fields.Fill(fieldsTable);

                    //Try import found values over:
                    VehicleIDBox.Text = fieldsTable.Rows[0][0].ToString();
                    SerialNumberText.Text = fieldsTable.Rows[0][1].ToString();
                    NameText.Text = fieldsTable.Rows[0][2].ToString();
                    ModelText.Text = fieldsTable.Rows[0][3].ToString();
                    YearText.Text = fieldsTable.Rows[0][4].ToString();
                    ManufacturerText.Text = fieldsTable.Rows[0][5].ToString();
                    BaseCostText.Text = fieldsTable.Rows[0][6].ToString();
                    if (Convert.ToBoolean(fieldsTable.Rows[0][7].ToString()))
                    {
                        AvailableBox.Checked = true;
                    }
                    else
                    {
                        AvailableBox.Checked = false;
                    }
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

                VehicleIDBox.Text = TableIndexBox.Value.ToString();
                SerialNumberText.Text = "0000-0000-0000";
                NameText.Text = "";
                ModelText.Text = "";
                YearText.Text = "1970";
                ManufacturerText.Text = "";
                BaseCostText.Text = "$0.0000";
                AvailableBox.Checked = false;
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

            if (this.VehicleIDBox.Text.Trim() == "" || !Regex.IsMatch(this.VehicleIDBox.Text.Trim(), @"^[a-zA-Z0-9.,?/-\s]*$"))
            {
                result = false;
            }
            if (this.SerialNumberText.Text.Trim() == "" || !Regex.IsMatch(this.SerialNumberText.Text.Trim(), @"[a-zA-Z0-9]{4}-[a-zA-Z0-9]{4}-[a-zA-Z0-9]{4}"))
            {
                result = false;
            }
            if(this.NameText.Text.Trim() == "" || !Regex.IsMatch(this.NameText.Text.Trim(), @"^[a-zA-Z0-9.,?/-\s]*$"))
            {
                result = false;
            }
            if(this.ModelText.Text.Trim() == "" || !Regex.IsMatch(this.ModelText.Text.Trim(), @"^[a-zA-Z0-9.,?/-\s]*$"))
            {
                result = false;
            }
            if(this.YearText.Text.Trim() == "" || !Regex.IsMatch(this.YearText.Text.Trim(), @"[0-9]{4}"))
            {
                result = false;
            }
            if(this.ManufacturerText.Text.Trim() == "" || !Regex.IsMatch(this.ManufacturerText.Text.Trim(), @"^[()a-zA-Z0-9.,?/-\s]*$"))
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
                this.hTVDatabaseDataSet_Inventory.Inventory.Clear();
                this.inventoryTableAdapter.Fill(this.hTVDatabaseDataSet_Inventory.Inventory); //Load data again
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
                    string query = "INSERT INTO Inventory VALUES (" + this.VehicleIDBox.Text.Trim() + ", '" + this.SerialNumberText.Text.Trim() + "', '" + this.NameText.Text.Trim() + "', '" + this.ModelText.Text.Trim() + "', " + this.YearText.Text.Trim() + ", '" + this.ManufacturerText.Text.Trim() + "', " + this.BaseCostText.Text.Trim() + ", ";
                    if (AvailableBox.Checked)
                    {
                        query += "1";
                    }
                    else
                    {
                        query += "0";
                    }
                    query += ");";

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
                string query = "UPDATE Inventory SET SerialNumber = '" + this.SerialNumberText.Text.Trim() + "', Model = '" + this.ModelText.Text.Trim() + "', Name = '" + this.NameText.Text.Trim() + "', Year = " + this.YearText.Text.Trim() + ", Manufacturer = '" + this.ManufacturerText.Text.Trim() + "', BaseCost = " + this.ModelText.Text.Trim() + ", Available = ";
                if (AvailableBox.Checked)
                {
                    query += "1";
                }
                else
                {
                    query += "0";
                }
                query += " WHERE EmployeeID = " + TableIndexBox.Value + ";";
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
                string query = "DELETE FROM Inventory WHERE EmployeeID = " + TableIndexBox.Value.ToString() + ";";
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
    }
}
