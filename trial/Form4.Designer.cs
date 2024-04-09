namespace trial
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel2 = new System.Windows.Forms.Panel();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnDeliver = new System.Windows.Forms.Button();
            this.btnContact = new System.Windows.Forms.Button();
            this.btnIce = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.cart1 = new trial.cart();
            this.contact1 = new trial.contact();
            this.delivery1 = new trial.Delivery();
            this.home1 = new trial.home();
            this.products1 = new trial.Products();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.sidepanel);
            this.panel2.Controls.Add(this.guna2ControlBox2);
            this.panel2.Controls.Add(this.guna2ControlBox1);
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.btnDeliver);
            this.panel2.Controls.Add(this.btnContact);
            this.panel2.Controls.Add(this.btnIce);
            this.panel2.Controls.Add(this.btnProduct);
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 620);
            this.panel2.TabIndex = 9;
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.sidepanel.Location = new System.Drawing.Point(12, 108);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(11, 48);
            this.sidepanel.TabIndex = 1;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.CustomIconSize = 15F;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.PaleGreen;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(65, 12);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 17;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Brown;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(14, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 16;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Ink Free", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnLogout.Location = new System.Drawing.Point(0, 531);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 41);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnDeliver
            // 
            this.btnDeliver.BackColor = System.Drawing.Color.Transparent;
            this.btnDeliver.FlatAppearance.BorderSize = 0;
            this.btnDeliver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeliver.Font = new System.Drawing.Font("Ink Free", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeliver.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnDeliver.Location = new System.Drawing.Point(0, 365);
            this.btnDeliver.Name = "btnDeliver";
            this.btnDeliver.Size = new System.Drawing.Size(197, 42);
            this.btnDeliver.TabIndex = 5;
            this.btnDeliver.Text = "Delivery";
            this.btnDeliver.UseVisualStyleBackColor = false;
            this.btnDeliver.Click += new System.EventHandler(this.btnDeliver_Click);
            // 
            // btnContact
            // 
            this.btnContact.BackColor = System.Drawing.Color.Transparent;
            this.btnContact.FlatAppearance.BorderSize = 0;
            this.btnContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContact.Font = new System.Drawing.Font("Ink Free", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContact.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnContact.Location = new System.Drawing.Point(0, 448);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(200, 42);
            this.btnContact.TabIndex = 1;
            this.btnContact.Text = "Contact";
            this.btnContact.UseVisualStyleBackColor = false;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // btnIce
            // 
            this.btnIce.BackColor = System.Drawing.Color.Transparent;
            this.btnIce.FlatAppearance.BorderSize = 0;
            this.btnIce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIce.Font = new System.Drawing.Font("Ink Free", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIce.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnIce.Location = new System.Drawing.Point(0, 280);
            this.btnIce.Name = "btnIce";
            this.btnIce.Size = new System.Drawing.Size(200, 44);
            this.btnIce.TabIndex = 2;
            this.btnIce.Text = "Orders";
            this.btnIce.UseVisualStyleBackColor = false;
            this.btnIce.Click += new System.EventHandler(this.btnIce_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Ink Free", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnProduct.Location = new System.Drawing.Point(-3, 193);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(200, 46);
            this.btnProduct.TabIndex = 1;
            this.btnProduct.Text = "Products";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Ink Free", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnHome.Location = new System.Drawing.Point(-3, 108);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(200, 44);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // cart1
            // 
            this.cart1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cart1.BackgroundImage")));
            this.cart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cart1.Location = new System.Drawing.Point(206, -3);
            this.cart1.Name = "cart1";
            this.cart1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cart1.Size = new System.Drawing.Size(975, 620);
            this.cart1.TabIndex = 18;
            // 
            // contact1
            // 
            this.contact1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("contact1.BackgroundImage")));
            this.contact1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.contact1.Location = new System.Drawing.Point(203, -3);
            this.contact1.Name = "contact1";
            this.contact1.Size = new System.Drawing.Size(978, 620);
            this.contact1.TabIndex = 13;
            this.contact1.Load += new System.EventHandler(this.contact1_Load);
            // 
            // delivery1
            // 
            this.delivery1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delivery1.BackgroundImage")));
            this.delivery1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delivery1.Location = new System.Drawing.Point(203, 0);
            this.delivery1.Name = "delivery1";
            this.delivery1.Size = new System.Drawing.Size(978, 620);
            this.delivery1.TabIndex = 12;
            // 
            // home1
            // 
            this.home1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("home1.BackgroundImage")));
            this.home1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.home1.Location = new System.Drawing.Point(203, 0);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(978, 620);
            this.home1.TabIndex = 10;
            // 
            // products1
            // 
            this.products1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("products1.BackgroundImage")));
            this.products1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.products1.Location = new System.Drawing.Point(206, 0);
            this.products1.Name = "products1";
            this.products1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.products1.Size = new System.Drawing.Size(979, 620);
            this.products1.TabIndex = 11;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::trial.Properties.Resources.WhatsApp_Image_2023_03_11_at_17_105;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 620);
            this.Controls.Add(this.cart1);
            this.Controls.Add(this.contact1);
            this.Controls.Add(this.delivery1);
            this.Controls.Add(this.products1);
            this.Controls.Add(this.home1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel sidepanel;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnDeliver;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.Button btnIce;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnHome;
        private home home1;
        private Delivery delivery1;
        private contact contact1;
        private cart cart1;
        private Products products1;
    }
}