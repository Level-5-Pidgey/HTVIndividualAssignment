namespace HTVIndividualAssignment
{
    partial class ManageVehicles
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
            this.VehicleIDBox = new System.Windows.Forms.TextBox();
            this.ModelText = new System.Windows.Forms.TextBox();
            this.SerialNumberText = new System.Windows.Forms.TextBox();
            this.YearLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.SerialNumberLabel = new System.Windows.Forms.Label();
            this.VehicleIDLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TableIndexBox = new System.Windows.Forms.NumericUpDown();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.YearText = new System.Windows.Forms.TextBox();
            this.BaseCostLabel = new System.Windows.Forms.Label();
            this.BaseCostText = new System.Windows.Forms.TextBox();
            this.AvailableBox = new System.Windows.Forms.CheckBox();
            this.hTVDatabaseDataSet_Inventory = new HTVIndividualAssignment.Database.HTVDatabaseDataSet_Inventory();
            this.hTVDatabaseDataSetInventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryTableAdapter = new HTVIndividualAssignment.Database.HTVDatabaseDataSet_InventoryTableAdapters.InventoryTableAdapter();
            this.vehicleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.ManufacturerText = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableIndexBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hTVDatabaseDataSet_Inventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hTVDatabaseDataSetInventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AvailableBox);
            this.groupBox1.Controls.Add(this.VehicleIDBox);
            this.groupBox1.Controls.Add(this.BaseCostText);
            this.groupBox1.Controls.Add(this.YearText);
            this.groupBox1.Controls.Add(this.ManufacturerText);
            this.groupBox1.Controls.Add(this.NameText);
            this.groupBox1.Controls.Add(this.ModelText);
            this.groupBox1.Controls.Add(this.BaseCostLabel);
            this.groupBox1.Controls.Add(this.SerialNumberText);
            this.groupBox1.Controls.Add(this.ManufacturerLabel);
            this.groupBox1.Controls.Add(this.NameLabel);
            this.groupBox1.Controls.Add(this.YearLabel);
            this.groupBox1.Controls.Add(this.ModelLabel);
            this.groupBox1.Controls.Add(this.SerialNumberLabel);
            this.groupBox1.Controls.Add(this.VehicleIDLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TableIndexBox);
            this.groupBox1.Controls.Add(this.DeleteButton);
            this.groupBox1.Controls.Add(this.ModifyButton);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Table Editing";
            // 
            // VehicleIDBox
            // 
            this.VehicleIDBox.Enabled = false;
            this.VehicleIDBox.Location = new System.Drawing.Point(100, 66);
            this.VehicleIDBox.Name = "VehicleIDBox";
            this.VehicleIDBox.ReadOnly = true;
            this.VehicleIDBox.Size = new System.Drawing.Size(120, 20);
            this.VehicleIDBox.TabIndex = 1;
            this.VehicleIDBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericOnly_KeyPress);
            // 
            // ModelText
            // 
            this.ModelText.Location = new System.Drawing.Point(100, 144);
            this.ModelText.Name = "ModelText";
            this.ModelText.Size = new System.Drawing.Size(120, 20);
            this.ModelText.TabIndex = 4;
            // 
            // SerialNumberText
            // 
            this.SerialNumberText.Location = new System.Drawing.Point(100, 92);
            this.SerialNumberText.Name = "SerialNumberText";
            this.SerialNumberText.Size = new System.Drawing.Size(120, 20);
            this.SerialNumberText.TabIndex = 2;
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(65, 200);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(29, 13);
            this.YearLabel.TabIndex = 7;
            this.YearLabel.Text = "Year";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(58, 148);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(36, 13);
            this.ModelLabel.TabIndex = 6;
            this.ModelLabel.Text = "Model";
            // 
            // SerialNumberLabel
            // 
            this.SerialNumberLabel.AutoSize = true;
            this.SerialNumberLabel.Location = new System.Drawing.Point(21, 96);
            this.SerialNumberLabel.Name = "SerialNumberLabel";
            this.SerialNumberLabel.Size = new System.Drawing.Size(73, 13);
            this.SerialNumberLabel.TabIndex = 5;
            this.SerialNumberLabel.Text = "Serial Number";
            // 
            // VehicleIDLabel
            // 
            this.VehicleIDLabel.AutoSize = true;
            this.VehicleIDLabel.Location = new System.Drawing.Point(38, 70);
            this.VehicleIDLabel.Name = "VehicleIDLabel";
            this.VehicleIDLabel.Size = new System.Drawing.Size(56, 13);
            this.VehicleIDLabel.TabIndex = 4;
            this.VehicleIDLabel.Text = "Vehicle ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Table Index";
            // 
            // TableIndexBox
            // 
            this.TableIndexBox.Location = new System.Drawing.Point(100, 25);
            this.TableIndexBox.Name = "TableIndexBox";
            this.TableIndexBox.Size = new System.Drawing.Size(120, 20);
            this.TableIndexBox.TabIndex = 0;
            this.TableIndexBox.ValueChanged += new System.EventHandler(this.Update_Fields_EventHandler);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(134, 383);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.Delete_Button);
            // 
            // ModifyButton
            // 
            this.ModifyButton.Location = new System.Drawing.Point(53, 383);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(75, 23);
            this.ModifyButton.TabIndex = 6;
            this.ModifyButton.Text = "Modify";
            this.ModifyButton.UseVisualStyleBackColor = true;
            this.ModifyButton.Click += new System.EventHandler(this.Modify_Button);
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
            // YearText
            // 
            this.YearText.Location = new System.Drawing.Point(100, 196);
            this.YearText.Name = "YearText";
            this.YearText.Size = new System.Drawing.Size(120, 20);
            this.YearText.TabIndex = 6;
            this.YearText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericOnly_KeyPress);
            // 
            // BaseCostLabel
            // 
            this.BaseCostLabel.AutoSize = true;
            this.BaseCostLabel.Location = new System.Drawing.Point(27, 226);
            this.BaseCostLabel.Name = "BaseCostLabel";
            this.BaseCostLabel.Size = new System.Drawing.Size(67, 13);
            this.BaseCostLabel.TabIndex = 7;
            this.BaseCostLabel.Text = "Base Cost $:";
            // 
            // BaseCostText
            // 
            this.BaseCostText.Location = new System.Drawing.Point(100, 222);
            this.BaseCostText.Name = "BaseCostText";
            this.BaseCostText.Size = new System.Drawing.Size(120, 20);
            this.BaseCostText.TabIndex = 7;
            this.BaseCostText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericOnly_KeyPress);
            // 
            // AvailableBox
            // 
            this.AvailableBox.AutoSize = true;
            this.AvailableBox.Location = new System.Drawing.Point(86, 260);
            this.AvailableBox.Name = "AvailableBox";
            this.AvailableBox.Size = new System.Drawing.Size(69, 17);
            this.AvailableBox.TabIndex = 8;
            this.AvailableBox.Text = "Available";
            this.AvailableBox.UseVisualStyleBackColor = true;
            // 
            // hTVDatabaseDataSet_Inventory
            // 
            this.hTVDatabaseDataSet_Inventory.DataSetName = "HTVDatabaseDataSet_Inventory";
            this.hTVDatabaseDataSet_Inventory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hTVDatabaseDataSetInventoryBindingSource
            // 
            this.hTVDatabaseDataSetInventoryBindingSource.DataSource = this.hTVDatabaseDataSet_Inventory;
            this.hTVDatabaseDataSetInventoryBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehicleIDDataGridViewTextBoxColumn,
            this.serialNumberDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.baseCostDataGridViewTextBoxColumn,
            this.availableDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.inventoryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(493, 399);
            this.dataGridView1.TabIndex = 0;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.hTVDatabaseDataSetInventoryBindingSource;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // vehicleIDDataGridViewTextBoxColumn
            // 
            this.vehicleIDDataGridViewTextBoxColumn.DataPropertyName = "VehicleID";
            this.vehicleIDDataGridViewTextBoxColumn.HeaderText = "VehicleID";
            this.vehicleIDDataGridViewTextBoxColumn.Name = "vehicleIDDataGridViewTextBoxColumn";
            // 
            // serialNumberDataGridViewTextBoxColumn
            // 
            this.serialNumberDataGridViewTextBoxColumn.DataPropertyName = "SerialNumber";
            this.serialNumberDataGridViewTextBoxColumn.HeaderText = "SerialNumber";
            this.serialNumberDataGridViewTextBoxColumn.Name = "serialNumberDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            // 
            // baseCostDataGridViewTextBoxColumn
            // 
            this.baseCostDataGridViewTextBoxColumn.DataPropertyName = "BaseCost";
            this.baseCostDataGridViewTextBoxColumn.HeaderText = "BaseCost";
            this.baseCostDataGridViewTextBoxColumn.Name = "baseCostDataGridViewTextBoxColumn";
            // 
            // availableDataGridViewCheckBoxColumn
            // 
            this.availableDataGridViewCheckBoxColumn.DataPropertyName = "Available";
            this.availableDataGridViewCheckBoxColumn.HeaderText = "Available";
            this.availableDataGridViewCheckBoxColumn.Name = "availableDataGridViewCheckBoxColumn";
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Location = new System.Drawing.Point(24, 174);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(70, 13);
            this.ManufacturerLabel.TabIndex = 6;
            this.ManufacturerLabel.Text = "Manufacturer";
            // 
            // ManufacturerText
            // 
            this.ManufacturerText.Location = new System.Drawing.Point(100, 170);
            this.ManufacturerText.Name = "ManufacturerText";
            this.ManufacturerText.Size = new System.Drawing.Size(120, 20);
            this.ManufacturerText.TabIndex = 5;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(59, 122);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 6;
            this.NameLabel.Text = "Name";
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(100, 118);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(120, 20);
            this.NameText.TabIndex = 3;
            // 
            // ManageVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManageVehicles";
            this.Text = "Vehicle Management";
            this.Load += new System.EventHandler(this.ManageEmployeeScreen_load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableIndexBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hTVDatabaseDataSet_Inventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hTVDatabaseDataSetInventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label VehicleIDLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown TableIndexBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ModifyButton;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label SerialNumberLabel;
        private System.Windows.Forms.TextBox ModelText;
        private System.Windows.Forms.TextBox SerialNumberText;
        private System.Windows.Forms.TextBox VehicleIDBox;
        private System.Windows.Forms.TextBox YearText;
        private System.Windows.Forms.CheckBox AvailableBox;
        private System.Windows.Forms.TextBox BaseCostText;
        private System.Windows.Forms.Label BaseCostLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database.HTVDatabaseDataSet_Inventory hTVDatabaseDataSet_Inventory;
        private System.Windows.Forms.BindingSource hTVDatabaseDataSetInventoryBindingSource;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private Database.HTVDatabaseDataSet_InventoryTableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn availableDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TextBox ManufacturerText;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label NameLabel;
    }
}