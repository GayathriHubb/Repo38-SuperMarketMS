namespace SuperMarketMS
{
    partial class UCCategories
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
            this.Gn2GrdPnl2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.DGVCategories = new System.Windows.Forms.DataGridView();
            this.LbAdmin = new System.Windows.Forms.Label();
            this.Gn2GrdPnl1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.Gn2BtnClr = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Gn2BtnDel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Gn2BtnUpd = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Gn2GBtnIns = new Guna.UI2.WinForms.Guna2GradientButton();
            this.CmbBxStatus = new System.Windows.Forms.ComboBox();
            this.Gn2TBCatName = new Guna.UI2.WinForms.Guna2TextBox();
            this.Gn2TBCatId = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Gn2GrdPnl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCategories)).BeginInit();
            this.Gn2GrdPnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gn2GrdPnl2
            // 
            this.Gn2GrdPnl2.Controls.Add(this.DGVCategories);
            this.Gn2GrdPnl2.Controls.Add(this.LbAdmin);
            this.Gn2GrdPnl2.FillColor = System.Drawing.Color.DarkOliveGreen;
            this.Gn2GrdPnl2.FillColor2 = System.Drawing.Color.YellowGreen;
            this.Gn2GrdPnl2.Location = new System.Drawing.Point(10, 259);
            this.Gn2GrdPnl2.Name = "Gn2GrdPnl2";
            this.Gn2GrdPnl2.Size = new System.Drawing.Size(880, 402);
            this.Gn2GrdPnl2.TabIndex = 1;
            // 
            // DGVCategories
            // 
            this.DGVCategories.AllowUserToAddRows = false;
            this.DGVCategories.AllowUserToDeleteRows = false;
            this.DGVCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVCategories.BackgroundColor = System.Drawing.Color.LightGray;
            this.DGVCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Olive;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVCategories.ColumnHeadersHeight = 34;
            this.DGVCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGVCategories.EnableHeadersVisualStyles = false;
            this.DGVCategories.Location = new System.Drawing.Point(5, 45);
            this.DGVCategories.Name = "DGVCategories";
            this.DGVCategories.ReadOnly = true;
            this.DGVCategories.RowHeadersWidth = 40;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.DGVCategories.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVCategories.RowTemplate.Height = 28;
            this.DGVCategories.Size = new System.Drawing.Size(870, 345);
            this.DGVCategories.TabIndex = 13;
            this.DGVCategories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCategories_CellClick);
            // 
            // LbAdmin
            // 
            this.LbAdmin.AutoSize = true;
            this.LbAdmin.BackColor = System.Drawing.Color.Transparent;
            this.LbAdmin.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbAdmin.ForeColor = System.Drawing.Color.SeaShell;
            this.LbAdmin.Location = new System.Drawing.Point(10, 11);
            this.LbAdmin.Name = "LbAdmin";
            this.LbAdmin.Size = new System.Drawing.Size(142, 24);
            this.LbAdmin.TabIndex = 11;
            this.LbAdmin.Text = "All Categories";
            this.LbAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Gn2GrdPnl1
            // 
            this.Gn2GrdPnl1.Controls.Add(this.label2);
            this.Gn2GrdPnl1.Controls.Add(this.Gn2BtnClr);
            this.Gn2GrdPnl1.Controls.Add(this.Gn2BtnDel);
            this.Gn2GrdPnl1.Controls.Add(this.Gn2BtnUpd);
            this.Gn2GrdPnl1.Controls.Add(this.Gn2GBtnIns);
            this.Gn2GrdPnl1.Controls.Add(this.CmbBxStatus);
            this.Gn2GrdPnl1.Controls.Add(this.Gn2TBCatName);
            this.Gn2GrdPnl1.Controls.Add(this.Gn2TBCatId);
            this.Gn2GrdPnl1.Controls.Add(this.label6);
            this.Gn2GrdPnl1.Controls.Add(this.label4);
            this.Gn2GrdPnl1.Controls.Add(this.label1);
            this.Gn2GrdPnl1.FillColor = System.Drawing.Color.DarkOliveGreen;
            this.Gn2GrdPnl1.FillColor2 = System.Drawing.Color.YellowGreen;
            this.Gn2GrdPnl1.Location = new System.Drawing.Point(10, 9);
            this.Gn2GrdPnl1.Name = "Gn2GrdPnl1";
            this.Gn2GrdPnl1.Size = new System.Drawing.Size(880, 240);
            this.Gn2GrdPnl1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.PaleGreen;
            this.label2.Location = new System.Drawing.Point(20, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "Fill Category Info";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Gn2BtnClr
            // 
            this.Gn2BtnClr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Gn2BtnClr.Animated = true;
            this.Gn2BtnClr.BackColor = System.Drawing.Color.Transparent;
            this.Gn2BtnClr.BorderRadius = 10;
            this.Gn2BtnClr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gn2BtnClr.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnClr.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnClr.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2BtnClr.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2BtnClr.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gn2BtnClr.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(0)))));
            this.Gn2BtnClr.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Gn2BtnClr.Font = new System.Drawing.Font("Gadugi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gn2BtnClr.ForeColor = System.Drawing.Color.White;
            this.Gn2BtnClr.Location = new System.Drawing.Point(670, 147);
            this.Gn2BtnClr.Name = "Gn2BtnClr";
            this.Gn2BtnClr.Size = new System.Drawing.Size(140, 35);
            this.Gn2BtnClr.TabIndex = 36;
            this.Gn2BtnClr.Text = "Clear";
            this.Gn2BtnClr.Click += new System.EventHandler(this.Gn2BtnClr_Click);
            // 
            // Gn2BtnDel
            // 
            this.Gn2BtnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Gn2BtnDel.Animated = true;
            this.Gn2BtnDel.BackColor = System.Drawing.Color.Transparent;
            this.Gn2BtnDel.BorderRadius = 10;
            this.Gn2BtnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gn2BtnDel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnDel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnDel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2BtnDel.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2BtnDel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gn2BtnDel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(0)))));
            this.Gn2BtnDel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Gn2BtnDel.Font = new System.Drawing.Font("Gadugi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gn2BtnDel.ForeColor = System.Drawing.Color.White;
            this.Gn2BtnDel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Gn2BtnDel.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Gn2BtnDel.Location = new System.Drawing.Point(516, 147);
            this.Gn2BtnDel.Name = "Gn2BtnDel";
            this.Gn2BtnDel.Size = new System.Drawing.Size(140, 35);
            this.Gn2BtnDel.TabIndex = 35;
            this.Gn2BtnDel.Text = "Delete";
            this.Gn2BtnDel.Click += new System.EventHandler(this.Gn2BtnDel_Click);
            // 
            // Gn2BtnUpd
            // 
            this.Gn2BtnUpd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Gn2BtnUpd.Animated = true;
            this.Gn2BtnUpd.BackColor = System.Drawing.Color.Transparent;
            this.Gn2BtnUpd.BorderRadius = 10;
            this.Gn2BtnUpd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gn2BtnUpd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnUpd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnUpd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2BtnUpd.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2BtnUpd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gn2BtnUpd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(0)))));
            this.Gn2BtnUpd.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Gn2BtnUpd.Font = new System.Drawing.Font("Gadugi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gn2BtnUpd.ForeColor = System.Drawing.Color.White;
            this.Gn2BtnUpd.Location = new System.Drawing.Point(670, 69);
            this.Gn2BtnUpd.Name = "Gn2BtnUpd";
            this.Gn2BtnUpd.Size = new System.Drawing.Size(140, 35);
            this.Gn2BtnUpd.TabIndex = 34;
            this.Gn2BtnUpd.Text = "Update";
            this.Gn2BtnUpd.Click += new System.EventHandler(this.Gn2BtnUpd_Click);
            // 
            // Gn2GBtnIns
            // 
            this.Gn2GBtnIns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Gn2GBtnIns.Animated = true;
            this.Gn2GBtnIns.BackColor = System.Drawing.Color.Transparent;
            this.Gn2GBtnIns.BorderRadius = 10;
            this.Gn2GBtnIns.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gn2GBtnIns.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gn2GBtnIns.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gn2GBtnIns.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2GBtnIns.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2GBtnIns.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gn2GBtnIns.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(0)))));
            this.Gn2GBtnIns.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Gn2GBtnIns.Font = new System.Drawing.Font("Gadugi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gn2GBtnIns.ForeColor = System.Drawing.Color.White;
            this.Gn2GBtnIns.Location = new System.Drawing.Point(516, 69);
            this.Gn2GBtnIns.Name = "Gn2GBtnIns";
            this.Gn2GBtnIns.Size = new System.Drawing.Size(140, 35);
            this.Gn2GBtnIns.TabIndex = 33;
            this.Gn2GBtnIns.Text = "Insert";
            this.Gn2GBtnIns.Click += new System.EventHandler(this.Gn2GBtnIns_Click);
            // 
            // CmbBxStatus
            // 
            this.CmbBxStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxStatus.FormattingEnabled = true;
            this.CmbBxStatus.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.CmbBxStatus.Location = new System.Drawing.Point(161, 168);
            this.CmbBxStatus.Name = "CmbBxStatus";
            this.CmbBxStatus.Size = new System.Drawing.Size(232, 33);
            this.CmbBxStatus.TabIndex = 32;
            // 
            // Gn2TBCatName
            // 
            this.Gn2TBCatName.Animated = true;
            this.Gn2TBCatName.BackColor = System.Drawing.Color.Transparent;
            this.Gn2TBCatName.BorderRadius = 10;
            this.Gn2TBCatName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Gn2TBCatName.DefaultText = "";
            this.Gn2TBCatName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Gn2TBCatName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Gn2TBCatName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Gn2TBCatName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Gn2TBCatName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Gn2TBCatName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.Gn2TBCatName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Gn2TBCatName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Gn2TBCatName.Location = new System.Drawing.Point(161, 115);
            this.Gn2TBCatName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Gn2TBCatName.Name = "Gn2TBCatName";
            this.Gn2TBCatName.PlaceholderText = "";
            this.Gn2TBCatName.SelectedText = "";
            this.Gn2TBCatName.Size = new System.Drawing.Size(300, 35);
            this.Gn2TBCatName.TabIndex = 29;
            // 
            // Gn2TBCatId
            // 
            this.Gn2TBCatId.Animated = true;
            this.Gn2TBCatId.BackColor = System.Drawing.Color.Transparent;
            this.Gn2TBCatId.BorderRadius = 10;
            this.Gn2TBCatId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Gn2TBCatId.DefaultText = "";
            this.Gn2TBCatId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Gn2TBCatId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Gn2TBCatId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Gn2TBCatId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Gn2TBCatId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Gn2TBCatId.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.Gn2TBCatId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Gn2TBCatId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Gn2TBCatId.Location = new System.Drawing.Point(161, 62);
            this.Gn2TBCatId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Gn2TBCatId.Name = "Gn2TBCatId";
            this.Gn2TBCatId.PlaceholderText = "";
            this.Gn2TBCatId.SelectedText = "";
            this.Gn2TBCatId.Size = new System.Drawing.Size(220, 35);
            this.Gn2TBCatId.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.SeaShell;
            this.label6.Location = new System.Drawing.Point(20, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "CategoryName";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.SeaShell;
            this.label4.Location = new System.Drawing.Point(20, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Status";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SeaShell;
            this.label1.Location = new System.Drawing.Point(20, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Category Id";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UCCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Gn2GrdPnl2);
            this.Controls.Add(this.Gn2GrdPnl1);
            this.Name = "UCCategories";
            this.Size = new System.Drawing.Size(900, 670);
            this.Load += new System.EventHandler(this.UCCategories_Load);
            this.Gn2GrdPnl2.ResumeLayout(false);
            this.Gn2GrdPnl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCategories)).EndInit();
            this.Gn2GrdPnl1.ResumeLayout(false);
            this.Gn2GrdPnl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LbAdmin;
        private Guna.UI2.WinForms.Guna2GradientButton Gn2BtnClr;
        private Guna.UI2.WinForms.Guna2GradientButton Gn2BtnDel;
        private Guna.UI2.WinForms.Guna2GradientButton Gn2BtnUpd;
        private Guna.UI2.WinForms.Guna2GradientButton Gn2GBtnIns;
        private System.Windows.Forms.ComboBox CmbBxStatus;
        private Guna.UI2.WinForms.Guna2TextBox Gn2TBCatName;
        private Guna.UI2.WinForms.Guna2TextBox Gn2TBCatId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGVCategories;
        public Guna.UI2.WinForms.Guna2GradientPanel Gn2GrdPnl2;
        public Guna.UI2.WinForms.Guna2GradientPanel Gn2GrdPnl1;
    }
}
