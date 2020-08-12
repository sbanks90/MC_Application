namespace MC_Application
{
    partial class FormHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHomePage));
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.buttonExitHome = new System.Windows.Forms.Button();
            this.labelMCServices = new System.Windows.Forms.Label();
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.textBoxWelcome = new System.Windows.Forms.TextBox();
            this.panelSidePanel = new System.Windows.Forms.Panel();
            this.buttonAddPackingSlip = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonPackingSlips = new System.Windows.Forms.Button();
            this.buttonManageUsers = new System.Windows.Forms.Button();
            this.buttonItems = new System.Windows.Forms.Button();
            this.buttonOrders = new System.Windows.Forms.Button();
            this.buttonInvoices = new System.Windows.Forms.Button();
            this.buttonCustomers = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.ucPackingSlips = new MC_Application.ucPackingSlips();
            this.ucOrders = new MC_Application.ucOrders();
            this.ucCustomers = new MC_Application.ucCustomers();
            this.ucInvoices = new MC_Application.ucInvoices();
            this.ucUsers = new MC_Application.ucUsers();
            this.panelTopBar.SuspendLayout();
            this.panelSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelTopBar.Controls.Add(this.buttonExitHome);
            this.panelTopBar.Controls.Add(this.labelMCServices);
            this.panelTopBar.Location = new System.Drawing.Point(300, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(1200, 35);
            this.panelTopBar.TabIndex = 0;
            this.panelTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTopBar_MouseDown);
            this.panelTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTopBar_MouseMove);
            this.panelTopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTopBar_MouseUp);
            // 
            // buttonExitHome
            // 
            this.buttonExitHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonExitHome.FlatAppearance.BorderSize = 0;
            this.buttonExitHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitHome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExitHome.ForeColor = System.Drawing.Color.White;
            this.buttonExitHome.Location = new System.Drawing.Point(1119, 0);
            this.buttonExitHome.Name = "buttonExitHome";
            this.buttonExitHome.Size = new System.Drawing.Size(81, 32);
            this.buttonExitHome.TabIndex = 0;
            this.buttonExitHome.Text = "Exit";
            this.buttonExitHome.UseVisualStyleBackColor = true;
            this.buttonExitHome.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelMCServices
            // 
            this.labelMCServices.AutoSize = true;
            this.labelMCServices.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMCServices.ForeColor = System.Drawing.Color.White;
            this.labelMCServices.Location = new System.Drawing.Point(6, 8);
            this.labelMCServices.Name = "labelMCServices";
            this.labelMCServices.Size = new System.Drawing.Size(269, 22);
            this.labelMCServices.TabIndex = 3;
            this.labelMCServices.Text = "Monte Chiaro Services v1.00";
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelSideBar.Controls.Add(this.buttonManageUsers);
            this.panelSideBar.Controls.Add(this.buttonItems);
            this.panelSideBar.Controls.Add(this.buttonInvoices);
            this.panelSideBar.Controls.Add(this.buttonCustomers);
            this.panelSideBar.Controls.Add(this.buttonOrders);
            this.panelSideBar.Controls.Add(this.buttonPackingSlips);
            this.panelSideBar.Controls.Add(this.textBoxWelcome);
            this.panelSideBar.Controls.Add(this.panelSidePanel);
            this.panelSideBar.Controls.Add(this.buttonAddPackingSlip);
            this.panelSideBar.Controls.Add(this.pictureBox2);
            this.panelSideBar.Controls.Add(this.pictureBox3);
            this.panelSideBar.Controls.Add(this.pictureBox4);
            this.panelSideBar.Controls.Add(this.pictureBox5);
            this.panelSideBar.Controls.Add(this.pictureBox6);
            this.panelSideBar.Controls.Add(this.pictureBox1);
            this.panelSideBar.Location = new System.Drawing.Point(0, 0);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(300, 900);
            this.panelSideBar.TabIndex = 1;
            // 
            // textBoxWelcome
            // 
            this.textBoxWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBoxWelcome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxWelcome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWelcome.ForeColor = System.Drawing.Color.White;
            this.textBoxWelcome.Location = new System.Drawing.Point(12, 123);
            this.textBoxWelcome.Multiline = true;
            this.textBoxWelcome.Name = "textBoxWelcome";
            this.textBoxWelcome.Size = new System.Drawing.Size(273, 73);
            this.textBoxWelcome.TabIndex = 16;
            this.textBoxWelcome.Text = "Welcome Monte Chiaro User!";
            this.textBoxWelcome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelSidePanel
            // 
            this.panelSidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelSidePanel.Location = new System.Drawing.Point(0, 230);
            this.panelSidePanel.Name = "panelSidePanel";
            this.panelSidePanel.Size = new System.Drawing.Size(13, 68);
            this.panelSidePanel.TabIndex = 13;
            // 
            // buttonAddPackingSlip
            // 
            this.buttonAddPackingSlip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonAddPackingSlip.FlatAppearance.BorderSize = 0;
            this.buttonAddPackingSlip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddPackingSlip.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddPackingSlip.ForeColor = System.Drawing.Color.White;
            this.buttonAddPackingSlip.Location = new System.Drawing.Point(241, 378);
            this.buttonAddPackingSlip.Name = "buttonAddPackingSlip";
            this.buttonAddPackingSlip.Size = new System.Drawing.Size(56, 68);
            this.buttonAddPackingSlip.TabIndex = 12;
            this.buttonAddPackingSlip.Text = "+";
            this.buttonAddPackingSlip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddPackingSlip.UseVisualStyleBackColor = false;
            this.buttonAddPackingSlip.Click += new System.EventHandler(this.buttonAddPackingSlip_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 304);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 378);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(65, 68);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(13, 452);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(65, 68);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(13, 526);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(65, 68);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(13, 600);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(65, 68);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 230);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // buttonPackingSlips
            // 
            this.buttonPackingSlips.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonPackingSlips.FlatAppearance.BorderSize = 0;
            this.buttonPackingSlips.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPackingSlips.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPackingSlips.ForeColor = System.Drawing.Color.White;
            this.buttonPackingSlips.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPackingSlips.Location = new System.Drawing.Point(84, 378);
            this.buttonPackingSlips.Name = "buttonPackingSlips";
            this.buttonPackingSlips.Size = new System.Drawing.Size(154, 68);
            this.buttonPackingSlips.TabIndex = 5;
            this.buttonPackingSlips.Text = "Packing Slips";
            this.buttonPackingSlips.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPackingSlips.UseVisualStyleBackColor = false;
            this.buttonPackingSlips.Click += new System.EventHandler(this.buttonPackingSlips_Click);
            // 
            // buttonManageUsers
            // 
            this.buttonManageUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonManageUsers.FlatAppearance.BorderSize = 0;
            this.buttonManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManageUsers.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManageUsers.ForeColor = System.Drawing.Color.White;
            this.buttonManageUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonManageUsers.Location = new System.Drawing.Point(84, 600);
            this.buttonManageUsers.Name = "buttonManageUsers";
            this.buttonManageUsers.Size = new System.Drawing.Size(154, 68);
            this.buttonManageUsers.TabIndex = 4;
            this.buttonManageUsers.Text = "Manage Users";
            this.buttonManageUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonManageUsers.UseVisualStyleBackColor = false;
            this.buttonManageUsers.Click += new System.EventHandler(this.buttonManageUsers_Click);
            // 
            // buttonItems
            // 
            this.buttonItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonItems.FlatAppearance.BorderSize = 0;
            this.buttonItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonItems.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonItems.ForeColor = System.Drawing.Color.White;
            this.buttonItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonItems.Location = new System.Drawing.Point(84, 526);
            this.buttonItems.Name = "buttonItems";
            this.buttonItems.Size = new System.Drawing.Size(154, 68);
            this.buttonItems.TabIndex = 3;
            this.buttonItems.Text = "Items";
            this.buttonItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonItems.UseVisualStyleBackColor = false;
            this.buttonItems.Click += new System.EventHandler(this.buttonItems_Click);
            // 
            // buttonOrders
            // 
            this.buttonOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonOrders.FlatAppearance.BorderSize = 0;
            this.buttonOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrders.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrders.ForeColor = System.Drawing.Color.White;
            this.buttonOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOrders.Location = new System.Drawing.Point(84, 304);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(154, 68);
            this.buttonOrders.TabIndex = 2;
            this.buttonOrders.Text = "Orders";
            this.buttonOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOrders.UseVisualStyleBackColor = false;
            this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
            // 
            // buttonInvoices
            // 
            this.buttonInvoices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonInvoices.FlatAppearance.BorderSize = 0;
            this.buttonInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInvoices.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInvoices.ForeColor = System.Drawing.Color.White;
            this.buttonInvoices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInvoices.Location = new System.Drawing.Point(84, 452);
            this.buttonInvoices.Name = "buttonInvoices";
            this.buttonInvoices.Size = new System.Drawing.Size(154, 68);
            this.buttonInvoices.TabIndex = 1;
            this.buttonInvoices.Text = "Invoices";
            this.buttonInvoices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInvoices.UseVisualStyleBackColor = false;
            this.buttonInvoices.Click += new System.EventHandler(this.buttonInvoices_Click);
            // 
            // buttonCustomers
            // 
            this.buttonCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonCustomers.FlatAppearance.BorderSize = 0;
            this.buttonCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustomers.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCustomers.ForeColor = System.Drawing.Color.White;
            this.buttonCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCustomers.Location = new System.Drawing.Point(84, 230);
            this.buttonCustomers.Name = "buttonCustomers";
            this.buttonCustomers.Size = new System.Drawing.Size(154, 68);
            this.buttonCustomers.TabIndex = 0;
            this.buttonCustomers.Text = "Customers";
            this.buttonCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCustomers.UseVisualStyleBackColor = false;
            this.buttonCustomers.Click += new System.EventHandler(this.buttonCustomers_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(485, 292);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(822, 320);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 2;
            this.pictureBox7.TabStop = false;
            // 
            // ucPackingSlips
            // 
            this.ucPackingSlips.BackColor = System.Drawing.Color.White;
            this.ucPackingSlips.Location = new System.Drawing.Point(300, 33);
            this.ucPackingSlips.Name = "ucPackingSlips";
            this.ucPackingSlips.Size = new System.Drawing.Size(1200, 867);
            this.ucPackingSlips.TabIndex = 4;
            this.ucPackingSlips.Visible = false;
            this.ucPackingSlips.Load += new System.EventHandler(this.ucPackingSlips_Load);
            // 
            // ucOrders
            // 
            this.ucOrders.BackColor = System.Drawing.Color.White;
            this.ucOrders.Location = new System.Drawing.Point(300, 33);
            this.ucOrders.Name = "ucOrders";
            this.ucOrders.Size = new System.Drawing.Size(1200, 867);
            this.ucOrders.TabIndex = 3;
            this.ucOrders.Visible = false;
            // 
            // ucCustomers
            // 
            this.ucCustomers.BackColor = System.Drawing.Color.White;
            this.ucCustomers.Location = new System.Drawing.Point(300, 33);
            this.ucCustomers.Name = "ucCustomers";
            this.ucCustomers.Size = new System.Drawing.Size(1200, 867);
            this.ucCustomers.TabIndex = 3;
            this.ucCustomers.Visible = false;
            // 
            // ucInvoices
            // 
            this.ucInvoices.BackColor = System.Drawing.Color.White;
            this.ucInvoices.Location = new System.Drawing.Point(300, 33);
            this.ucInvoices.Name = "ucInvoices";
            this.ucInvoices.Size = new System.Drawing.Size(1200, 867);
            this.ucInvoices.TabIndex = 5;
            this.ucInvoices.Visible = false;
            // 
            // ucUsers
            // 
            this.ucUsers.BackColor = System.Drawing.Color.White;
            this.ucUsers.Location = new System.Drawing.Point(300, 33);
            this.ucUsers.Name = "ucUsers";
            this.ucUsers.Size = new System.Drawing.Size(1200, 867);
            this.ucUsers.TabIndex = 7;
            this.ucUsers.Visible = false;
            // 
            // FormHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1500, 900);
            this.Controls.Add(this.ucUsers);
            this.Controls.Add(this.ucInvoices);
            this.Controls.Add(this.ucPackingSlips);
            this.Controls.Add(this.ucOrders);
            this.Controls.Add(this.ucCustomers);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.panelSideBar);
            this.Controls.Add(this.panelTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.FormHomePage_Load_1);
            this.panelTopBar.ResumeLayout(false);
            this.panelTopBar.PerformLayout();
            this.panelSideBar.ResumeLayout(false);
            this.panelSideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.Button buttonPackingSlips;
        private System.Windows.Forms.Button buttonManageUsers;
        private System.Windows.Forms.Button buttonItems;
        private System.Windows.Forms.Button buttonOrders;
        private System.Windows.Forms.Button buttonInvoices;
        private System.Windows.Forms.Button buttonCustomers;
        private System.Windows.Forms.Panel panelSidePanel;
        private System.Windows.Forms.Button buttonAddPackingSlip;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonExitHome;
        public System.Windows.Forms.TextBox textBoxWelcome;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label labelMCServices;
        private ucCustomers ucCustomers;
        private ucOrders ucOrders;
        private ucPackingSlips ucPackingSlips;
        private ucInvoices ucInvoices;
        private ucItems ucItems;
        private ucUsers ucUsers;
    }
}