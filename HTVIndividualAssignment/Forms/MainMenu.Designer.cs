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
            this.components = new System.ComponentModel.Container();
            this.MainMenuBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ManageAddOnsButton = new System.Windows.Forms.Button();
            this.ManageVehiclesButton = new System.Windows.Forms.Button();
            this.ManageEmployeesButton = new System.Windows.Forms.Button();
            this.OrderManagementGroup = new System.Windows.Forms.GroupBox();
            this.ManageOrdersButton = new System.Windows.Forms.Button();
            this.CreateNewOrderButton = new System.Windows.Forms.Button();
            this.AddOnsTT = new System.Windows.Forms.ToolTip(this.components);
            this.MainMenuBox.SuspendLayout();
            this.OrderManagementGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuBox
            // 
            this.MainMenuBox.Controls.Add(this.button1);
            this.MainMenuBox.Controls.Add(this.ManageAddOnsButton);
            this.MainMenuBox.Controls.Add(this.ManageVehiclesButton);
            this.MainMenuBox.Controls.Add(this.ManageEmployeesButton);
            this.MainMenuBox.Controls.Add(this.OrderManagementGroup);
            this.MainMenuBox.Location = new System.Drawing.Point(13, 13);
            this.MainMenuBox.Name = "MainMenuBox";
            this.MainMenuBox.Size = new System.Drawing.Size(233, 251);
            this.MainMenuBox.TabIndex = 0;
            this.MainMenuBox.TabStop = false;
            this.MainMenuBox.Text = "Dashboard Access";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Manage Customers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ManageCustomers_Button);
            // 
            // ManageAddOnsButton
            // 
            this.ManageAddOnsButton.Cursor = System.Windows.Forms.Cursors.No;
            this.ManageAddOnsButton.Location = new System.Drawing.Point(49, 203);
            this.ManageAddOnsButton.Name = "ManageAddOnsButton";
            this.ManageAddOnsButton.Size = new System.Drawing.Size(129, 23);
            this.ManageAddOnsButton.TabIndex = 5;
            this.ManageAddOnsButton.TabStop = false;
            this.ManageAddOnsButton.Text = "Manage Add-Ons";
            this.AddOnsTT.SetToolTip(this.ManageAddOnsButton, "This feature is not yet been properly implemented. Sorry!");
            this.ManageAddOnsButton.UseVisualStyleBackColor = true;
            // 
            // ManageVehiclesButton
            // 
            this.ManageVehiclesButton.Location = new System.Drawing.Point(49, 174);
            this.ManageVehiclesButton.Name = "ManageVehiclesButton";
            this.ManageVehiclesButton.Size = new System.Drawing.Size(129, 23);
            this.ManageVehiclesButton.TabIndex = 4;
            this.ManageVehiclesButton.Text = "Manage Vehicles";
            this.ManageVehiclesButton.UseVisualStyleBackColor = true;
            this.ManageVehiclesButton.Click += new System.EventHandler(this.ManageVehicles_Button);
            // 
            // ManageEmployeesButton
            // 
            this.ManageEmployeesButton.Location = new System.Drawing.Point(49, 145);
            this.ManageEmployeesButton.Name = "ManageEmployeesButton";
            this.ManageEmployeesButton.Size = new System.Drawing.Size(129, 23);
            this.ManageEmployeesButton.TabIndex = 3;
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
            this.ManageOrdersButton.TabIndex = 1;
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
            // AddOnsTT
            // 
            this.AddOnsTT.ToolTipTitle = "Add Ons Tool Tip";
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
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HTV Staff Dashboard";
            this.Load += new System.EventHandler(this.MainMenu_Load);
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
        private System.Windows.Forms.Button ManageVehiclesButton;
        private System.Windows.Forms.Button ManageAddOnsButton;
        private System.Windows.Forms.ToolTip AddOnsTT;
    }
}