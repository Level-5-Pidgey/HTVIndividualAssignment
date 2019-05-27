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
    public partial class NewOrder : Form
    {
        private string dbFilePath;
        private Employee loggedInEmployee;
        private SqlConnection databaseConn;

        //Items required to display form information:
        //--------------------------------------------
        //All relevant information for customers
        private List<Customer> Customers = new List<Customer>();
        private List<Vehicle> Vehicles = new List<Vehicle>();
        private List<AddOn> AddOns = new List<AddOn>();
        List<AddOn> availableAddons = new List<AddOn>();

        //Selected values
        private Vehicle currentlySelectedVehicle;
        private Customer currentlySelectedCustomer;
        private AddOn[] currentlySelectedAddOns = new AddOn[3];
        private decimal totalCost = 0;

        public NewOrder(string aDBFilePath, Employee aEmployee)
        {
            InitializeComponent();

            dbFilePath = aDBFilePath;
            loggedInEmployee = aEmployee;

            //Establish connection to database
            databaseConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + dbFilePath + ";Integrated Security=True");
        }

        private void NewOrderScreen_Load(object sender, EventArgs e)
        {
            //Populate the different required elements
            Load_Customer_List();
            Load_Vehicle_List();
            Find_OrderNumber();

            //Check if any of the lists are empty
            if (Customers.Count == 0)
            {
                CustomerBox.Items.Add("[No customers in table]");
            }
            if (Vehicles.Count == 0)
            {
                VehicleBox.Items.Add("[No vehicles in table]");
            }

            //Change form elements to loaded values
            foreach (Customer c in Customers)
            {
                CustomerBox.Items.Add(c.ToString());
            }

            foreach (Vehicle v in Vehicles)
            {
                VehicleBox.Items.Add(v.ToString());
            }

            EmployeeTextBox.Text = loggedInEmployee.ID.ToString(); //All orders created by the logged in employee are logged
        }

        private void Load_Customer_List()
        {
            SqlDataAdapter CustomerList = new SqlDataAdapter("SELECT CustomerID, FirstName, LastName FROM CustomerInfo;", databaseConn);
            DataTable CustomerDataTable = new DataTable();
            CustomerList.Fill(CustomerDataTable);

            foreach (DataRow dr in CustomerDataTable.Rows)
            {
                Customers.Add(new Customer(Convert.ToDecimal(dr.ItemArray[0].ToString()), dr.ItemArray[1].ToString().Trim(), dr.ItemArray[2].ToString().Trim()));
            }
            CustomerList.Dispose(); //Free resources now data is exported
        }

        private void Find_OrderNumber()
        {
            SqlDataAdapter OrderList = new SqlDataAdapter("SELECT MAX(OrderID) MaxOrderID FROM [Order];", databaseConn);
            DataTable OrderDataTable = new DataTable();

            try
            {
                OrderList.Fill(OrderDataTable);
                OrderIDTextBox.Text = (Convert.ToInt32(OrderDataTable.Rows[0].ItemArray[0].ToString()) + 1).ToString();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Ordernumber Importing error:" + ex.Message + " (Presumed to be beacuse there are no rows in Order)");
                OrderIDTextBox.Text = "0";
            }

            OrderList.Dispose(); //Free resources now data is exported
        }

        private void Load_Vehicle_List()
        {
            SqlDataAdapter VehicleList = new SqlDataAdapter("SELECT VehicleID, Model, Manufacturer, Year, BaseCost FROM Inventory;", databaseConn);
            DataTable VehicleDataTable = new DataTable();
            VehicleList.Fill(VehicleDataTable);

            foreach (DataRow dr in VehicleDataTable.Rows)
            {
                Vehicles.Add(new Vehicle(Convert.ToDecimal(dr.ItemArray[0].ToString()), dr.ItemArray[1].ToString(), dr.ItemArray[2].ToString(), Convert.ToInt32(dr.ItemArray[3].ToString()), Convert.ToDecimal(dr.ItemArray[4].ToString())));
            }
            VehicleList.Dispose(); //Free resources now data is exported
        }
        
        private void Load_AddOn_List()
        {
            SqlDataAdapter AddOnList = new SqlDataAdapter("SELECT AddonID, Vehicle, Name, Cost FROM AddOns;", databaseConn);
            DataTable AddOnDataTable = new DataTable();
            AddOnList.Fill(AddOnDataTable);

            //Clear existing data from add on-lists and repopulate
            AddOns.Clear();

            foreach (DataRow dr in AddOnDataTable.Rows)
            { 
                AddOns.Add(new AddOn(Convert.ToDecimal(dr.ItemArray[0].ToString()), Convert.ToDecimal(dr.ItemArray[1].ToString()), dr.ItemArray[2].ToString().Trim(), Convert.ToDecimal(dr.ItemArray[3].ToString())));
            }
            AddOnList.Dispose(); //Free resources now data is exported
        }

        private void Update_AddOnLists()
        {
            //Clear existing data
            //On update of the vehicle ID, create new Add-Ons
            AddOnBox1.Items.Clear();
            AddOnBox2.Items.Clear();
            AddOnBox3.Items.Clear();
            availableAddons.Clear();

            Load_AddOn_List();

            foreach (AddOn a in AddOns) //Populate available add-ons for all add-ons relevant to currently selected vehicle
            {
                if (a.VehicleID == currentlySelectedVehicle.ID)
                {
                    availableAddons.Add(a);
                }
            }

            if (availableAddons.Count == 0)
            {
                AddOnBox1.Items.Add("[No Add-Ons Available.]");
                AddOnBox2.Items.Add("[No Add-Ons Available.]");
                AddOnBox3.Items.Add("[No Add-Ons Available.]");
            }
            else
            {
                //Add an empty add-on in-case people don't want to select an add-on at all.
                AddOnBox1.Items.Add("[None]");
                AddOnBox2.Items.Add("[None]");
                AddOnBox3.Items.Add("[None]");

                foreach (AddOn a in availableAddons)
                {
                    AddOnBox1.Items.Add(a.ToString());
                    AddOnBox2.Items.Add(a.ToString());
                    AddOnBox3.Items.Add(a.ToString());
                }

                //Set the default value to "[None]" so we can see that the add-ons have loaded in successfully.
                AddOnBox1.Text = "[None]";
                AddOnBox2.Text = "[None]";
                AddOnBox3.Text = "[None]";
            }
        }

        private void Update_Costs_Event(object sender, EventArgs e)
        {
            totalCost = 0; //Reset total cost value and re-calculate

            //Change add-on applied local variable to duplicate from list of available add-ons
            #region PopulateSelectedAddOns
            foreach (AddOn a in availableAddons)
            {
                if (AddOnBox1.Text.Contains(a.Name))
                {
                    currentlySelectedAddOns[0] = a;
                }
                if (AddOnBox2.Text.Contains(a.Name))
                {
                    currentlySelectedAddOns[1] = a;
                }
                if (AddOnBox3.Text.Contains(a.Name))
                {
                    currentlySelectedAddOns[2] = a;
                }
            }
            #endregion

            //Double-checking for no add-ons and properly replacing them with null values
            #region ReplaceWithNulls
            if (AddOnBox1.Text.Contains("[None]") || AddOnBox1.Text.Contains("[No Add-Ons Available.]"))
            {
                currentlySelectedAddOns[0] = null;
            }
            if (AddOnBox2.Text.Contains("[None]") || AddOnBox2.Text.Contains("[No Add-Ons Available.]"))
            {
                currentlySelectedAddOns[1] = null;
            }
            if (AddOnBox3.Text.Contains("[None]") || AddOnBox3.Text.Contains("[No Add-Ons Available.]"))
            {
                currentlySelectedAddOns[2] = null;
            }
            #endregion

            foreach (AddOn a in currentlySelectedAddOns)
            {
                if (a != null)
                {
                    totalCost += a.Cost;
                }
            }

            totalCost += currentlySelectedVehicle.Cost;

            CostBox.Text = totalCost.ToString();
        }

        private void VehicleIndex_Changed(object sender, EventArgs e)
        {
            foreach (Vehicle v in Vehicles)
            {
                if (VehicleBox.Text.Contains("[" + v.ID + "]"))
                {
                    currentlySelectedVehicle = v;
                    break;
                }
            }
            Update_AddOnLists();
        }

        private void CustomerBox_Changed(object sender, EventArgs e)
        {
            foreach (Customer c in Customers)
            {
                if (CustomerBox.Text.Contains("[" + c.ID + "]"))
                {
                    currentlySelectedCustomer = c;
                    break;
                }
            }
        }

        private bool Check_Value_Entry()
        {
            //Check all values individually to make sure they're not empty
            bool result = true;

            //OrderIDs cannot be empty and must have a numerical value
            if (this.OrderIDTextBox.Text.Trim() == "" || !Regex.IsMatch(this.OrderIDTextBox.Text.Trim(), "[0-9]+"))
            {
                result = false;
            }

            //Customer ID must have a numerical value and must not be empty!
            if (this.currentlySelectedCustomer == null || !Customers.Any(n1 => n1.ID == this.currentlySelectedCustomer.ID))
            {
                result = false;
            }

            //Vehicle ID must be a numerical value and must already exist in the database
            if (!Vehicles.Any(n1 => n1.ID != this.currentlySelectedVehicle.ID) || this.currentlySelectedCustomer == null)
            {
                result = false;
            }

            //Check addons -- they must be either null, or existant in the ID database
            //Additionally we need to check if there are null values in the middle of the add-ons list (e.g. [0, NULL, 0] is invalid, [0, 0, NULL] is valid)
            //We also need to check if there are any duplicate add-ons present. They're supposed to be unique!
            #region AddOnValidation
            if (currentlySelectedAddOns[0] != null)
            {
                if (!availableAddons.Any(n1 => n1.ID == currentlySelectedAddOns[0].ID)) //Need to nest the loop, otherwise the program crashes trying to check null objects
                {
                    result = false;
                }
                
                if (currentlySelectedAddOns[1] == null && currentlySelectedAddOns[2] != null) //Can't have [0, NULL, 0] add-on arrangements
                {
                    result = false;
                }

                //Annoying have to have these within this if-statement
                if(currentlySelectedAddOns[1] != null)
                {
                    if (currentlySelectedAddOns[0].ID == currentlySelectedAddOns[1].ID)
                    {
                        result = false;
                    }
                }

                if (currentlySelectedAddOns[2] != null)
                {
                    if (currentlySelectedAddOns[0].ID == currentlySelectedAddOns[2].ID)
                    {
                        result = false;
                    }
                }
            }
            else
            {
                //index 0 is null, so everything should be null.
                if (currentlySelectedAddOns[1] != null || currentlySelectedAddOns[2] != null)
                {
                    result = false;
                }
            }

            if (currentlySelectedAddOns[1] != null)
            {
                if (!availableAddons.Any(n1 => n1.ID == currentlySelectedAddOns[1].ID)) //Need to nest the loop, otherwise the program crashes trying to check null objects
                {
                    result = false;
                }

                //Again, sadly cannot do this statement in the below if-group >:(
                if (currentlySelectedAddOns[2] != null)
                {
                    if (currentlySelectedAddOns[1].ID == currentlySelectedAddOns[2].ID)
                    {
                        result = false;
                    }
                }
            }
            else
            {
                if (currentlySelectedAddOns[2] != null)
                {
                    result = false;
                }
            }

            if (currentlySelectedAddOns[2] != null)
            {
                if (!availableAddons.Any(n1 => n1.ID == currentlySelectedAddOns[2].ID)) //Need to nest the loop, otherwise the program crashes trying to check null objects
                {
                    result = false;
                }
            }
            #endregion

            //Costs should not be empty, and should be a string of numbers with 4 decimal places to comply with SQL's MONEY data type.
            if (this.CostBox.Text.Trim() == "" || !Regex.IsMatch(this.CostBox.Text.Trim(), @"^[0-9]+(\.[0-9]{1,4})?$"))
            {
                result = false;
            }

            //Give message if data is invalid
            if (!result)
            {
                MessageBox.Show("Data you have entered is invalid. Please check you are entering correct data and try again!");
            }

            return result;
        }

        private void Push_Order(object sender, EventArgs e)
        {
            if (Check_Value_Entry()) //Ensure that appropriate/not empty values are being submitted to the database.
            {
                string query = "INSERT INTO [Order] (OrderID, CustomerID, EmployeeID, VehicleID, AddOn1, AddOn2, AddOn3, TotalCost) VALUES (" + OrderIDTextBox.Text + ", " + currentlySelectedCustomer.ID + ", " + loggedInEmployee.ID + ", " + currentlySelectedVehicle.ID + ", ";
                
                //Adding Add-ons
                #region AddOnQueryAdd
                if (currentlySelectedAddOns[0] == null)
                {
                    query += "NULL, ";
                }
                else
                {
                    query += currentlySelectedAddOns[0].ID + ", ";
                }

                if (currentlySelectedAddOns[1] == null)
                {
                    query += "NULL, ";
                }
                else
                {
                    query += currentlySelectedAddOns[1].ID + ", ";
                }

                if(currentlySelectedAddOns[2] == null)
                {
                    query += "NULL, ";
                }
                else
                {
                    query += currentlySelectedAddOns[2].ID + ", ";
                }
                #endregion

                query += CostBox.Text.Trim() + ");";

                SqlCommand sqlCommand = new SqlCommand(query, databaseConn);
                SqlDataReader DataReader;

                try
                {
                    databaseConn.Open();
                    DataReader = sqlCommand.ExecuteReader();
                    MessageBox.Show("Successfully added data to database.");
                    DataReader.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("An error occurred: " + exc.Message);
                }
            }
        }
    }
}
