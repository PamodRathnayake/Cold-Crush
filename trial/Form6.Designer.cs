namespace trial
{
    partial class EmployeeLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEUsername = new System.Windows.Forms.TextBox();
            this.txtEPassword = new System.Windows.Forms.TextBox();
            this.btnEmLogin = new System.Windows.Forms.Button();
            this.btnEmCreate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Raleway SemiBold", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "USERNAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Raleway SemiBold", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(321, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "PASSWORD";
            // 
            // txtEUsername
            // 
            this.txtEUsername.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtEUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEUsername.Location = new System.Drawing.Point(437, 212);
            this.txtEUsername.Name = "txtEUsername";
            this.txtEUsername.Size = new System.Drawing.Size(367, 19);
            this.txtEUsername.TabIndex = 9;
            // 
            // txtEPassword
            // 
            this.txtEPassword.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtEPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEPassword.Location = new System.Drawing.Point(437, 250);
            this.txtEPassword.Name = "txtEPassword";
            this.txtEPassword.PasswordChar = '*';
            this.txtEPassword.Size = new System.Drawing.Size(367, 19);
            this.txtEPassword.TabIndex = 10;
            // 
            // btnEmLogin
            // 
            this.btnEmLogin.AutoSize = true;
            this.btnEmLogin.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnEmLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmLogin.Font = new System.Drawing.Font("Ink Free", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmLogin.ForeColor = System.Drawing.Color.White;
            this.btnEmLogin.Location = new System.Drawing.Point(437, 290);
            this.btnEmLogin.Name = "btnEmLogin";
            this.btnEmLogin.Size = new System.Drawing.Size(169, 40);
            this.btnEmLogin.TabIndex = 11;
            this.btnEmLogin.Text = "Login";
            this.btnEmLogin.UseVisualStyleBackColor = false;
            this.btnEmLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnEmCreate
            // 
            this.btnEmCreate.AutoSize = true;
            this.btnEmCreate.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnEmCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmCreate.Font = new System.Drawing.Font("Ink Free", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmCreate.ForeColor = System.Drawing.Color.White;
            this.btnEmCreate.Location = new System.Drawing.Point(635, 290);
            this.btnEmCreate.Name = "btnEmCreate";
            this.btnEmCreate.Size = new System.Drawing.Size(169, 40);
            this.btnEmCreate.TabIndex = 12;
            this.btnEmCreate.Text = "Create";
            this.btnEmCreate.UseVisualStyleBackColor = false;
            this.btnEmCreate.Click += new System.EventHandler(this.btnEmCreate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MV Boli", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Ivory;
            this.label3.Location = new System.Drawing.Point(430, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 41);
            this.label3.TabIndex = 13;
            this.label3.Text = "Login as Employee...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label4.Location = new System.Drawing.Point(385, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(400, 34);
            this.label4.TabIndex = 14;
            this.label4.Text = "Create an account if you are New!";
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.CustomIconSize = 15F;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.PaleGreen;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(64, 12);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 16;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Brown;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(13, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 15;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnLogout.Location = new System.Drawing.Point(-2, 47);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(180, 41);
            this.btnLogout.TabIndex = 38;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // EmployeeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::trial.Properties.Resources.Logim_Succes;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 620);
            this.ControlBox = false;
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEmCreate);
            this.Controls.Add(this.btnEmLogin);
            this.Controls.Add(this.txtEPassword);
            this.Controls.Add(this.txtEUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.EmployeeLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEUsername;
        private System.Windows.Forms.TextBox txtEPassword;
        private System.Windows.Forms.Button btnEmLogin;
        private System.Windows.Forms.Button btnEmCreate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Button btnLogout;
    }
}