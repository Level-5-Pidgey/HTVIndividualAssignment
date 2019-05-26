namespace HTVIndividualAssignment
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainMenuBox = new System.Windows.Forms.GroupBox();
            this.ManageEmployeesButton = new System.Windows.Forms.Button();
            this.OrderManagementGroup = new System.Windows.Forms.GroupBox();
            this.ManageOrdersButton = new System.Windows.Forms.Button();
            this.CreateNewOrderButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MainMenuBox.SuspendLayout();
            this.OrderManagementGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuBox
            // 
            this.MainMenuBox.Controls.Add(this.button1);
            this.MainMenuBox.Controls.Add(this.ManageEmployeesButton);
            this.MainMenuBox.Controls.Add(this.OrderManagementGroup);
            this.MainMenuBox.Location = new System.Drawing.Point(13, 13);
            this.MainMenuBox.Name = "MainMenuBox";
            this.MainMenuBox.Size = new System.Drawing.Size(233, 251);
            this.MainMenuBox.TabIndex = 0;
            this.MainMenuBox.TabStop = false;
            this.MainMenuBox.Text = "Dashboard Access";
            // 
            // ManageEmployeesButton
            // 
            this.ManageEmployeesButton.Location = new System.Drawing.Point(49, 107);
            this.ManageEmployeesButton.Name = "ManageEmployeesButton";
            this.ManageEmployeesButton.Size = new System.Drawing.Size(129, 23);
            this.ManageEmployeesButton.TabIndex = 2;
            this.ManageEmployeesButton.Text = "Manage Employees";
            this.ManageEmployeesButton.UseVisualStyleBackColor = true;
            this.ManageEmployeesButton.Click += new System.EventHandler(this.ManageEmployees_Button);
            // 
            // OrderManagementGroup
            // 
            this.OrderManagementGroup.Controls.Add(this.ManageOrdersButton);
            this.OrderManagementGroup.Controls.Add(this.CreateNewOrderButton);
            this.OrderManagementGroup.Location = new System.Drawing.Point(6, 19);
            this.OrderManagementGroup.Name = "OrderManagementGroup";
            this.OrderManagementGroup.Size = new System.Drawing.Size(221, 82);
            this.OrderManagementGroup.TabIndex = 1;
            this.OrderManagementGroup.TabStop = false;
            this.OrderManagementGroup.Text = "Manage Orders";
            // 
            // ManageOrdersButton
            // 
            this.ManageOrdersButton.Location = new System.Drawing.Point(43, 48);
            this.ManageOrdersButton.Name = "ManageOrdersButton";
            this.ManageOrdersButton.Size = new System.Drawing.Size(129, 23);
            this.ManageOrdersButton.TabIndex = 0;
            this.ManageOrdersButton.Text = "Manage Existing Orders";
            this.ManageOrdersButton.UseVisualStyleBackColor = true;
            this.ManageOrdersButton.Click += new System.EventHandler(this.ManageOrders_Button);
            // 
            // CreateNewOrderButton
            // 
            this.CreateNewOrderButton.Location = new System.Drawing.Point(43, 19);
            this.CreateNewOrderButton.Name = "CreateNewOrderButton";
            this.CreateNewOrderButton.Size = new System.Drawing.Size(129, 23);
            this.CreateNewOrderButton.TabIndex = 0;
            this.CreateNewOrderButton.Text = "Create New Order";
            this.CreateNewOrderButton.UseVisualStyleBackColor = true;
            this.CreateNewOrderButton.Click += new System.EventHandler(this.CreateOrder_Button);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Manage Customers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ManageCustomers_Button);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 275);
            this.Controls.Add(this.MainMenuBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HTV Staff Dashboard";
            this.MainMenuBox.ResumeLayout(false);
            this.OrderManagementGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MainMenuBox;
        private System.Windows.Forms.Button ManageEmployeesButton;
        private System.Windows.Forms.GroupBox OrderManagementGroup;
        private System.Windows.Forms.Button ManageOrdersButton;
        private System.Windows.Forms.Button CreateNewOrderButton;
        private System.Windows.Forms.Button button1;
    }
}