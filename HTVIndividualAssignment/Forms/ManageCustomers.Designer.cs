namespace HTVIndividualAssignment
{
    partial class ManageCustomers
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
            this.CustomerIDBox = new System.Windows.Forms.TextBox();
            this.AddressText = new System.Windows.Forms.TextBox();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.FirstNameText = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.EmployeeIDLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TableIndexBox = new System.Windows.Forms.NumericUpDown();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hTVDatabaseDataSetCustomerInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hTVDatabaseDataSet_CustomerInfo = new HTVIndividualAssignment.Database.HTVDatabaseDataSet_CustomerInfo();
            this.customerInfoTableAdapter = new HTVIndividualAssignment.Database.HTVDatabaseDataSet_CustomerInfoTableAdapters.CustomerInfoTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableIndexBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hTVDatabaseDataSetCustomerInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hTVDatabaseDataSet_CustomerInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CustomerIDBox);
            this.groupBox1.Controls.Add(this.AddressText);
            this.groupBox1.Controls.Add(this.LastNameText);
            this.groupBox1.Controls.Add(this.FirstNameText);
            this.groupBox1.Controls.Add(this.AddressLabel);
            this.groupBox1.Controls.Add(this.LastNameLabel);
            this.groupBox1.Controls.Add(this.FirstNameLabel);
            this.groupBox1.Controls.Add(this.EmployeeIDLabel);
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
            // CustomerIDBox
            // 
            this.CustomerIDBox.Enabled = false;
            this.CustomerIDBox.Location = new System.Drawing.Point(100, 66);
            this.CustomerIDBox.Name = "CustomerIDBox";
            this.CustomerIDBox.ReadOnly = true;
            this.CustomerIDBox.Size = new System.Drawing.Size(120, 20);
            this.CustomerIDBox.TabIndex = 1;
            this.CustomerIDBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericOnly_KeyPress);
            // 
            // AddressText
            // 
            this.AddressText.Location = new System.Drawing.Point(100, 144);
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(120, 20);
            this.AddressText.TabIndex = 5;
            // 
            // LastNameText
            // 
            this.LastNameText.Location = new System.Drawing.Point(100, 118);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(120, 20);
            this.LastNameText.TabIndex = 3;
            // 
            // FirstNameText
            // 
            this.FirstNameText.Location = new System.Drawing.Point(100, 92);
            this.FirstNameText.Name = "FirstNameText";
            this.FirstNameText.Size = new System.Drawing.Size(120, 20);
            this.FirstNameText.TabIndex = 2;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(47, 147);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(45, 13);
            this.AddressLabel.TabIndex = 8;
            this.AddressLabel.Text = "Address";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(36, 121);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.LastNameLabel.TabIndex = 6;
            this.LastNameLabel.Text = "Last Name";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(37, 95);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FirstNameLabel.TabIndex = 5;
            this.FirstNameLabel.Text = "First Name";
            // 
            // EmployeeIDLabel
            // 
            this.EmployeeIDLabel.AutoSize = true;
            this.EmployeeIDLabel.Location = new System.Drawing.Point(27, 69);
            this.EmployeeIDLabel.Name = "EmployeeIDLabel";
            this.EmployeeIDLabel.Size = new System.Drawing.Size(65, 13);
            this.EmployeeIDLabel.TabIndex = 4;
            this.EmployeeIDLabel.Text = "Customer ID";
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerInfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(494, 399);
            this.dataGridView1.TabIndex = 0;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // customerInfoBindingSource
            // 
            this.customerInfoBindingSource.DataMember = "CustomerInfo";
            this.customerInfoBindingSource.DataSource = this.hTVDatabaseDataSetCustomerInfoBindingSource;
            // 
            // hTVDatabaseDataSetCustomerInfoBindingSource
            // 
            this.hTVDatabaseDataSetCustomerInfoBindingSource.DataSource = this.hTVDatabaseDataSet_CustomerInfo;
            this.hTVDatabaseDataSetCustomerInfoBindingSource.Position = 0;
            // 
            // hTVDatabaseDataSet_CustomerInfo
            // 
            this.hTVDatabaseDataSet_CustomerInfo.DataSetName = "HTVDatabaseDataSet_CustomerInfo";
            this.hTVDatabaseDataSet_CustomerInfo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerInfoTableAdapter
            // 
            this.customerInfoTableAdapter.ClearBeforeFill = true;
            // 
            // ManageCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManageCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Management";
            this.Load += new System.EventHandler(this.ManageEmployeeScreen_load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableIndexBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hTVDatabaseDataSetCustomerInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hTVDatabaseDataSet_CustomerInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label EmployeeIDLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown TableIndexBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ModifyButton;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox AddressText;
        private System.Windows.Forms.TextBox LastNameText;
        private System.Windows.Forms.TextBox FirstNameText;
        private System.Windows.Forms.TextBox CustomerIDBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database.HTVDatabaseDataSet_CustomerInfo hTVDatabaseDataSet_CustomerInfo;
        private System.Windows.Forms.BindingSource hTVDatabaseDataSetCustomerInfoBindingSource;
        private System.Windows.Forms.BindingSource customerInfoBindingSource;
        private Database.HTVDatabaseDataSet_CustomerInfoTableAdapters.CustomerInfoTableAdapter customerInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
    }
}