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
        private decimal employeeID;
        private string dbFilePath;

        public MainMenu(string aDBFilePath, decimal aEmployeeID = 0)
        {
            InitializeComponent();

            //Save arguments locally
            dbFilePath = aDBFilePath;
            employeeID = aEmployeeID;
        }

        public void ManageEmployees_Button(object sender, EventArgs e)
        { 
            //Create Menu window if the user logs in successfully
            //From: https://stackoverflow.com/a/13459878
            this.Hide();
            ManageEmployees manageEmployeeForm = new ManageEmployees(dbFilePath, employeeID);
            manageEmployeeForm.Closed += (s, args) => this.Close();
            manageEmployeeForm.Show();
        }

        public void CreateOrder_Button(object sender, EventArgs e)
        {
            //Create Menu window if the user logs in successfully
            //From: https://stackoverflow.com/a/13459878
            this.Hide();
            NewOrder createOrderForm = new NewOrder(dbFilePath, employeeID);
            createOrderForm.Closed += (s, args) => this.Close();
            createOrderForm.Show();
        }

        public void ManageOrders_Button(object sender, EventArgs e)
        {
            //Create Menu window if the user logs in successfully
            //From: https://stackoverflow.com/a/13459878
            this.Hide();
            ManageOrders manageOrdersForm = new ManageOrders(dbFilePath, employeeID);
            manageOrdersForm.Closed += (s, args) => this.Close();
            manageOrdersForm.Show();
        }

        public void ManageCustomers_Button(object sender, EventArgs e)
        {
            //Create Menu window if the user logs in successfully
            //From: https://stackoverflow.com/a/13459878
            this.Hide();
            ManageCustomers manageCustomersForm = new ManageCustomers(dbFilePath, employeeID);
            manageCustomersForm.Closed += (s, args) => this.Close();
            manageCustomersForm.Show();
        }
    }
}
