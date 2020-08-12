namespace MC_Application
{
    partial class EditInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditInvoice));
            this.labelEditInvoice = new System.Windows.Forms.Label();
            this.dataEditInvoice = new System.Windows.Forms.DataGridView();
            this.labelInvoiceNumber = new System.Windows.Forms.Label();
            this.buttonPrintInvoice = new System.Windows.Forms.Button();
            this.buttonSaveInvoice = new System.Windows.Forms.Button();
            this.labelInvoiceDate = new System.Windows.Forms.Label();
            this.textBoxInvoiceDate = new System.Windows.Forms.TextBox();
            this.labelInvoiceStatus = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataEditInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEditInvoice
            // 
            this.labelEditInvoice.AutoSize = true;
            this.labelEditInvoice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditInvoice.Location = new System.Drawing.Point(12, 9);
            this.labelEditInvoice.Name = "labelEditInvoice";
            this.labelEditInvoice.Size = new System.Drawing.Size(148, 28);
            this.labelEditInvoice.TabIndex = 21;
            this.labelEditInvoice.Text = "Edit Invoice";
            // 
            // dataEditInvoice
            // 
            this.dataEditInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEditInvoice.Location = new System.Drawing.Point(12, 60);
            this.dataEditInvoice.Name = "dataEditInvoice";
            this.dataEditInvoice.Size = new System.Drawing.Size(1360, 532);
            this.dataEditInvoice.TabIndex = 22;
            // 
            // labelInvoiceNumber
            // 
            this.labelInvoiceNumber.AutoSize = true;
            this.labelInvoiceNumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInvoiceNumber.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelInvoiceNumber.Location = new System.Drawing.Point(1005, 9);
            this.labelInvoiceNumber.Name = "labelInvoiceNumber";
            this.labelInvoiceNumber.Size = new System.Drawing.Size(367, 28);
            this.labelInvoiceNumber.TabIndex = 23;
            this.labelInvoiceNumber.Text = "Invoice Number autopopulated";
            // 
            // buttonPrintInvoice
            // 
            this.buttonPrintInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.buttonPrintInvoice.FlatAppearance.BorderSize = 0;
            this.buttonPrintInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrintInvoice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrintInvoice.ForeColor = System.Drawing.Color.White;
            this.buttonPrintInvoice.Location = new System.Drawing.Point(705, 639);
            this.buttonPrintInvoice.Name = "buttonPrintInvoice";
            this.buttonPrintInvoice.Size = new System.Drawing.Size(100, 35);
            this.buttonPrintInvoice.TabIndex = 24;
            this.buttonPrintInvoice.Text = "Print";
            this.buttonPrintInvoice.UseVisualStyleBackColor = false;
            // 
            // buttonSaveInvoice
            // 
            this.buttonSaveInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.buttonSaveInvoice.FlatAppearance.BorderSize = 0;
            this.buttonSaveInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveInvoice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveInvoice.ForeColor = System.Drawing.Color.White;
            this.buttonSaveInvoice.Location = new System.Drawing.Point(580, 639);
            this.buttonSaveInvoice.Name = "buttonSaveInvoice";
            this.buttonSaveInvoice.Size = new System.Drawing.Size(100, 35);
            this.buttonSaveInvoice.TabIndex = 25;
            this.buttonSaveInvoice.Text = "Save";
            this.buttonSaveInvoice.UseVisualStyleBackColor = false;
            this.buttonSaveInvoice.Click += new System.EventHandler(this.buttonSaveInvoice_Click);
            // 
            // labelInvoiceDate
            // 
            this.labelInvoiceDate.AutoSize = true;
            this.labelInvoiceDate.Location = new System.Drawing.Point(359, 648);
            this.labelInvoiceDate.Name = "labelInvoiceDate";
            this.labelInvoiceDate.Size = new System.Drawing.Size(46, 18);
            this.labelInvoiceDate.TabIndex = 26;
            this.labelInvoiceDate.Text = "Date";
            // 
            // textBoxInvoiceDate
            // 
            this.textBoxInvoiceDate.Location = new System.Drawing.Point(411, 645);
            this.textBoxInvoiceDate.Name = "textBoxInvoiceDate";
            this.textBoxInvoiceDate.Size = new System.Drawing.Size(152, 26);
            this.textBoxInvoiceDate.TabIndex = 27;
            this.textBoxInvoiceDate.Text = "inv date populates here";
            // 
            // labelInvoiceStatus
            // 
            this.labelInvoiceStatus.AutoSize = true;
            this.labelInvoiceStatus.Location = new System.Drawing.Point(25, 620);
            this.labelInvoiceStatus.Name = "labelInvoiceStatus";
            this.labelInvoiceStatus.Size = new System.Drawing.Size(60, 18);
            this.labelInvoiceStatus.TabIndex = 28;
            this.labelInvoiceStatus.Text = "Status";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Open",
            "Closed, Pending Payment",
            "Closed, Payment Received"});
            this.comboBox1.Location = new System.Drawing.Point(91, 617);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 26);
            this.comboBox1.TabIndex = 29;
            // 
            // EditInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1384, 711);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelInvoiceStatus);
            this.Controls.Add(this.textBoxInvoiceDate);
            this.Controls.Add(this.labelInvoiceDate);
            this.Controls.Add(this.buttonSaveInvoice);
            this.Controls.Add(this.buttonPrintInvoice);
            this.Controls.Add(this.labelInvoiceNumber);
            this.Controls.Add(this.dataEditInvoice);
            this.Controls.Add(this.labelEditInvoice);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "EditInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Invoice";
            ((System.ComponentModel.ISupportInitialize)(this.dataEditInvoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEditInvoice;
        private System.Windows.Forms.DataGridView dataEditInvoice;
        private System.Windows.Forms.Label labelInvoiceNumber;
        private System.Windows.Forms.Button buttonPrintInvoice;
        private System.Windows.Forms.Button buttonSaveInvoice;
        private System.Windows.Forms.Label labelInvoiceDate;
        private System.Windows.Forms.TextBox textBoxInvoiceDate;
        private System.Windows.Forms.Label labelInvoiceStatus;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}