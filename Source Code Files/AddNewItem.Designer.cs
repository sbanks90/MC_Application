namespace MC_Application
{
    partial class AddNewItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewItem));
            this.labelAddNewItem = new System.Windows.Forms.Label();
            this.buttonSaveItem = new System.Windows.Forms.Button();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxPackSize = new System.Windows.Forms.TextBox();
            this.textBoxItemID = new System.Windows.Forms.TextBox();
            this.labelBilling = new System.Windows.Forms.Label();
            this.labelDelivery = new System.Windows.Forms.Label();
            this.labelContactName = new System.Windows.Forms.Label();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.mC_CrunchDataSet = new MC_Application.MC_CrunchDataSet();
            this.mCCrunchDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxClient = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.mC_CrunchDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCCrunchDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAddNewItem
            // 
            this.labelAddNewItem.AutoSize = true;
            this.labelAddNewItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddNewItem.Location = new System.Drawing.Point(195, 58);
            this.labelAddNewItem.Name = "labelAddNewItem";
            this.labelAddNewItem.Size = new System.Drawing.Size(174, 28);
            this.labelAddNewItem.TabIndex = 20;
            this.labelAddNewItem.Text = "Add New Item";
            // 
            // buttonSaveItem
            // 
            this.buttonSaveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.buttonSaveItem.FlatAppearance.BorderSize = 0;
            this.buttonSaveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveItem.ForeColor = System.Drawing.Color.White;
            this.buttonSaveItem.Location = new System.Drawing.Point(206, 434);
            this.buttonSaveItem.Name = "buttonSaveItem";
            this.buttonSaveItem.Size = new System.Drawing.Size(153, 35);
            this.buttonSaveItem.TabIndex = 17;
            this.buttonSaveItem.Text = "Save";
            this.buttonSaveItem.UseVisualStyleBackColor = false;
            this.buttonSaveItem.Click += new System.EventHandler(this.buttonSaveItem_Click);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(227, 204);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(281, 26);
            this.textBoxDescription.TabIndex = 22;
            // 
            // textBoxPackSize
            // 
            this.textBoxPackSize.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPackSize.Location = new System.Drawing.Point(227, 267);
            this.textBoxPackSize.Name = "textBoxPackSize";
            this.textBoxPackSize.Size = new System.Drawing.Size(281, 26);
            this.textBoxPackSize.TabIndex = 23;
            // 
            // textBoxItemID
            // 
            this.textBoxItemID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxItemID.Location = new System.Drawing.Point(227, 141);
            this.textBoxItemID.Name = "textBoxItemID";
            this.textBoxItemID.Size = new System.Drawing.Size(281, 26);
            this.textBoxItemID.TabIndex = 21;
            // 
            // labelBilling
            // 
            this.labelBilling.AutoSize = true;
            this.labelBilling.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBilling.Location = new System.Drawing.Point(43, 207);
            this.labelBilling.Name = "labelBilling";
            this.labelBilling.Size = new System.Drawing.Size(139, 18);
            this.labelBilling.TabIndex = 28;
            this.labelBilling.Text = "Item Description";
            // 
            // labelDelivery
            // 
            this.labelDelivery.AutoSize = true;
            this.labelDelivery.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDelivery.Location = new System.Drawing.Point(43, 270);
            this.labelDelivery.Name = "labelDelivery";
            this.labelDelivery.Size = new System.Drawing.Size(85, 18);
            this.labelDelivery.TabIndex = 27;
            this.labelDelivery.Text = "Pack Size";
            // 
            // labelContactName
            // 
            this.labelContactName.AutoSize = true;
            this.labelContactName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContactName.Location = new System.Drawing.Point(43, 333);
            this.labelContactName.Name = "labelContactName";
            this.labelContactName.Size = new System.Drawing.Size(104, 18);
            this.labelContactName.TabIndex = 26;
            this.labelContactName.Text = "Client Name";
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerName.Location = new System.Drawing.Point(43, 144);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(64, 18);
            this.labelCustomerName.TabIndex = 25;
            this.labelCustomerName.Text = "Item ID";
            // 
            // mC_CrunchDataSet
            // 
            this.mC_CrunchDataSet.DataSetName = "MC_CrunchDataSet";
            this.mC_CrunchDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mCCrunchDataSetBindingSource
            // 
            this.mCCrunchDataSetBindingSource.DataSource = this.mC_CrunchDataSet;
            this.mCCrunchDataSetBindingSource.Position = 0;
            // 
            // cbxClient
            // 
            this.cbxClient.FormattingEnabled = true;
            this.cbxClient.Items.AddRange(new object[] {
            "Air Canada",
            "Air France",
            "Air Transat",
            "Austrian Airlines",
            "CopaAirlines",
            "KLM Royal Dutch Airlines",
            "Lufthansa Cargo",
            "Royal Jordanian",
            "Swiss Air"});
            this.cbxClient.Location = new System.Drawing.Point(227, 330);
            this.cbxClient.Name = "cbxClient";
            this.cbxClient.Size = new System.Drawing.Size(281, 26);
            this.cbxClient.TabIndex = 30;
            // 
            // AddNewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(564, 537);
            this.Controls.Add(this.cbxClient);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxPackSize);
            this.Controls.Add(this.textBoxItemID);
            this.Controls.Add(this.labelBilling);
            this.Controls.Add(this.labelDelivery);
            this.Controls.Add(this.labelContactName);
            this.Controls.Add(this.labelCustomerName);
            this.Controls.Add(this.labelAddNewItem);
            this.Controls.Add(this.buttonSaveItem);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AddNewItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Item";
            ((System.ComponentModel.ISupportInitialize)(this.mC_CrunchDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCCrunchDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddNewItem;
        private System.Windows.Forms.Button buttonSaveItem;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxPackSize;
        private System.Windows.Forms.TextBox textBoxItemID;
        private System.Windows.Forms.Label labelBilling;
        private System.Windows.Forms.Label labelDelivery;
        private System.Windows.Forms.Label labelContactName;
        private System.Windows.Forms.Label labelCustomerName;
        private MC_CrunchDataSet mC_CrunchDataSet;
        private System.Windows.Forms.BindingSource mCCrunchDataSetBindingSource;
        private System.Windows.Forms.ComboBox cbxClient;
    }
}