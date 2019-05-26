namespace HTVIndividualAssignment
{
    partial class ManageOrders
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PaidBox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddOnBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddOnBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddOnBox1 = new System.Windows.Forms.TextBox();
            this.CustomerIDBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TimeBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CostBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.VehicleIDBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.EmployeeIDBox = new System.Windows.Forms.TextBox();
            this.EmployeeIDLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TableIndexBox = new System.Windows.Forms.NumericUpDown();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addOn1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addOn2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addOn3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ordertimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hTVDatabaseDataSetOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hTVDatabaseDataSet_Orders = new HTVIndividualAssignment.Database.HTVDatabaseDataSet_Orders();
            this.orderTableAdapter = new HTVIndividualAssignment.Database.HTVDatabaseDataSet_OrdersTableAdapters.OrderTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableIndexBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hTVDatabaseDataSetOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hTVDatabaseDataSet_Orders)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PaidBox);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.CustomerIDBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TimeBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.CostBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.VehicleIDBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.EmployeeIDBox);
            this.groupBox1.Controls.Add(this.EmployeeIDLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TableIndexBox);
            this.groupBox1.Controls.Add(this.DeleteButton);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Table Editing";
            // 
            // PaidBox
            // 
            this.PaidBox.AutoSize = true;
            this.PaidBox.Location = new System.Drawing.Point(98, 341);
            this.PaidBox.Name = "PaidBox";
            this.PaidBox.Size = new System.Drawing.Size(53, 17);
            this.PaidBox.TabIndex = 9;
            this.PaidBox.Text = "Paid?";
            this.PaidBox.UseVisualStyleBackColor = true;
            this.PaidBox.Click += new System.EventHandler(this.SetPaid_Check);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.AddOnBox3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.AddOnBox2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.AddOnBox1);
            this.groupBox3.Location = new System.Drawing.Point(21, 145);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(222, 120);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add-Ons";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Add-On 3";
            // 
            // AddOnBox3
            // 
            this.AddOnBox3.Enabled = false;
            this.AddOnBox3.Location = new System.Drawing.Point(80, 82);
            this.AddOnBox3.Name = "AddOnBox3";
            this.AddOnBox3.ReadOnly = true;
            this.AddOnBox3.Size = new System.Drawing.Size(131, 20);
            this.AddOnBox3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Add-On 2";
            // 
            // AddOnBox2
            // 
            this.AddOnBox2.Enabled = false;
            this.AddOnBox2.Location = new System.Drawing.Point(80, 53);
            this.AddOnBox2.Name = "AddOnBox2";
            this.AddOnBox2.ReadOnly = true;
            this.AddOnBox2.Size = new System.Drawing.Size(131, 20);
            this.AddOnBox2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Add-On 1";
            // 
            // AddOnBox1
            // 
            this.AddOnBox1.Enabled = false;
            this.AddOnBox1.Location = new System.Drawing.Point(80, 23);
            this.AddOnBox1.Name = "AddOnBox1";
            this.AddOnBox1.ReadOnly = true;
            this.AddOnBox1.Size = new System.Drawing.Size(131, 20);
            this.AddOnBox1.TabIndex = 1;
            // 
            // CustomerIDBox
            // 
            this.CustomerIDBox.Enabled = false;
            this.CustomerIDBox.Location = new System.Drawing.Point(100, 67);
            this.CustomerIDBox.Name = "CustomerIDBox";
            this.CustomerIDBox.ReadOnly = true;
            this.CustomerIDBox.Size = new System.Drawing.Size(131, 20);
            this.CustomerIDBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Customer ID";
            // 
            // TimeBox
            // 
            this.TimeBox.Enabled = false;
            this.TimeBox.Location = new System.Drawing.Point(100, 305);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.ReadOnly = true;
            this.TimeBox.Size = new System.Drawing.Size(131, 20);
            this.TimeBox.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Timestamp";
            // 
            // CostBox
            // 
            this.CostBox.Enabled = false;
            this.CostBox.Location = new System.Drawing.Point(100, 279);
            this.CostBox.Name = "CostBox";
            this.CostBox.ReadOnly = true;
            this.CostBox.Size = new System.Drawing.Size(131, 20);
            this.CostBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total Cost";
            // 
            // VehicleIDBox
            // 
            this.VehicleIDBox.Enabled = false;
            this.VehicleIDBox.Location = new System.Drawing.Point(100, 119);
            this.VehicleIDBox.Name = "VehicleIDBox";
            this.VehicleIDBox.ReadOnly = true;
            this.VehicleIDBox.Size = new System.Drawing.Size(131, 20);
            this.VehicleIDBox.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Vehicle ID";
            // 
            // EmployeeIDBox
            // 
            this.EmployeeIDBox.Enabled = false;
            this.EmployeeIDBox.Location = new System.Drawing.Point(100, 93);
            this.EmployeeIDBox.Name = "EmployeeIDBox";
            this.EmployeeIDBox.ReadOnly = true;
            this.EmployeeIDBox.Size = new System.Drawing.Size(131, 20);
            this.EmployeeIDBox.TabIndex = 1;
            // 
            // EmployeeIDLabel
            // 
            this.EmployeeIDLabel.AutoSize = true;
            this.EmployeeIDLabel.Location = new System.Drawing.Point(27, 97);
            this.EmployeeIDLabel.Name = "EmployeeIDLabel";
            this.EmployeeIDLabel.Size = new System.Drawing.Size(67, 13);
            this.EmployeeIDLabel.TabIndex = 4;
            this.EmployeeIDLabel.Text = "Employee ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Table Index";
            // 
            // TableIndexBox
            // 
            this.TableIndexBox.Location = new System.Drawing.Point(100, 25);
            this.TableIndexBox.Name = "TableIndexBox";
            this.TableIndexBox.Size = new System.Drawing.Size(131, 20);
            this.TableIndexBox.TabIndex = 0;
            this.TableIndexBox.ValueChanged += new System.EventHandler(this.Update_Fields_EventHandler);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(86, 380);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.Delete_Button);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(282, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 425);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TableData";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.employeeIDDataGridViewTextBoxColumn,
            this.vehicleIDDataGridViewTextBoxColumn,
            this.addOn1DataGridViewTextBoxColumn,
            this.addOn2DataGridViewTextBoxColumn,
            this.addOn3DataGridViewTextBoxColumn,
            this.totalCostDataGridViewTextBoxColumn,
            this.paidDataGridViewCheckBoxColumn,
            this.ordertimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(493, 399);
            this.dataGridView1.TabIndex = 0;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vehicleIDDataGridViewTextBoxColumn
            // 
            this.vehicleIDDataGridViewTextBoxColumn.DataPropertyName = "VehicleID";
            this.vehicleIDDataGridViewTextBoxColumn.HeaderText = "VehicleID";
            this.vehicleIDDataGridViewTextBoxColumn.Name = "vehicleIDDataGridViewTextBoxColumn";
            this.vehicleIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addOn1DataGridViewTextBoxColumn
            // 
            this.addOn1DataGridViewTextBoxColumn.DataPropertyName = "AddOn1";
            this.addOn1DataGridViewTextBoxColumn.HeaderText = "AddOn1";
            this.addOn1DataGridViewTextBoxColumn.Name = "addOn1DataGridViewTextBoxColumn";
            this.addOn1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addOn2DataGridViewTextBoxColumn
            // 
            this.addOn2DataGridViewTextBoxColumn.DataPropertyName = "AddOn2";
            this.addOn2DataGridViewTextBoxColumn.HeaderText = "AddOn2";
            this.addOn2DataGridViewTextBoxColumn.Name = "addOn2DataGridViewTextBoxColumn";
            this.addOn2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addOn3DataGridViewTextBoxColumn
            // 
            this.addOn3DataGridViewTextBoxColumn.DataPropertyName = "AddOn3";
            this.addOn3DataGridViewTextBoxColumn.HeaderText = "AddOn3";
            this.addOn3DataGridViewTextBoxColumn.Name = "addOn3DataGridViewTextBoxColumn";
            this.addOn3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalCostDataGridViewTextBoxColumn
            // 
            this.totalCostDataGridViewTextBoxColumn.DataPropertyName = "TotalCost";
            this.totalCostDataGridViewTextBoxColumn.HeaderText = "TotalCost";
            this.totalCostDataGridViewTextBoxColumn.Name = "totalCostDataGridViewTextBoxColumn";
            this.totalCostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paidDataGridViewCheckBoxColumn
            // 
            this.paidDataGridViewCheckBoxColumn.DataPropertyName = "Paid";
            this.paidDataGridViewCheckBoxColumn.HeaderText = "Paid";
            this.paidDataGridViewCheckBoxColumn.Name = "paidDataGridViewCheckBoxColumn";
            this.paidDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // ordertimeDataGridViewTextBoxColumn
            // 
            this.ordertimeDataGridViewTextBoxColumn.DataPropertyName = "Ordertime";
            this.ordertimeDataGridViewTextBoxColumn.HeaderText = "Ordertime";
            this.ordertimeDataGridViewTextBoxColumn.Name = "ordertimeDataGridViewTextBoxColumn";
            this.ordertimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.hTVDatabaseDataSetOrdersBindingSource;
            // 
            // hTVDatabaseDataSetOrdersBindingSource
            // 
            this.hTVDatabaseDataSetOrdersBindingSource.DataSource = this.hTVDatabaseDataSet_Orders;
            this.hTVDatabaseDataSetOrdersBindingSource.Position = 0;
            // 
            // hTVDatabaseDataSet_Orders
            // 
            this.hTVDatabaseDataSet_Orders.DataSetName = "HTVDatabaseDataSet_Orders";
            this.hTVDatabaseDataSet_Orders.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // ManageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManageOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Management";
            this.Load += new System.EventHandler(this.ManageOrders_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableIndexBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hTVDatabaseDataSetOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hTVDatabaseDataSet_Orders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label EmployeeIDLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown TableIndexBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox EmployeeIDBox;
        private System.Windows.Forms.TextBox AddOnBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CustomerIDBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource hTVDatabaseDataSetOrdersBindingSource;
        private Database.HTVDatabaseDataSet_Orders hTVDatabaseDataSet_Orders;
        private System.Windows.Forms.CheckBox PaidBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AddOnBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AddOnBox2;
        private System.Windows.Forms.TextBox CostBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TimeBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox VehicleIDBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private Database.HTVDatabaseDataSet_OrdersTableAdapters.OrderTableAdapter orderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addOn1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addOn2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addOn3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn paidDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordertimeDataGridViewTextBoxColumn;
    }
}