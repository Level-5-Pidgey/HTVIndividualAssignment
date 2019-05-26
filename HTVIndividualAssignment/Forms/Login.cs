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

namespace HTVIndividualAssignment
{
    public partial class Login : Form
    {
        private string dbFilePath;
        private decimal employeeID;

        private SqlConnection databaseConn;

        public Login(string aDBFilePath)
        {
            dbFilePath = aDBFilePath;
            InitializeComponent();

            //Establish connection to database
            databaseConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + dbFilePath + ";Integrated Security=True;User Instance=False");
        }

        private void Login_Click(object sender, EventArgs e)
        {
            //Check if password is correct -- input is already validated in NumericOnly_KeyPress method
            string query = "SELECT * FROM Employee WHERE EmployeeID = '" + this.LoginName.Text.Trim() + "' AND EmployeeType = '" + this.PasswordBox.Text.Trim() + "'";
            SqlDataAdapter SDAdapter = new SqlDataAdapter(query, databaseConn);
            DataTable DTable = new DataTable();

            SDAdapter.Fill(DTable);

            if (DTable.Rows.Count == 1)
            {
                employeeID = Convert.ToDecimal(DTable.Rows[0][0]);

                //Create Menu window if the user logs in successfully
                //From: https://stackoverflow.com/a/13459878
                this.Hide();
                MainMenu mainMenuForm = new MainMenu(dbFilePath, employeeID);
                mainMenuForm.Closed += (s, args) => this.Close();
                mainMenuForm.Show();
            }
            else
            {
                MessageBox.Show("Username/Password combination is incorrect. Username must be the EmployeeID, and the password is the usertype integer.");
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

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        //From https://stackoverflow.com/a/14997273
        //Credit to IMMORTAL -- asks for confirmation before closing
        private void FormClose(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (PreClosingConfirmation() == DialogResult.Yes)
            {
                Dispose(true);
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private DialogResult PreClosingConfirmation()
        {
            DialogResult res = MessageBox.Show(" Do you want to quit?          ", "Quit...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return res;
        }
    }
}
