namespace SuperMarketMS
{
    partial class UCOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCOrders));
            this.FLP1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Gn2GrdPnl1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.Gn2BtnClear = new Guna.UI2.WinForms.Guna2GradientButton();
            this.DGVOrders = new System.Windows.Forms.DataGridView();
            this.Col1CustId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col2Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col3Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col4Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col5Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col6Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col7PdId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LbOrders = new System.Windows.Forms.Label();
            this.Gn2TBChange = new Guna.UI2.WinForms.Guna2TextBox();
            this.Gn2TBAmnt = new Guna.UI2.WinForms.Guna2TextBox();
            this.Gn2TBTP = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Gn2BtnReceipt = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Gn2BtnRemove = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Gn2GBtnPO = new Guna.UI2.WinForms.Guna2GradientButton();
            this.PD1 = new System.Drawing.Printing.PrintDocument();
            this.PPD1 = new System.Windows.Forms.PrintPreviewDialog();
            this.Gn2GrdPnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // FLP1
            // 
            this.FLP1.AutoScroll = true;
            this.FLP1.BackColor = System.Drawing.Color.Olive;
            this.FLP1.Location = new System.Drawing.Point(10, 5);
            this.FLP1.Name = "FLP1";
            this.FLP1.Size = new System.Drawing.Size(880, 345);
            this.FLP1.TabIndex = 0;
            // 
            // Gn2GrdPnl1
            // 
            this.Gn2GrdPnl1.Controls.Add(this.Gn2BtnClear);
            this.Gn2GrdPnl1.Controls.Add(this.DGVOrders);
            this.Gn2GrdPnl1.Controls.Add(this.LbOrders);
            this.Gn2GrdPnl1.Controls.Add(this.Gn2TBChange);
            this.Gn2GrdPnl1.Controls.Add(this.Gn2TBAmnt);
            this.Gn2GrdPnl1.Controls.Add(this.Gn2TBTP);
            this.Gn2GrdPnl1.Controls.Add(this.label3);
            this.Gn2GrdPnl1.Controls.Add(this.label2);
            this.Gn2GrdPnl1.Controls.Add(this.label1);
            this.Gn2GrdPnl1.Controls.Add(this.Gn2BtnReceipt);
            this.Gn2GrdPnl1.Controls.Add(this.Gn2BtnRemove);
            this.Gn2GrdPnl1.Controls.Add(this.Gn2GBtnPO);
            this.Gn2GrdPnl1.FillColor = System.Drawing.Color.DarkOliveGreen;
            this.Gn2GrdPnl1.FillColor2 = System.Drawing.Color.YellowGreen;
            this.Gn2GrdPnl1.Location = new System.Drawing.Point(10, 355);
            this.Gn2GrdPnl1.Name = "Gn2GrdPnl1";
            this.Gn2GrdPnl1.Size = new System.Drawing.Size(880, 300);
            this.Gn2GrdPnl1.TabIndex = 0;
            // 
            // Gn2BtnClear
            // 
            this.Gn2BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Gn2BtnClear.BackColor = System.Drawing.Color.Transparent;
            this.Gn2BtnClear.BorderRadius = 10;
            this.Gn2BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gn2BtnClear.DefaultAutoSize = true;
            this.Gn2BtnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2BtnClear.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2BtnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gn2BtnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(0)))));
            this.Gn2BtnClear.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Gn2BtnClear.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gn2BtnClear.ForeColor = System.Drawing.Color.White;
            this.Gn2BtnClear.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Gn2BtnClear.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Gn2BtnClear.Location = new System.Drawing.Point(730, 208);
            this.Gn2BtnClear.Name = "Gn2BtnClear";
            this.Gn2BtnClear.Size = new System.Drawing.Size(70, 33);
            this.Gn2BtnClear.TabIndex = 33;
            this.Gn2BtnClear.Text = "Clear";
            this.Gn2BtnClear.Click += new System.EventHandler(this.Gn2BtnClear_Click);
            // 
            // DGVOrders
            // 
            this.DGVOrders.AllowUserToAddRows = false;
            this.DGVOrders.BackgroundColor = System.Drawing.Color.LightGray;
            this.DGVOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Olive;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVOrders.ColumnHeadersHeight = 34;
            this.DGVOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col1CustId,
            this.Col2Id,
            this.Col3Name,
            this.Col4Brand,
            this.Col5Qty,
            this.Col6Price,
            this.Col7PdId});
            this.DGVOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGVOrders.EnableHeadersVisualStyles = false;
            this.DGVOrders.Location = new System.Drawing.Point(5, 40);
            this.DGVOrders.Name = "DGVOrders";
            this.DGVOrders.ReadOnly = true;
            this.DGVOrders.RowHeadersWidth = 40;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.DGVOrders.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVOrders.RowTemplate.Height = 28;
            this.DGVOrders.Size = new System.Drawing.Size(500, 250);
            this.DGVOrders.TabIndex = 32;
            this.DGVOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVOrders_CellClick);
            // 
            // Col1CustId
            // 
            this.Col1CustId.HeaderText = "CustId";
            this.Col1CustId.MinimumWidth = 8;
            this.Col1CustId.Name = "Col1CustId";
            this.Col1CustId.ReadOnly = true;
            this.Col1CustId.Width = 150;
            // 
            // Col2Id
            // 
            this.Col2Id.HeaderText = "Id";
            this.Col2Id.MinimumWidth = 8;
            this.Col2Id.Name = "Col2Id";
            this.Col2Id.ReadOnly = true;
            this.Col2Id.Width = 150;
            // 
            // Col3Name
            // 
            this.Col3Name.HeaderText = "ProdName";
            this.Col3Name.MinimumWidth = 8;
            this.Col3Name.Name = "Col3Name";
            this.Col3Name.ReadOnly = true;
            this.Col3Name.Width = 150;
            // 
            // Col4Brand
            // 
            this.Col4Brand.HeaderText = "Brand";
            this.Col4Brand.MinimumWidth = 8;
            this.Col4Brand.Name = "Col4Brand";
            this.Col4Brand.ReadOnly = true;
            this.Col4Brand.Width = 150;
            // 
            // Col5Qty
            // 
            this.Col5Qty.HeaderText = "Qty";
            this.Col5Qty.MinimumWidth = 8;
            this.Col5Qty.Name = "Col5Qty";
            this.Col5Qty.ReadOnly = true;
            this.Col5Qty.Width = 150;
            // 
            // Col6Price
            // 
            this.Col6Price.HeaderText = "Price";
            this.Col6Price.MinimumWidth = 8;
            this.Col6Price.Name = "Col6Price";
            this.Col6Price.ReadOnly = true;
            this.Col6Price.Width = 150;
            // 
            // Col7PdId
            // 
            this.Col7PdId.HeaderText = "PdId";
            this.Col7PdId.MinimumWidth = 8;
            this.Col7PdId.Name = "Col7PdId";
            this.Col7PdId.ReadOnly = true;
            this.Col7PdId.Visible = false;
            this.Col7PdId.Width = 150;
            // 
            // LbOrders
            // 
            this.LbOrders.AutoSize = true;
            this.LbOrders.BackColor = System.Drawing.Color.Transparent;
            this.LbOrders.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold);
            this.LbOrders.ForeColor = System.Drawing.Color.SeaShell;
            this.LbOrders.Location = new System.Drawing.Point(3, 12);
            this.LbOrders.Name = "LbOrders";
            this.LbOrders.Size = new System.Drawing.Size(67, 21);
            this.LbOrders.TabIndex = 31;
            this.LbOrders.Text = "Orders";
            this.LbOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Gn2TBChange
            // 
            this.Gn2TBChange.Animated = true;
            this.Gn2TBChange.BackColor = System.Drawing.Color.Transparent;
            this.Gn2TBChange.BorderRadius = 10;
            this.Gn2TBChange.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Gn2TBChange.DefaultText = "";
            this.Gn2TBChange.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Gn2TBChange.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Gn2TBChange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Gn2TBChange.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Gn2TBChange.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Gn2TBChange.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.Gn2TBChange.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Gn2TBChange.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Gn2TBChange.Location = new System.Drawing.Point(640, 157);
            this.Gn2TBChange.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Gn2TBChange.Name = "Gn2TBChange";
            this.Gn2TBChange.PlaceholderText = "";
            this.Gn2TBChange.SelectedText = "";
            this.Gn2TBChange.Size = new System.Drawing.Size(220, 35);
            this.Gn2TBChange.TabIndex = 30;
            // 
            // Gn2TBAmnt
            // 
            this.Gn2TBAmnt.Animated = true;
            this.Gn2TBAmnt.BackColor = System.Drawing.Color.Transparent;
            this.Gn2TBAmnt.BorderRadius = 10;
            this.Gn2TBAmnt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Gn2TBAmnt.DefaultText = "";
            this.Gn2TBAmnt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Gn2TBAmnt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Gn2TBAmnt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Gn2TBAmnt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Gn2TBAmnt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Gn2TBAmnt.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.Gn2TBAmnt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Gn2TBAmnt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Gn2TBAmnt.Location = new System.Drawing.Point(640, 101);
            this.Gn2TBAmnt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Gn2TBAmnt.Name = "Gn2TBAmnt";
            this.Gn2TBAmnt.PlaceholderText = "";
            this.Gn2TBAmnt.SelectedText = "";
            this.Gn2TBAmnt.Size = new System.Drawing.Size(220, 35);
            this.Gn2TBAmnt.TabIndex = 29;
            this.Gn2TBAmnt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Gn2TBAmnt_KeyDown);
            // 
            // Gn2TBTP
            // 
            this.Gn2TBTP.Animated = true;
            this.Gn2TBTP.BackColor = System.Drawing.Color.Transparent;
            this.Gn2TBTP.BorderRadius = 10;
            this.Gn2TBTP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Gn2TBTP.DefaultText = "";
            this.Gn2TBTP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Gn2TBTP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Gn2TBTP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Gn2TBTP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Gn2TBTP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Gn2TBTP.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.Gn2TBTP.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Gn2TBTP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Gn2TBTP.Location = new System.Drawing.Point(640, 45);
            this.Gn2TBTP.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Gn2TBTP.Name = "Gn2TBTP";
            this.Gn2TBTP.PlaceholderText = "";
            this.Gn2TBTP.SelectedText = "";
            this.Gn2TBTP.Size = new System.Drawing.Size(220, 35);
            this.Gn2TBTP.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(512, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "Change";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(512, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "Amount";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(512, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "TotalPrice(₹)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Gn2BtnReceipt
            // 
            this.Gn2BtnReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Gn2BtnReceipt.BackColor = System.Drawing.Color.Transparent;
            this.Gn2BtnReceipt.BorderRadius = 10;
            this.Gn2BtnReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gn2BtnReceipt.DefaultAutoSize = true;
            this.Gn2BtnReceipt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnReceipt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnReceipt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2BtnReceipt.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2BtnReceipt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gn2BtnReceipt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(0)))));
            this.Gn2BtnReceipt.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Gn2BtnReceipt.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold);
            this.Gn2BtnReceipt.ForeColor = System.Drawing.Color.White;
            this.Gn2BtnReceipt.Location = new System.Drawing.Point(730, 252);
            this.Gn2BtnReceipt.Name = "Gn2BtnReceipt";
            this.Gn2BtnReceipt.Size = new System.Drawing.Size(89, 33);
            this.Gn2BtnReceipt.TabIndex = 24;
            this.Gn2BtnReceipt.Text = "Receipt";
            this.Gn2BtnReceipt.Click += new System.EventHandler(this.Gn2BtnReceipt_Click);
            // 
            // Gn2BtnRemove
            // 
            this.Gn2BtnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Gn2BtnRemove.BackColor = System.Drawing.Color.Transparent;
            this.Gn2BtnRemove.BorderRadius = 10;
            this.Gn2BtnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gn2BtnRemove.DefaultAutoSize = true;
            this.Gn2BtnRemove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnRemove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnRemove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2BtnRemove.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2BtnRemove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gn2BtnRemove.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(0)))));
            this.Gn2BtnRemove.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Gn2BtnRemove.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gn2BtnRemove.ForeColor = System.Drawing.Color.White;
            this.Gn2BtnRemove.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Gn2BtnRemove.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Gn2BtnRemove.Location = new System.Drawing.Point(540, 208);
            this.Gn2BtnRemove.Name = "Gn2BtnRemove";
            this.Gn2BtnRemove.Size = new System.Drawing.Size(94, 33);
            this.Gn2BtnRemove.TabIndex = 23;
            this.Gn2BtnRemove.Text = "Remove";
            this.Gn2BtnRemove.Click += new System.EventHandler(this.Gn2BtnReomve_Click);
            // 
            // Gn2GBtnPO
            // 
            this.Gn2GBtnPO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Gn2GBtnPO.BackColor = System.Drawing.Color.Transparent;
            this.Gn2GBtnPO.BorderRadius = 10;
            this.Gn2GBtnPO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gn2GBtnPO.DefaultAutoSize = true;
            this.Gn2GBtnPO.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gn2GBtnPO.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gn2GBtnPO.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2GBtnPO.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2GBtnPO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gn2GBtnPO.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(0)))));
            this.Gn2GBtnPO.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Gn2GBtnPO.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold);
            this.Gn2GBtnPO.ForeColor = System.Drawing.Color.White;
            this.Gn2GBtnPO.Location = new System.Drawing.Point(540, 252);
            this.Gn2GBtnPO.Name = "Gn2GBtnPO";
            this.Gn2GBtnPO.Size = new System.Drawing.Size(121, 33);
            this.Gn2GBtnPO.TabIndex = 22;
            this.Gn2GBtnPO.Text = "Place Order";
            this.Gn2GBtnPO.Click += new System.EventHandler(this.Gn2GBtnPO_Click);
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
            // UCOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Gn2GrdPnl1);
            this.Controls.Add(this.FLP1);
            this.Name = "UCOrders";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(900, 670);
            this.Load += new System.EventHandler(this.UCOrders_Load);
            this.Gn2GrdPnl1.ResumeLayout(false);
            this.Gn2GrdPnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientButton Gn2BtnReceipt;
        private Guna.UI2.WinForms.Guna2GradientButton Gn2BtnRemove;
        private Guna.UI2.WinForms.Guna2GradientButton Gn2GBtnPO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox Gn2TBChange;
        private Guna.UI2.WinForms.Guna2TextBox Gn2TBAmnt;
        private Guna.UI2.WinForms.Guna2TextBox Gn2TBTP;
        private System.Windows.Forms.Label LbOrders;
        private System.Drawing.Printing.PrintDocument PD1;
        private System.Windows.Forms.PrintPreviewDialog PPD1;
        private System.Windows.Forms.DataGridView DGVOrders;
        private Guna.UI2.WinForms.Guna2GradientButton Gn2BtnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1CustId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col3Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col4Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col5Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col6Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col7PdId;
        public System.Windows.Forms.FlowLayoutPanel FLP1;
        public Guna.UI2.WinForms.Guna2GradientPanel Gn2GrdPnl1;
    }
}
