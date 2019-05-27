using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTVIndividualAssignment
{
    public partial class MainMenu : Form
    {
        private Employee loggedInEmployee;
        private string dbFilePath;

        public MainMenu(string aDBFilePath, Employee employee)
        {
            InitializeComponent();

            //Save arguments locally
            dbFilePath = aDBFilePath;
            loggedInEmployee = employee;
        }

        public void ManageEmployees_Button(object sender, EventArgs e)
        { 
            //Create Menu window if the user logs in successfully
            //From: https://stackoverflow.com/a/13459878
            this.Hide();
            ManageEmployees manageEmployeeForm = new ManageEmployees(dbFilePath, loggedInEmployee);
            manageEmployeeForm.ShowDialog();
            this.Show();
        }

        public void CreateOrder_Button(object sender, EventArgs e)
        {
            //Create Menu window if the user logs in successfully
            //From: https://stackoverflow.com/a/13459878
            this.Hide();
            NewOrder createOrderForm = new NewOrder(dbFilePath, loggedInEmployee);
            createOrderForm.ShowDialog();
            this.Show();
        }

        public void ManageOrders_Button(object sender, EventArgs e)
        {
            //Create Menu window if the user logs in successfully
            //From: https://stackoverflow.com/a/13459878
            this.Hide();
            ManageOrders manageOrdersForm = new ManageOrders(dbFilePath, loggedInEmployee);
            manageOrdersForm.ShowDialog();
            this.Show();
        }

        public void ManageCustomers_Button(object sender, EventArgs e)
        {
            //Create Menu window if the user logs in successfully
            //From: https://stackoverflow.com/a/13459878
            this.Hide();
            ManageCustomers manageCustomersForm = new ManageCustomers(dbFilePath, loggedInEmployee);
            manageCustomersForm.ShowDialog();
            this.Show();
        }

        public void ManageVehicles_Button(object sender, EventArgs e)
        {
            //Create Menu window if the user logs in successfully
            //From: https://stackoverflow.com/a/13459878
            this.Hide();
            ManageVehicles manageVehiclesForm = new ManageVehicles(dbFilePath, loggedInEmployee);
            manageVehiclesForm.ShowDialog();
            this.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            if (loggedInEmployee.EmployeeType == 0)
            {
                //Since the user is just a salesman, they should only be able to:
                // - Create a new order
                // - Manage orders
                // - Manage customers (e.g. to create a new one)
                //So we need to disable all other buttons
                ManageEmployeesButton.Enabled = false;
                ManageVehiclesButton.Enabled = false;
            }
        }
    }
}
