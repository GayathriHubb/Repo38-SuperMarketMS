namespace SuperMarketMS
{
    partial class UCCustomers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCustomers));
            this.Gn2GP1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.DGVCustms = new System.Windows.Forms.DataGridView();
            this.Gn2BtnReceipt = new Guna.UI2.WinForms.Guna2Button();
            this.LbAdmin = new System.Windows.Forms.Label();
            this.PD1 = new System.Drawing.Printing.PrintDocument();
            this.PPD1 = new System.Windows.Forms.PrintPreviewDialog();
            this.Gn2GP1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustms)).BeginInit();
            this.SuspendLayout();
            // 
            // Gn2GP1
            // 
            this.Gn2GP1.Controls.Add(this.DGVCustms);
            this.Gn2GP1.Controls.Add(this.Gn2BtnReceipt);
            this.Gn2GP1.Controls.Add(this.LbAdmin);
            this.Gn2GP1.FillColor = System.Drawing.Color.DarkOliveGreen;
            this.Gn2GP1.FillColor2 = System.Drawing.Color.YellowGreen;
            this.Gn2GP1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.Gn2GP1.Location = new System.Drawing.Point(10, 10);
            this.Gn2GP1.Name = "Gn2GP1";
            this.Gn2GP1.Size = new System.Drawing.Size(880, 650);
            this.Gn2GP1.TabIndex = 0;
            // 
            // DGVCustms
            // 
            this.DGVCustms.AllowUserToAddRows = false;
            this.DGVCustms.AllowUserToDeleteRows = false;
            this.DGVCustms.BackgroundColor = System.Drawing.Color.LightGray;
            this.DGVCustms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Olive;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVCustms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVCustms.ColumnHeadersHeight = 34;
            this.DGVCustms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVCustms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGVCustms.EnableHeadersVisualStyles = false;
            this.DGVCustms.Location = new System.Drawing.Point(5, 45);
            this.DGVCustms.Name = "DGVCustms";
            this.DGVCustms.ReadOnly = true;
            this.DGVCustms.RowHeadersWidth = 40;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.DGVCustms.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVCustms.RowTemplate.Height = 28;
            this.DGVCustms.Size = new System.Drawing.Size(870, 540);
            this.DGVCustms.TabIndex = 15;
            this.DGVCustms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCustms_CellClick);
            // 
            // Gn2BtnReceipt
            // 
            this.Gn2BtnReceipt.Animated = true;
            this.Gn2BtnReceipt.BackColor = System.Drawing.Color.Transparent;
            this.Gn2BtnReceipt.BorderRadius = 10;
            this.Gn2BtnReceipt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnReceipt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnReceipt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2BtnReceipt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gn2BtnReceipt.FillColor = System.Drawing.Color.Olive;
            this.Gn2BtnReceipt.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.Gn2BtnReceipt.ForeColor = System.Drawing.Color.White;
            this.Gn2BtnReceipt.Location = new System.Drawing.Point(365, 595);
            this.Gn2BtnReceipt.Name = "Gn2BtnReceipt";
            this.Gn2BtnReceipt.Size = new System.Drawing.Size(150, 40);
            this.Gn2BtnReceipt.TabIndex = 11;
            this.Gn2BtnReceipt.Text = "Receipt";
            this.Gn2BtnReceipt.Click += new System.EventHandler(this.Gn2BtnReceipt_Click);
            // 
            // LbAdmin
            // 
            this.LbAdmin.AutoSize = true;
            this.LbAdmin.BackColor = System.Drawing.Color.Transparent;
            this.LbAdmin.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbAdmin.ForeColor = System.Drawing.Color.SeaShell;
            this.LbAdmin.Location = new System.Drawing.Point(5, 10);
            this.LbAdmin.Name = "LbAdmin";
            this.LbAdmin.Size = new System.Drawing.Size(141, 24);
            this.LbAdmin.TabIndex = 10;
            this.LbAdmin.Text = "All Customers";
            this.LbAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PD1
            // 
            this.PD1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PD1_PrintPage);
            // 
            // PPD1
            // 
            this.PPD1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PPD1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PPD1.ClientSize = new System.Drawing.Size(400, 300);
            this.PPD1.Document = this.PD1;
            this.PPD1.Enabled = true;
            this.PPD1.Icon = ((System.Drawing.Icon)(resources.GetObject("PPD1.Icon")));
            this.PPD1.Name = "PPD1";
            this.PPD1.Visible = false;
            // 
            // UCCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Gn2GP1);
            this.Name = "UCCustomers";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(900, 670);
            this.Load += new System.EventHandler(this.UCCustomers_Load);
            this.Gn2GP1.ResumeLayout(false);
            this.Gn2GP1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button Gn2BtnReceipt;
        private System.Windows.Forms.Label LbAdmin;
        private System.Drawing.Printing.PrintDocument PD1;
        private System.Windows.Forms.PrintPreviewDialog PPD1;
        private System.Windows.Forms.DataGridView DGVCustms;
        public Guna.UI2.WinForms.Guna2GradientPanel Gn2GP1;
    }
}
