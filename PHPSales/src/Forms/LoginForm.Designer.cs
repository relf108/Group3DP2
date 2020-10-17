namespace PHPSales.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.btnUserBypass = new System.Windows.Forms.Button();
            this.btnAdminBypass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxUser = new System.Windows.Forms.PictureBox();
            this.lblEmptyUsername = new System.Windows.Forms.Label();
            this.lblEmptyPassword = new System.Windows.Forms.Label();
            this.lblWrongLogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(81)))), ((int)(((byte)(107)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnLogin.Location = new System.Drawing.Point(275, 350);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(15);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(215, 41);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.MouseEnter += new System.EventHandler(this.btnLogin_MouseEnter);
            this.btnLogin.MouseLeave += new System.EventHandler(this.btnLogin_MouseLeave);
            // 
            // tbxUsername
            // 
            this.tbxUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxUsername.Location = new System.Drawing.Point(275, 242);
            this.tbxUsername.Margin = new System.Windows.Forms.Padding(10);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.PlaceholderText = "Username";
            this.tbxUsername.Size = new System.Drawing.Size(215, 29);
            this.tbxUsername.TabIndex = 5;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxPassword.Location = new System.Drawing.Point(275, 291);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(10);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PlaceholderText = "Password";
            this.tbxPassword.Size = new System.Drawing.Size(215, 29);
            this.tbxPassword.TabIndex = 7;
            // 
            // btnUserBypass
            // 
            this.btnUserBypass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUserBypass.Location = new System.Drawing.Point(12, 407);
            this.btnUserBypass.Name = "btnUserBypass";
            this.btnUserBypass.Size = new System.Drawing.Size(57, 42);
            this.btnUserBypass.TabIndex = 8;
            this.btnUserBypass.Text = "Normal User";
            this.btnUserBypass.UseVisualStyleBackColor = true;
            this.btnUserBypass.Click += new System.EventHandler(this.btnUserBypass_Click);
            // 
            // btnAdminBypass
            // 
            this.btnAdminBypass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdminBypass.Location = new System.Drawing.Point(75, 407);
            this.btnAdminBypass.Name = "btnAdminBypass";
            this.btnAdminBypass.Size = new System.Drawing.Size(51, 42);
            this.btnAdminBypass.TabIndex = 8;
            this.btnAdminBypass.Text = "Admin";
            this.btnAdminBypass.UseVisualStyleBackColor = true;
            this.btnAdminBypass.Click += new System.EventHandler(this.btnAdminBypass_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "For Development...\r\nLogin as:";
            // 
            // pbxUser
            // 
            this.pbxUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxUser.Image = ((System.Drawing.Image)(resources.GetObject("pbxUser.Image")));
            this.pbxUser.Location = new System.Drawing.Point(275, 59);
            this.pbxUser.Margin = new System.Windows.Forms.Padding(20);
            this.pbxUser.Name = "pbxUser";
            this.pbxUser.Size = new System.Drawing.Size(215, 153);
            this.pbxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxUser.TabIndex = 10;
            this.pbxUser.TabStop = false;
            // 
            // lblEmptyUsername
            // 
            this.lblEmptyUsername.AutoSize = true;
            this.lblEmptyUsername.ForeColor = System.Drawing.Color.Red;
            this.lblEmptyUsername.Location = new System.Drawing.Point(275, 271);
            this.lblEmptyUsername.Margin = new System.Windows.Forms.Padding(0);
            this.lblEmptyUsername.Name = "lblEmptyUsername";
            this.lblEmptyUsername.Size = new System.Drawing.Size(153, 15);
            this.lblEmptyUsername.TabIndex = 11;
            this.lblEmptyUsername.Text = "Username cannot be empty";
            this.lblEmptyUsername.Visible = false;
            // 
            // lblEmptyPassword
            // 
            this.lblEmptyPassword.AutoSize = true;
            this.lblEmptyPassword.ForeColor = System.Drawing.Color.Red;
            this.lblEmptyPassword.Location = new System.Drawing.Point(275, 320);
            this.lblEmptyPassword.Margin = new System.Windows.Forms.Padding(0);
            this.lblEmptyPassword.Name = "lblEmptyPassword";
            this.lblEmptyPassword.Size = new System.Drawing.Size(150, 15);
            this.lblEmptyPassword.TabIndex = 11;
            this.lblEmptyPassword.Text = "Password cannot be empty";
            this.lblEmptyPassword.Visible = false;
            // 
            // lblWrongLogin
            // 
            this.lblWrongLogin.AutoSize = true;
            this.lblWrongLogin.ForeColor = System.Drawing.Color.Red;
            this.lblWrongLogin.Location = new System.Drawing.Point(296, 326);
            this.lblWrongLogin.Margin = new System.Windows.Forms.Padding(0);
            this.lblWrongLogin.Name = "lblWrongLogin";
            this.lblWrongLogin.Size = new System.Drawing.Size(176, 15);
            this.lblWrongLogin.TabIndex = 11;
            this.lblWrongLogin.Text = "Incorrect username or password";
            this.lblWrongLogin.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(764, 461);
            this.Controls.Add(this.lblWrongLogin);
            this.Controls.Add(this.lblEmptyPassword);
            this.Controls.Add(this.lblEmptyUsername);
            this.Controls.Add(this.pbxUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdminBypass);
            this.Controls.Add(this.btnUserBypass);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHPSales - Login";
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Button btnUserBypass;
        private System.Windows.Forms.Button btnAdminBypass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxUser;
        private System.Windows.Forms.Label lblEmptyUsername;
        private System.Windows.Forms.Label lblEmptyPassword;
        private System.Windows.Forms.Label lblWrongLogin;
    }
}