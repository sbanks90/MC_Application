namespace MC_Application
{
    partial class EditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUser));
            this.comboBoxUserAccess = new System.Windows.Forms.ComboBox();
            this.buttonSubmitEditCustomer = new System.Windows.Forms.Button();
            this.textBoxEditBillingAddress = new System.Windows.Forms.TextBox();
            this.textBoxEditDeliveryAddress = new System.Windows.Forms.TextBox();
            this.textBoxClientID = new System.Windows.Forms.TextBox();
            this.textBoxEditContactName = new System.Windows.Forms.TextBox();
            this.textBoxEditCustomerName = new System.Windows.Forms.TextBox();
            this.labelUserLastName = new System.Windows.Forms.Label();
            this.labelUserPassword = new System.Windows.Forms.Label();
            this.labelUserCreationDate = new System.Windows.Forms.Label();
            this.labelAccess = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelUserFirstName = new System.Windows.Forms.Label();
            this.labelEditUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxUserAccess
            // 
            this.comboBoxUserAccess.BackColor = System.Drawing.Color.White;
            this.comboBoxUserAccess.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUserAccess.FormattingEnabled = true;
            this.comboBoxUserAccess.Items.AddRange(new object[] {
            "Employee",
            "Admin"});
            this.comboBoxUserAccess.Location = new System.Drawing.Point(245, 406);
            this.comboBoxUserAccess.Name = "comboBoxUserAccess";
            this.comboBoxUserAccess.Size = new System.Drawing.Size(161, 26);
            this.comboBoxUserAccess.TabIndex = 67;
            this.comboBoxUserAccess.Text = "Choose Access";
            // 
            // buttonSubmitEditCustomer
            // 
            this.buttonSubmitEditCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.buttonSubmitEditCustomer.FlatAppearance.BorderSize = 0;
            this.buttonSubmitEditCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmitEditCustomer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmitEditCustomer.ForeColor = System.Drawing.Color.White;
            this.buttonSubmitEditCustomer.Location = new System.Drawing.Point(188, 543);
            this.buttonSubmitEditCustomer.Name = "buttonSubmitEditCustomer";
            this.buttonSubmitEditCustomer.Size = new System.Drawing.Size(209, 35);
            this.buttonSubmitEditCustomer.TabIndex = 66;
            this.buttonSubmitEditCustomer.Text = "Submit";
            this.buttonSubmitEditCustomer.UseVisualStyleBackColor = false;
            // 
            // textBoxEditBillingAddress
            // 
            this.textBoxEditBillingAddress.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEditBillingAddress.Location = new System.Drawing.Point(245, 214);
            this.textBoxEditBillingAddress.Name = "textBoxEditBillingAddress";
            this.textBoxEditBillingAddress.Size = new System.Drawing.Size(281, 26);
            this.textBoxEditBillingAddress.TabIndex = 65;
            this.textBoxEditBillingAddress.Text = "autopopulate from user selection";
            // 
            // textBoxEditDeliveryAddress
            // 
            this.textBoxEditDeliveryAddress.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEditDeliveryAddress.Location = new System.Drawing.Point(245, 277);
            this.textBoxEditDeliveryAddress.Name = "textBoxEditDeliveryAddress";
            this.textBoxEditDeliveryAddress.Size = new System.Drawing.Size(281, 26);
            this.textBoxEditDeliveryAddress.TabIndex = 64;
            this.textBoxEditDeliveryAddress.Text = "autopopulate from user selection";
            // 
            // textBoxClientID
            // 
            this.textBoxClientID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClientID.Location = new System.Drawing.Point(245, 466);
            this.textBoxClientID.Name = "textBoxClientID";
            this.textBoxClientID.Size = new System.Drawing.Size(45, 26);
            this.textBoxClientID.TabIndex = 63;
            this.textBoxClientID.Text = "auto generated by system";
            // 
            // textBoxEditContactName
            // 
            this.textBoxEditContactName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEditContactName.Location = new System.Drawing.Point(245, 340);
            this.textBoxEditContactName.Name = "textBoxEditContactName";
            this.textBoxEditContactName.Size = new System.Drawing.Size(281, 26);
            this.textBoxEditContactName.TabIndex = 62;
            this.textBoxEditContactName.Text = "autopopulate from user selection";
            // 
            // textBoxEditCustomerName
            // 
            this.textBoxEditCustomerName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEditCustomerName.Location = new System.Drawing.Point(245, 151);
            this.textBoxEditCustomerName.Name = "textBoxEditCustomerName";
            this.textBoxEditCustomerName.Size = new System.Drawing.Size(281, 26);
            this.textBoxEditCustomerName.TabIndex = 61;
            this.textBoxEditCustomerName.Text = "autopopulate from user selection";
            // 
            // labelUserLastName
            // 
            this.labelUserLastName.AutoSize = true;
            this.labelUserLastName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserLastName.Location = new System.Drawing.Point(61, 217);
            this.labelUserLastName.Name = "labelUserLastName";
            this.labelUserLastName.Size = new System.Drawing.Size(93, 18);
            this.labelUserLastName.TabIndex = 60;
            this.labelUserLastName.Text = "Last Name";
            // 
            // labelUserPassword
            // 
            this.labelUserPassword.AutoSize = true;
            this.labelUserPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserPassword.Location = new System.Drawing.Point(61, 280);
            this.labelUserPassword.Name = "labelUserPassword";
            this.labelUserPassword.Size = new System.Drawing.Size(87, 18);
            this.labelUserPassword.TabIndex = 59;
            this.labelUserPassword.Text = "Password";
            // 
            // labelUserCreationDate
            // 
            this.labelUserCreationDate.AutoSize = true;
            this.labelUserCreationDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserCreationDate.Location = new System.Drawing.Point(61, 343);
            this.labelUserCreationDate.Name = "labelUserCreationDate";
            this.labelUserCreationDate.Size = new System.Drawing.Size(119, 18);
            this.labelUserCreationDate.TabIndex = 58;
            this.labelUserCreationDate.Text = "Creation Date";
            // 
            // labelAccess
            // 
            this.labelAccess.AutoSize = true;
            this.labelAccess.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccess.Location = new System.Drawing.Point(61, 406);
            this.labelAccess.Name = "labelAccess";
            this.labelAccess.Size = new System.Drawing.Size(68, 18);
            this.labelAccess.TabIndex = 57;
            this.labelAccess.Text = "Access";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(61, 469);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(67, 18);
            this.labelEmail.TabIndex = 56;
            this.labelEmail.Text = "User ID";
            // 
            // labelUserFirstName
            // 
            this.labelUserFirstName.AutoSize = true;
            this.labelUserFirstName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserFirstName.Location = new System.Drawing.Point(61, 154);
            this.labelUserFirstName.Name = "labelUserFirstName";
            this.labelUserFirstName.Size = new System.Drawing.Size(94, 18);
            this.labelUserFirstName.TabIndex = 55;
            this.labelUserFirstName.Text = "First Name";
            // 
            // labelEditUser
            // 
            this.labelEditUser.AutoSize = true;
            this.labelEditUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditUser.Location = new System.Drawing.Point(59, 53);
            this.labelEditUser.Name = "labelEditUser";
            this.labelEditUser.Size = new System.Drawing.Size(120, 28);
            this.labelEditUser.TabIndex = 54;
            this.labelEditUser.Text = "Edit User";
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 631);
            this.Controls.Add(this.comboBoxUserAccess);
            this.Controls.Add(this.buttonSubmitEditCustomer);
            this.Controls.Add(this.textBoxEditBillingAddress);
            this.Controls.Add(this.textBoxEditDeliveryAddress);
            this.Controls.Add(this.textBoxClientID);
            this.Controls.Add(this.textBoxEditContactName);
            this.Controls.Add(this.textBoxEditCustomerName);
            this.Controls.Add(this.labelUserLastName);
            this.Controls.Add(this.labelUserPassword);
            this.Controls.Add(this.labelUserCreationDate);
            this.Controls.Add(this.labelAccess);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelUserFirstName);
            this.Controls.Add(this.labelEditUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxUserAccess;
        private System.Windows.Forms.Button buttonSubmitEditCustomer;
        private System.Windows.Forms.TextBox textBoxEditBillingAddress;
        private System.Windows.Forms.TextBox textBoxEditDeliveryAddress;
        private System.Windows.Forms.TextBox textBoxClientID;
        private System.Windows.Forms.TextBox textBoxEditContactName;
        private System.Windows.Forms.TextBox textBoxEditCustomerName;
        private System.Windows.Forms.Label labelUserLastName;
        private System.Windows.Forms.Label labelUserPassword;
        private System.Windows.Forms.Label labelUserCreationDate;
        private System.Windows.Forms.Label labelAccess;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelUserFirstName;
        private System.Windows.Forms.Label labelEditUser;
    }
}