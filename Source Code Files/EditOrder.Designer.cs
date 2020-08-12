namespace MC_Application
{
    partial class EditOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditOrder));
            this.labelEditOrder = new System.Windows.Forms.Label();
            this.textBoxClientID = new System.Windows.Forms.TextBox();
            this.labelOrderID = new System.Windows.Forms.Label();
            this.buttonSaveOrder = new System.Windows.Forms.Button();
            this.dataEditOrder = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataEditOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEditOrder
            // 
            this.labelEditOrder.AutoSize = true;
            this.labelEditOrder.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditOrder.Location = new System.Drawing.Point(84, 62);
            this.labelEditOrder.Name = "labelEditOrder";
            this.labelEditOrder.Size = new System.Drawing.Size(134, 28);
            this.labelEditOrder.TabIndex = 20;
            this.labelEditOrder.Text = "Edit Order";
            // 
            // textBoxClientID
            // 
            this.textBoxClientID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClientID.Location = new System.Drawing.Point(171, 224);
            this.textBoxClientID.Name = "textBoxClientID";
            this.textBoxClientID.Size = new System.Drawing.Size(47, 26);
            this.textBoxClientID.TabIndex = 19;
            // 
            // labelOrderID
            // 
            this.labelOrderID.AutoSize = true;
            this.labelOrderID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderID.Location = new System.Drawing.Point(72, 227);
            this.labelOrderID.Name = "labelOrderID";
            this.labelOrderID.Size = new System.Drawing.Size(76, 18);
            this.labelOrderID.TabIndex = 18;
            this.labelOrderID.Text = "Order ID";
            // 
            // buttonSaveOrder
            // 
            this.buttonSaveOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.buttonSaveOrder.FlatAppearance.BorderSize = 0;
            this.buttonSaveOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveOrder.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveOrder.ForeColor = System.Drawing.Color.White;
            this.buttonSaveOrder.Location = new System.Drawing.Point(75, 290);
            this.buttonSaveOrder.Name = "buttonSaveOrder";
            this.buttonSaveOrder.Size = new System.Drawing.Size(153, 35);
            this.buttonSaveOrder.TabIndex = 17;
            this.buttonSaveOrder.Text = "Save";
            this.buttonSaveOrder.UseVisualStyleBackColor = false;
            // 
            // dataEditOrder
            // 
            this.dataEditOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEditOrder.Location = new System.Drawing.Point(310, 12);
            this.dataEditOrder.Name = "dataEditOrder";
            this.dataEditOrder.Size = new System.Drawing.Size(1062, 687);
            this.dataEditOrder.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(33, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 26);
            this.textBox1.TabIndex = 21;
            this.textBox1.Text = "autopopulate with Cx name";
            // 
            // EditOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1384, 711);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelEditOrder);
            this.Controls.Add(this.textBoxClientID);
            this.Controls.Add(this.labelOrderID);
            this.Controls.Add(this.buttonSaveOrder);
            this.Controls.Add(this.dataEditOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Order";
            ((System.ComponentModel.ISupportInitialize)(this.dataEditOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEditOrder;
        private System.Windows.Forms.TextBox textBoxClientID;
        private System.Windows.Forms.Label labelOrderID;
        private System.Windows.Forms.Button buttonSaveOrder;
        private System.Windows.Forms.DataGridView dataEditOrder;
        private System.Windows.Forms.TextBox textBox1;
    }
}