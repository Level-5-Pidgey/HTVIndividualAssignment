namespace HTVIndividualAssignment
{
    partial class NewOrder
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
            this.OrderBox = new System.Windows.Forms.GroupBox();
            this.VehicleBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ConfirmOrderButton = new System.Windows.Forms.Button();
            this.CostBox = new System.Windows.Forms.TextBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.AddOnBox = new System.Windows.Forms.GroupBox();
            this.AddOnBox2 = new System.Windows.Forms.ComboBox();
            this.Addon2Label = new System.Windows.Forms.Label();
            this.AddOnBox3 = new System.Windows.Forms.ComboBox();
            this.AddOn3Label = new System.Windows.Forms.Label();
            this.AddOnBox1 = new System.Windows.Forms.ComboBox();
            this.Addon1Label = new System.Windows.Forms.Label();
            this.CustomerBox = new System.Windows.Forms.ComboBox();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.EmployeeTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeLabel = new System.Windows.Forms.Label();
            this.OrderIDTextBox = new System.Windows.Forms.TextBox();
            this.OrderIDLabel = new System.Windows.Forms.Label();
            this.OrderBox.SuspendLayout();
            this.AddOnBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderBox
            // 
            this.OrderBox.Controls.Add(this.VehicleBox);
            this.OrderBox.Controls.Add(this.label1);
            this.OrderBox.Controls.Add(this.ConfirmOrderButton);
            this.OrderBox.Controls.Add(this.CostBox);
            this.OrderBox.Controls.Add(this.CostLabel);
            this.OrderBox.Controls.Add(this.AddOnBox);
            this.OrderBox.Controls.Add(this.CustomerBox);
            this.OrderBox.Controls.Add(this.CustomerLabel);
            this.OrderBox.Controls.Add(this.EmployeeTextBox);
            this.OrderBox.Controls.Add(this.EmployeeLabel);
            this.OrderBox.Controls.Add(this.OrderIDTextBox);
            this.OrderBox.Controls.Add(this.OrderIDLabel);
            this.OrderBox.Location = new System.Drawing.Point(12, 12);
            this.OrderBox.Name = "OrderBox";
            this.OrderBox.Size = new System.Drawing.Size(295, 342);
            this.OrderBox.TabIndex = 0;
            this.OrderBox.TabStop = false;
            this.OrderBox.Text = "Create New Order";
            // 
            // VehicleBox
            // 
            this.VehicleBox.FormattingEnabled = true;
            this.VehicleBox.Location = new System.Drawing.Point(77, 115);
            this.VehicleBox.Name = "VehicleBox";
            this.VehicleBox.Size = new System.Drawing.Size(200, 21);
            this.VehicleBox.TabIndex = 3;
            this.VehicleBox.SelectedIndexChanged += new System.EventHandler(this.VehicleIndex_Changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Vehicle";
            // 
            // ConfirmOrderButton
            // 
            this.ConfirmOrderButton.Location = new System.Drawing.Point(110, 302);
            this.ConfirmOrderButton.Name = "ConfirmOrderButton";
            this.ConfirmOrderButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmOrderButton.TabIndex = 8;
            this.ConfirmOrderButton.Text = "Make Order";
            this.ConfirmOrderButton.UseVisualStyleBackColor = true;
            this.ConfirmOrderButton.Click += new System.EventHandler(this.Push_Order);
            // 
            // CostBox
            // 
            this.CostBox.Enabled = false;
            this.CostBox.Location = new System.Drawing.Point(77, 260);
            this.CostBox.Name = "CostBox";
            this.CostBox.ReadOnly = true;
            this.CostBox.Size = new System.Drawing.Size(200, 20);
            this.CostBox.TabIndex = 7;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(18, 263);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(55, 13);
            this.CostLabel.TabIndex = 7;
            this.CostLabel.Text = "Total Cost";
            // 
            // AddOnBox
            // 
            this.AddOnBox.Controls.Add(this.AddOnBox2);
            this.AddOnBox.Controls.Add(this.Addon2Label);
            this.AddOnBox.Controls.Add(this.AddOnBox3);
            this.AddOnBox.Controls.Add(this.AddOn3Label);
            this.AddOnBox.Controls.Add(this.AddOnBox1);
            this.AddOnBox.Controls.Add(this.Addon1Label);
            this.AddOnBox.Location = new System.Drawing.Point(6, 142);
            this.AddOnBox.Name = "AddOnBox";
            this.AddOnBox.Size = new System.Drawing.Size(283, 103);
            this.AddOnBox.TabIndex = 6;
            this.AddOnBox.TabStop = false;
            this.AddOnBox.Text = "Add-Ons";
            // 
            // AddOnBox2
            // 
            this.AddOnBox2.FormattingEnabled = true;
            this.AddOnBox2.Location = new System.Drawing.Point(71, 46);
            this.AddOnBox2.Name = "AddOnBox2";
            this.AddOnBox2.Size = new System.Drawing.Size(200, 21);
            this.AddOnBox2.TabIndex = 5;
            this.AddOnBox2.SelectedIndexChanged += new System.EventHandler(this.Update_Costs_Event);
            // 
            // Addon2Label
            // 
            this.Addon2Label.AutoSize = true;
            this.Addon2Label.Location = new System.Drawing.Point(13, 49);
            this.Addon2Label.Name = "Addon2Label";
            this.Addon2Label.Size = new System.Drawing.Size(52, 13);
            this.Addon2Label.TabIndex = 11;
            this.Addon2Label.Text = "Add-On 2";
            // 
            // AddOnBox3
            // 
            this.AddOnBox3.FormattingEnabled = true;
            this.AddOnBox3.Location = new System.Drawing.Point(71, 73);
            this.AddOnBox3.Name = "AddOnBox3";
            this.AddOnBox3.Size = new System.Drawing.Size(200, 21);
            this.AddOnBox3.TabIndex = 6;
            this.AddOnBox3.SelectedIndexChanged += new System.EventHandler(this.Update_Costs_Event);
            // 
            // AddOn3Label
            // 
            this.AddOn3Label.AutoSize = true;
            this.AddOn3Label.Location = new System.Drawing.Point(13, 76);
            this.AddOn3Label.Name = "AddOn3Label";
            this.AddOn3Label.Size = new System.Drawing.Size(52, 13);
            this.AddOn3Label.TabIndex = 9;
            this.AddOn3Label.Text = "Add-On 3";
            // 
            // AddOnBox1
            // 
            this.AddOnBox1.FormattingEnabled = true;
            this.AddOnBox1.Location = new System.Drawing.Point(71, 19);
            this.AddOnBox1.Name = "AddOnBox1";
            this.AddOnBox1.Size = new System.Drawing.Size(200, 21);
            this.AddOnBox1.TabIndex = 4;
            this.AddOnBox1.SelectedIndexChanged += new System.EventHandler(this.Update_Costs_Event);
            // 
            // Addon1Label
            // 
            this.Addon1Label.AutoSize = true;
            this.Addon1Label.Location = new System.Drawing.Point(13, 22);
            this.Addon1Label.Name = "Addon1Label";
            this.Addon1Label.Size = new System.Drawing.Size(52, 13);
            this.Addon1Label.TabIndex = 7;
            this.Addon1Label.Text = "Add-On 1";
            // 
            // CustomerBox
            // 
            this.CustomerBox.FormattingEnabled = true;
            this.CustomerBox.Location = new System.Drawing.Point(77, 88);
            this.CustomerBox.Name = "CustomerBox";
            this.CustomerBox.Size = new System.Drawing.Size(200, 21);
            this.CustomerBox.TabIndex = 2;
            this.CustomerBox.SelectedIndexChanged += new System.EventHandler(this.CustomerBox_Changed);
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Location = new System.Drawing.Point(20, 91);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(51, 13);
            this.CustomerLabel.TabIndex = 4;
            this.CustomerLabel.Text = "Customer";
            // 
            // EmployeeTextBox
            // 
            this.EmployeeTextBox.Enabled = false;
            this.EmployeeTextBox.Location = new System.Drawing.Point(77, 56);
            this.EmployeeTextBox.Name = "EmployeeTextBox";
            this.EmployeeTextBox.ReadOnly = true;
            this.EmployeeTextBox.Size = new System.Drawing.Size(200, 20);
            this.EmployeeTextBox.TabIndex = 1;
            // 
            // EmployeeLabel
            // 
            this.EmployeeLabel.AutoSize = true;
            this.EmployeeLabel.Location = new System.Drawing.Point(18, 59);
            this.EmployeeLabel.Name = "EmployeeLabel";
            this.EmployeeLabel.Size = new System.Drawing.Size(53, 13);
            this.EmployeeLabel.TabIndex = 2;
            this.EmployeeLabel.Text = "Employee";
            // 
            // OrderIDTextBox
            // 
            this.OrderIDTextBox.Enabled = false;
            this.OrderIDTextBox.Location = new System.Drawing.Point(77, 25);
            this.OrderIDTextBox.Name = "OrderIDTextBox";
            this.OrderIDTextBox.ReadOnly = true;
            this.OrderIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.OrderIDTextBox.TabIndex = 0;
            // 
            // OrderIDLabel
            // 
            this.OrderIDLabel.AutoSize = true;
            this.OrderIDLabel.Location = new System.Drawing.Point(24, 28);
            this.OrderIDLabel.Name = "OrderIDLabel";
            this.OrderIDLabel.Size = new System.Drawing.Size(47, 13);
            this.OrderIDLabel.TabIndex = 0;
            this.OrderIDLabel.Text = "Order ID";
            // 
            // NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 361);
            this.Controls.Add(this.OrderBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Order";
            this.Load += new System.EventHandler(this.NewOrderScreen_Load);
            this.OrderBox.ResumeLayout(false);
            this.OrderBox.PerformLayout();
            this.AddOnBox.ResumeLayout(false);
            this.AddOnBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox OrderBox;
        private System.Windows.Forms.Button ConfirmOrderButton;
        private System.Windows.Forms.TextBox CostBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.GroupBox AddOnBox;
        private System.Windows.Forms.ComboBox AddOnBox2;
        private System.Windows.Forms.Label Addon2Label;
        private System.Windows.Forms.ComboBox AddOnBox3;
        private System.Windows.Forms.Label AddOn3Label;
        private System.Windows.Forms.ComboBox AddOnBox1;
        private System.Windows.Forms.Label Addon1Label;
        private System.Windows.Forms.ComboBox CustomerBox;
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.TextBox EmployeeTextBox;
        private System.Windows.Forms.Label EmployeeLabel;
        private System.Windows.Forms.TextBox OrderIDTextBox;
        private System.Windows.Forms.Label OrderIDLabel;
        private System.Windows.Forms.ComboBox VehicleBox;
        private System.Windows.Forms.Label label1;
    }
}