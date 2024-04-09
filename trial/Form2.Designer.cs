namespace trial
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Location = new System.Drawing.Point(447, 188);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(367, 19);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsername_KeyPress);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Location = new System.Drawing.Point(447, 231);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(367, 19);
            this.txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Ink Free", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(447, 276);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(169, 40);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.AutoSize = true;
            this.btnCreate.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreate.Font = new System.Drawing.Font("Ink Free", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(645, 276);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(169, 40);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Raleway SemiBold", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "USERNAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Raleway SemiBold", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(328, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "PASSWORD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label4.Location = new System.Drawing.Point(339, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(400, 34);
            this.label4.TabIndex = 15;
            this.label4.Text = "Create an account if you are New!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MV Boli", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Ivory;
            this.label3.Location = new System.Drawing.Point(427, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(387, 41);
            this.label3.TabIndex = 16;
            this.label3.Text = "Login as a Customer...";
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.CustomIconSize = 15F;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.PaleGreen;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(69, 12);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 18;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Brown;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(18, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 17;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnLogout.Location = new System.Drawing.Point(0, 47);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 41);
            this.btnLogout.TabIndex = 19;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::trial.Properties.Resources.Login_Page;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 620);
            this.ControlBox = false;
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Button btnLogout;
    }
}