namespace MC_Application
{
    partial class NewPackingSlip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPackingSlip));
            this.dataNewPackingSlip = new System.Windows.Forms.DataGridView();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.buttonSaveNewPackingSlip = new System.Windows.Forms.Button();
            this.labelPackingSlipID = new System.Windows.Forms.Label();
            this.textBoxClientID = new System.Windows.Forms.TextBox();
            this.labelNewPackingSlip = new System.Windows.Forms.Label();
            this.buttonPrintNewPackingSlip = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataNewPackingSlip)).BeginInit();
            this.SuspendLayout();
            // 
            // dataNewPackingSlip
            // 
            this.dataNewPackingSlip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNewPackingSlip.Location = new System.Drawing.Point(335, 28);
            this.dataNewPackingSlip.Name = "dataNewPackingSlip";
            this.dataNewPackingSlip.Size = new System.Drawing.Size(1021, 661);
            this.dataNewPackingSlip.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(52, 268);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.FormattingEnabled = true;
            this.comboBoxCustomer.Items.AddRange(new object[] {
            "Air Canada",
            "Air France",
            "Air Transat",
            "Lufthansa"});
            this.comboBoxCustomer.Location = new System.Drawing.Point(56, 96);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(219, 26);
            this.comboBoxCustomer.TabIndex = 2;
            this.comboBoxCustomer.Text = "Choose Customer";
            // 
            // buttonSaveNewPackingSlip
            // 
            this.buttonSaveNewPackingSlip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.buttonSaveNewPackingSlip.FlatAppearance.BorderSize = 0;
            this.buttonSaveNewPackingSlip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveNewPackingSlip.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveNewPackingSlip.ForeColor = System.Drawing.Color.White;
            this.buttonSaveNewPackingSlip.Location = new System.Drawing.Point(34, 549);
            this.buttonSaveNewPackingSlip.Name = "buttonSaveNewPackingSlip";
            this.buttonSaveNewPackingSlip.Size = new System.Drawing.Size(111, 35);
            this.buttonSaveNewPackingSlip.TabIndex = 3;
            this.buttonSaveNewPackingSlip.Text = "Save";
            this.buttonSaveNewPackingSlip.UseVisualStyleBackColor = false;
            // 
            // labelPackingSlipID
            // 
            this.labelPackingSlipID.AutoSize = true;
            this.labelPackingSlipID.Location = new System.Drawing.Point(64, 466);
            this.labelPackingSlipID.Name = "labelPackingSlipID";
            this.labelPackingSlipID.Size = new System.Drawing.Size(126, 18);
            this.labelPackingSlipID.TabIndex = 4;
            this.labelPackingSlipID.Text = "Packing Slip ID";
            this.labelPackingSlipID.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxClientID
            // 
            this.textBoxClientID.Location = new System.Drawing.Point(196, 463);
            this.textBoxClientID.Name = "textBoxClientID";
            this.textBoxClientID.Size = new System.Drawing.Size(47, 26);
            this.textBoxClientID.TabIndex = 5;
            this.textBoxClientID.TextChanged += new System.EventHandler(this.textBoxClientID_TextChanged);
            // 
            // labelNewPackingSlip
            // 
            this.labelNewPackingSlip.AutoSize = true;
            this.labelNewPackingSlip.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewPackingSlip.Location = new System.Drawing.Point(58, 28);
            this.labelNewPackingSlip.Name = "labelNewPackingSlip";
            this.labelNewPackingSlip.Size = new System.Drawing.Size(215, 28);
            this.labelNewPackingSlip.TabIndex = 6;
            this.labelNewPackingSlip.Text = "New Packing Slip";
            // 
            // buttonPrintNewPackingSlip
            // 
            this.buttonPrintNewPackingSlip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.buttonPrintNewPackingSlip.FlatAppearance.BorderSize = 0;
            this.buttonPrintNewPackingSlip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrintNewPackingSlip.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrintNewPackingSlip.ForeColor = System.Drawing.Color.White;
            this.buttonPrintNewPackingSlip.Location = new System.Drawing.Point(168, 549);
            this.buttonPrintNewPackingSlip.Name = "buttonPrintNewPackingSlip";
            this.buttonPrintNewPackingSlip.Size = new System.Drawing.Size(111, 35);
            this.buttonPrintNewPackingSlip.TabIndex = 7;
            this.buttonPrintNewPackingSlip.Text = "Print";
            this.buttonPrintNewPackingSlip.UseVisualStyleBackColor = false;
            // 
            // NewPackingSlip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1384, 711);
            this.Controls.Add(this.buttonPrintNewPackingSlip);
            this.Controls.Add(this.labelNewPackingSlip);
            this.Controls.Add(this.textBoxClientID);
            this.Controls.Add(this.labelPackingSlipID);
            this.Controls.Add(this.buttonSaveNewPackingSlip);
            this.Controls.Add(this.comboBoxCustomer);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dataNewPackingSlip);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "NewPackingSlip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Packing Slip";
            ((System.ComponentModel.ISupportInitialize)(this.dataNewPackingSlip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataNewPackingSlip;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ComboBox comboBoxCustomer;
        private System.Windows.Forms.Button buttonSaveNewPackingSlip;
        private System.Windows.Forms.Label labelPackingSlipID;
        private System.Windows.Forms.TextBox textBoxClientID;
        private System.Windows.Forms.Label labelNewPackingSlip;
        private System.Windows.Forms.Button buttonPrintNewPackingSlip;
    }
}