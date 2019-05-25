namespace HTVIndividualAssignment
{
    partial class Login
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
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.LoginBox = new System.Windows.Forms.GroupBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.LoginName = new System.Windows.Forms.TextBox();
            this.LoginBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(16, 72);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(16, 46);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(67, 13);
            this.LoginLabel.TabIndex = 2;
            this.LoginLabel.Text = "Employee ID";
            // 
            // LoginBox
            // 
            this.LoginBox.Controls.Add(this.LoginButton);
            this.LoginBox.Controls.Add(this.ExitButton);
            this.LoginBox.Controls.Add(this.PasswordLabel);
            this.LoginBox.Controls.Add(this.LoginLabel);
            this.LoginBox.Controls.Add(this.PasswordBox);
            this.LoginBox.Controls.Add(this.LoginName);
            this.LoginBox.Location = new System.Drawing.Point(12, 12);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(233, 151);
            this.LoginBox.TabIndex = 0;
            this.LoginBox.TabStop = false;
            this.LoginBox.Text = "Login";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(33, 107);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.Login_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(122, 107);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // PasswordBox
            // 
            this.PasswordBox.AcceptsTab = true;
            this.PasswordBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.PasswordBox.Location = new System.Drawing.Point(89, 69);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(120, 20);
            this.PasswordBox.TabIndex = 1;
            this.PasswordBox.UseSystemPasswordChar = true;
            this.PasswordBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericOnly_KeyPress);
            // 
            // LoginName
            // 
            this.LoginName.AcceptsTab = true;
            this.LoginName.Cursor = System.Windows.Forms.Cursors.Default;
            this.LoginName.Location = new System.Drawing.Point(89, 43);
            this.LoginName.Name = "LoginName";
            this.LoginName.Size = new System.Drawing.Size(120, 20);
            this.LoginName.TabIndex = 0;
            this.LoginName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericOnly_KeyPress);
            // 
            // Login
            // 
            this.AcceptButton = this.LoginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 175);
            this.Controls.Add(this.LoginBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login to HTV System";
            this.TopMost = true;
            this.LoginBox.ResumeLayout(false);
            this.LoginBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox LoginBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox LoginName;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label LoginLabel;
    }
}

