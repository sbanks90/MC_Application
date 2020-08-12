namespace MC_Application
{
    partial class AddNewOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewOrder));
            this.labelAddNewOrder = new System.Windows.Forms.Label();
            this.textBoxClientID = new System.Windows.Forms.TextBox();
            this.labelOrderID = new System.Windows.Forms.Label();
            this.buttonCreateOrder = new System.Windows.Forms.Button();
            this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.dataNewOrder = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataNewOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAddNewOrder
            // 
            this.labelAddNewOrder.AutoSize = true;
            this.labelAddNewOrder.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddNewOrder.Location = new System.Drawing.Point(70, 61);
            this.labelAddNewOrder.Name = "labelAddNewOrder";
            this.labelAddNewOrder.Size = new System.Drawing.Size(193, 28);
            this.labelAddNewOrder.TabIndex = 14;
            this.labelAddNewOrder.Text = "Add New Order";
            // 
            // textBoxClientID
            // 
            this.textBoxClientID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClientID.Location = new System.Drawing.Point(196, 438);
            this.textBoxClientID.Name = "textBoxClientID";
            this.textBoxClientID.Size = new System.Drawing.Size(47, 26);
            this.textBoxClientID.TabIndex = 13;
            // 
            // labelOrderID
            // 
            this.labelOrderID.AutoSize = true;
            this.labelOrderID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderID.Location = new System.Drawing.Point(87, 441);
            this.labelOrderID.Name = "labelOrderID";
            this.labelOrderID.Size = new System.Drawing.Size(76, 18);
            this.labelOrderID.TabIndex = 12;
            this.labelOrderID.Text = "Order ID";
            // 
            // buttonCreateOrder
            // 
            this.buttonCreateOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.buttonCreateOrder.FlatAppearance.BorderSize = 0;
            this.buttonCreateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateOrder.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateOrder.ForeColor = System.Drawing.Color.White;
            this.buttonCreateOrder.Location = new System.Drawing.Point(90, 529);
            this.buttonCreateOrder.Name = "buttonCreateOrder";
            this.buttonCreateOrder.Size = new System.Drawing.Size(153, 35);
            this.buttonCreateOrder.TabIndex = 11;
            this.buttonCreateOrder.Text = "Create Order";
            this.buttonCreateOrder.UseVisualStyleBackColor = false;
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCustomer.FormattingEnabled = true;
            this.comboBoxCustomer.Items.AddRange(new object[] {
            "Air Canada",
            "Air France",
            "Air Transat",
            "Lufthansa"});
            this.comboBoxCustomer.Location = new System.Drawing.Point(57, 184);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(219, 26);
            this.comboBoxCustomer.TabIndex = 10;
            this.comboBoxCustomer.Text = "Choose Customer";
            // 
            // dataNewOrder
            // 
            this.dataNewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNewOrder.Location = new System.Drawing.Point(332, 12);
            this.dataNewOrder.Name = "dataNewOrder";
            this.dataNewOrder.Size = new System.Drawing.Size(1040, 687);
            this.dataNewOrder.TabIndex = 8;
            // 
            // AddNewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1384, 711);
            this.Controls.Add(this.labelAddNewOrder);
            this.Controls.Add(this.textBoxClientID);
            this.Controls.Add(this.labelOrderID);
            this.Controls.Add(this.buttonCreateOrder);
            this.Controls.Add(this.comboBoxCustomer);
            this.Controls.Add(this.dataNewOrder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddNewOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Order";
            ((System.ComponentModel.ISupportInitialize)(this.dataNewOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelAddNewOrder;
        private System.Windows.Forms.TextBox textBoxClientID;
        private System.Windows.Forms.Label labelOrderID;
        private System.Windows.Forms.Button buttonCreateOrder;
        private System.Windows.Forms.ComboBox comboBoxCustomer;
        private System.Windows.Forms.DataGridView dataNewOrder;
    }
}