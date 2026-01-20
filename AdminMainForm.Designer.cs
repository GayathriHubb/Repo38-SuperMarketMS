namespace SuperMarketMS
{
    partial class AdminMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainForm));
            this.Gn2Pnl1 = new Guna.UI2.WinForms.Guna2Panel();
            this.LbHeading = new System.Windows.Forms.Label();
            this.Gn2CBMin = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Gn2CBClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Gn2Pnl2 = new Guna.UI2.WinForms.Guna2Panel();
            this.Gn2BtnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.LbUser = new System.Windows.Forms.Label();
            this.LbAdmin = new System.Windows.Forms.Label();
            this.Gn2BtnCustms = new Guna.UI2.WinForms.Guna2Button();
            this.Gn2BtnProds = new Guna.UI2.WinForms.Guna2Button();
            this.Gn2BtnCategories = new Guna.UI2.WinForms.Guna2Button();
            this.Gn2BtnStaff = new Guna.UI2.WinForms.Guna2Button();
            this.Gn2BtnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.Gn2PB1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Gn2DC1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Gn2MD1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.Gn2MD2 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.Gn2AW1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.Pnl3 = new System.Windows.Forms.Panel();
            this.UCDashboard1 = new SuperMarketMS.UCDashboard();
            this.UCStaff1 = new SuperMarketMS.UCStaff();
            this.UCCategories1 = new SuperMarketMS.UCCategories();
            this.UCProducts1 = new SuperMarketMS.UCProducts();
            this.UCCustomers1 = new SuperMarketMS.UCCustomers();
            this.Gn2TglSwtch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.LbThShd = new System.Windows.Forms.Label();
            this.LbTheme = new System.Windows.Forms.Label();
            this.Gn2Pnl1.SuspendLayout();
            this.Gn2Pnl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gn2PB1)).BeginInit();
            this.Pnl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gn2Pnl1
            // 
            this.Gn2Pnl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gn2Pnl1.Controls.Add(this.LbHeading);
            this.Gn2Pnl1.Controls.Add(this.Gn2CBMin);
            this.Gn2Pnl1.Controls.Add(this.Gn2CBClose);
            this.Gn2Pnl1.FillColor = System.Drawing.Color.DarkOliveGreen;
            this.Gn2Pnl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gn2Pnl1.Location = new System.Drawing.Point(0, 0);
            this.Gn2Pnl1.Name = "Gn2Pnl1";
            this.Gn2Pnl1.Size = new System.Drawing.Size(1200, 30);
            this.Gn2Pnl1.TabIndex = 0;
            // 
            // LbHeading
            // 
            this.LbHeading.AutoSize = true;
            this.LbHeading.BackColor = System.Drawing.Color.Transparent;
            this.LbHeading.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHeading.ForeColor = System.Drawing.Color.SeaShell;
            this.LbHeading.Location = new System.Drawing.Point(2, 5);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(368, 25);
            this.LbHeading.TabIndex = 2;
            this.LbHeading.Text = "SuperMarket Management | Admin Portal";
            this.LbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Gn2CBMin
            // 
            this.Gn2CBMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Gn2CBMin.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.Gn2CBMin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.Gn2CBMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gn2CBMin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Gn2CBMin.IconColor = System.Drawing.Color.White;
            this.Gn2CBMin.Location = new System.Drawing.Point(1129, 2);
            this.Gn2CBMin.Name = "Gn2CBMin";
            this.Gn2CBMin.Size = new System.Drawing.Size(25, 25);
            this.Gn2CBMin.TabIndex = 1;
            // 
            // Gn2CBClose
            // 
            this.Gn2CBClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Gn2CBClose.Animated = true;
            this.Gn2CBClose.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.Gn2CBClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gn2CBClose.CustomClick = true;
            this.Gn2CBClose.FillColor = System.Drawing.Color.IndianRed;
            this.Gn2CBClose.IconColor = System.Drawing.Color.White;
            this.Gn2CBClose.Location = new System.Drawing.Point(1160, 2);
            this.Gn2CBClose.Name = "Gn2CBClose";
            this.Gn2CBClose.Size = new System.Drawing.Size(25, 25);
            this.Gn2CBClose.TabIndex = 0;
            this.Gn2CBClose.Click += new System.EventHandler(this.Gn2CBClose_Click);
            // 
            // Gn2Pnl2
            // 
            this.Gn2Pnl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Gn2Pnl2.Controls.Add(this.LbTheme);
            this.Gn2Pnl2.Controls.Add(this.LbThShd);
            this.Gn2Pnl2.Controls.Add(this.Gn2TglSwtch);
            this.Gn2Pnl2.Controls.Add(this.Gn2BtnLogout);
            this.Gn2Pnl2.Controls.Add(this.LbUser);
            this.Gn2Pnl2.Controls.Add(this.LbAdmin);
            this.Gn2Pnl2.Controls.Add(this.Gn2BtnCustms);
            this.Gn2Pnl2.Controls.Add(this.Gn2BtnProds);
            this.Gn2Pnl2.Controls.Add(this.Gn2BtnCategories);
            this.Gn2Pnl2.Controls.Add(this.Gn2BtnStaff);
            this.Gn2Pnl2.Controls.Add(this.Gn2BtnDashboard);
            this.Gn2Pnl2.Controls.Add(this.Gn2PB1);
            this.Gn2Pnl2.FillColor = System.Drawing.Color.Olive;
            this.Gn2Pnl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gn2Pnl2.Location = new System.Drawing.Point(0, 30);
            this.Gn2Pnl2.Name = "Gn2Pnl2";
            this.Gn2Pnl2.Size = new System.Drawing.Size(300, 670);
            this.Gn2Pnl2.TabIndex = 1;
            // 
            // Gn2BtnLogout
            // 
            this.Gn2BtnLogout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Gn2BtnLogout.Animated = true;
            this.Gn2BtnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gn2BtnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2BtnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gn2BtnLogout.FillColor = System.Drawing.Color.DarkOliveGreen;
            this.Gn2BtnLogout.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gn2BtnLogout.ForeColor = System.Drawing.Color.White;
            this.Gn2BtnLogout.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Gn2BtnLogout.Image = global::SuperMarketMS.Properties.Resources.LogoutRounded;
            this.Gn2BtnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gn2BtnLogout.ImageOffset = new System.Drawing.Point(10, 0);
            this.Gn2BtnLogout.Location = new System.Drawing.Point(0, 600);
            this.Gn2BtnLogout.Name = "Gn2BtnLogout";
            this.Gn2BtnLogout.Size = new System.Drawing.Size(300, 45);
            this.Gn2BtnLogout.TabIndex = 10;
            this.Gn2BtnLogout.Text = "Logout";
            this.Gn2BtnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gn2BtnLogout.TextOffset = new System.Drawing.Point(30, 0);
            this.Gn2BtnLogout.Click += new System.EventHandler(this.Gn2BtnLogout_Click);
            // 
            // LbUser
            // 
            this.LbUser.AutoSize = true;
            this.LbUser.BackColor = System.Drawing.Color.Transparent;
            this.LbUser.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUser.ForeColor = System.Drawing.Color.SeaShell;
            this.LbUser.Location = new System.Drawing.Point(95, 128);
            this.LbUser.Name = "LbUser";
            this.LbUser.Size = new System.Drawing.Size(19, 24);
            this.LbUser.TabIndex = 9;
            this.LbUser.Text = "?";
            this.LbUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbAdmin
            // 
            this.LbAdmin.AutoSize = true;
            this.LbAdmin.BackColor = System.Drawing.Color.Transparent;
            this.LbAdmin.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbAdmin.ForeColor = System.Drawing.Color.SeaShell;
            this.LbAdmin.Location = new System.Drawing.Point(10, 128);
            this.LbAdmin.Name = "LbAdmin";
            this.LbAdmin.Size = new System.Drawing.Size(77, 24);
            this.LbAdmin.TabIndex = 8;
            this.LbAdmin.Text = "Admin:";
            this.LbAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Gn2BtnCustms
            // 
            this.Gn2BtnCustms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gn2BtnCustms.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnCustms.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnCustms.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2BtnCustms.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gn2BtnCustms.FillColor = System.Drawing.Color.DarkOliveGreen;
            this.Gn2BtnCustms.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gn2BtnCustms.ForeColor = System.Drawing.Color.White;
            this.Gn2BtnCustms.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Gn2BtnCustms.Image = global::SuperMarketMS.Properties.Resources.users;
            this.Gn2BtnCustms.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gn2BtnCustms.ImageOffset = new System.Drawing.Point(10, 0);
            this.Gn2BtnCustms.Location = new System.Drawing.Point(0, 436);
            this.Gn2BtnCustms.Name = "Gn2BtnCustms";
            this.Gn2BtnCustms.Size = new System.Drawing.Size(300, 45);
            this.Gn2BtnCustms.TabIndex = 6;
            this.Gn2BtnCustms.Tag = "MainBtns";
            this.Gn2BtnCustms.Text = "Customers";
            this.Gn2BtnCustms.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gn2BtnCustms.TextOffset = new System.Drawing.Point(30, 0);
            this.Gn2BtnCustms.Click += new System.EventHandler(this.MainBtns_Click);
            // 
            // Gn2BtnProds
            // 
            this.Gn2BtnProds.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gn2BtnProds.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnProds.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnProds.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2BtnProds.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gn2BtnProds.FillColor = System.Drawing.Color.DarkOliveGreen;
            this.Gn2BtnProds.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gn2BtnProds.ForeColor = System.Drawing.Color.White;
            this.Gn2BtnProds.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Gn2BtnProds.Image = global::SuperMarketMS.Properties.Resources.SquareChartGant;
            this.Gn2BtnProds.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gn2BtnProds.ImageOffset = new System.Drawing.Point(10, 0);
            this.Gn2BtnProds.Location = new System.Drawing.Point(0, 372);
            this.Gn2BtnProds.Name = "Gn2BtnProds";
            this.Gn2BtnProds.Size = new System.Drawing.Size(300, 45);
            this.Gn2BtnProds.TabIndex = 5;
            this.Gn2BtnProds.Tag = "MainBtns";
            this.Gn2BtnProds.Text = "Products";
            this.Gn2BtnProds.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gn2BtnProds.TextOffset = new System.Drawing.Point(30, 0);
            this.Gn2BtnProds.Click += new System.EventHandler(this.MainBtns_Click);
            // 
            // Gn2BtnCategories
            // 
            this.Gn2BtnCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gn2BtnCategories.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnCategories.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnCategories.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2BtnCategories.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gn2BtnCategories.FillColor = System.Drawing.Color.DarkOliveGreen;
            this.Gn2BtnCategories.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gn2BtnCategories.ForeColor = System.Drawing.Color.White;
            this.Gn2BtnCategories.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Gn2BtnCategories.Image = global::SuperMarketMS.Properties.Resources.CategorizeWhite;
            this.Gn2BtnCategories.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gn2BtnCategories.ImageOffset = new System.Drawing.Point(10, 0);
            this.Gn2BtnCategories.Location = new System.Drawing.Point(0, 308);
            this.Gn2BtnCategories.Name = "Gn2BtnCategories";
            this.Gn2BtnCategories.Size = new System.Drawing.Size(300, 45);
            this.Gn2BtnCategories.TabIndex = 4;
            this.Gn2BtnCategories.Tag = "MainBtns";
            this.Gn2BtnCategories.Text = "Categories";
            this.Gn2BtnCategories.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gn2BtnCategories.TextOffset = new System.Drawing.Point(30, 0);
            this.Gn2BtnCategories.Click += new System.EventHandler(this.MainBtns_Click);
            // 
            // Gn2BtnStaff
            // 
            this.Gn2BtnStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gn2BtnStaff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnStaff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2BtnStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gn2BtnStaff.FillColor = System.Drawing.Color.DarkOliveGreen;
            this.Gn2BtnStaff.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gn2BtnStaff.ForeColor = System.Drawing.Color.White;
            this.Gn2BtnStaff.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Gn2BtnStaff.Image = global::SuperMarketMS.Properties.Resources.GroupWhite;
            this.Gn2BtnStaff.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gn2BtnStaff.ImageOffset = new System.Drawing.Point(10, 0);
            this.Gn2BtnStaff.Location = new System.Drawing.Point(0, 244);
            this.Gn2BtnStaff.Name = "Gn2BtnStaff";
            this.Gn2BtnStaff.Size = new System.Drawing.Size(300, 45);
            this.Gn2BtnStaff.TabIndex = 3;
            this.Gn2BtnStaff.Tag = "MainBtns";
            this.Gn2BtnStaff.Text = "Staff";
            this.Gn2BtnStaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gn2BtnStaff.TextOffset = new System.Drawing.Point(30, 0);
            this.Gn2BtnStaff.Click += new System.EventHandler(this.MainBtns_Click);
            // 
            // Gn2BtnDashboard
            // 
            this.Gn2BtnDashboard.Animated = true;
            this.Gn2BtnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gn2BtnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gn2BtnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gn2BtnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gn2BtnDashboard.FillColor = System.Drawing.Color.DarkOliveGreen;
            this.Gn2BtnDashboard.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold);
            this.Gn2BtnDashboard.ForeColor = System.Drawing.Color.White;
            this.Gn2BtnDashboard.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Gn2BtnDashboard.Image = global::SuperMarketMS.Properties.Resources.circle_gauge;
            this.Gn2BtnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gn2BtnDashboard.ImageOffset = new System.Drawing.Point(10, 0);
            this.Gn2BtnDashboard.Location = new System.Drawing.Point(0, 180);
            this.Gn2BtnDashboard.Name = "Gn2BtnDashboard";
            this.Gn2BtnDashboard.Size = new System.Drawing.Size(300, 45);
            this.Gn2BtnDashboard.TabIndex = 2;
            this.Gn2BtnDashboard.Tag = "MainBtns";
            this.Gn2BtnDashboard.Text = "Dashboard";
            this.Gn2BtnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Gn2BtnDashboard.TextOffset = new System.Drawing.Point(30, 0);
            this.Gn2BtnDashboard.Click += new System.EventHandler(this.MainBtns_Click);
            // 
            // Gn2PB1
            // 
            this.Gn2PB1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Gn2PB1.FillColor = System.Drawing.Color.Transparent;
            this.Gn2PB1.Image = global::SuperMarketMS.Properties.Resources.ShopBasket;
            this.Gn2PB1.ImageRotate = 0F;
            this.Gn2PB1.Location = new System.Drawing.Point(93, 10);
            this.Gn2PB1.Name = "Gn2PB1";
            this.Gn2PB1.Size = new System.Drawing.Size(100, 100);
            this.Gn2PB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Gn2PB1.TabIndex = 0;
            this.Gn2PB1.TabStop = false;
            // 
            // Gn2DC1
            // 
            this.Gn2DC1.DockIndicatorTransparencyValue = 0.6D;
            this.Gn2DC1.TargetControl = this.Gn2Pnl1;
            this.Gn2DC1.UseTransparentDrag = true;
            // 
            // Gn2MD1
            // 
            this.Gn2MD1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNoCancel;
            this.Gn2MD1.Caption = "Confirmation";
            this.Gn2MD1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            this.Gn2MD1.Parent = this;
            this.Gn2MD1.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.Gn2MD1.Text = "Are You Sure to Quit ?";
            // 
            // Gn2MD2
            // 
            this.Gn2MD2.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNoCancel;
            this.Gn2MD2.Caption = "Confirmation";
            this.Gn2MD2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            this.Gn2MD2.Parent = this;
            this.Gn2MD2.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.Gn2MD2.Text = "Are You Sure to Logout ?";
            // 
            // Gn2AW1
            // 
            this.Gn2AW1.TargetForm = this;
            // 
            // Pnl3
            // 
            this.Pnl3.Controls.Add(this.UCDashboard1);
            this.Pnl3.Controls.Add(this.UCStaff1);
            this.Pnl3.Controls.Add(this.UCCategories1);
            this.Pnl3.Controls.Add(this.UCProducts1);
            this.Pnl3.Controls.Add(this.UCCustomers1);
            this.Pnl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl3.Location = new System.Drawing.Point(0, 0);
            this.Pnl3.Name = "Pnl3";
            this.Pnl3.Size = new System.Drawing.Size(1200, 700);
            this.Pnl3.TabIndex = 3;
            // 
            // UCDashboard1
            // 
            this.UCDashboard1.Location = new System.Drawing.Point(300, 30);
            this.UCDashboard1.Name = "UCDashboard1";
            this.UCDashboard1.Padding = new System.Windows.Forms.Padding(5);
            this.UCDashboard1.Size = new System.Drawing.Size(900, 670);
            this.UCDashboard1.TabIndex = 4;
            // 
            // UCStaff1
            // 
            this.UCStaff1.Location = new System.Drawing.Point(300, 30);
            this.UCStaff1.Name = "UCStaff1";
            this.UCStaff1.Padding = new System.Windows.Forms.Padding(5);
            this.UCStaff1.Size = new System.Drawing.Size(900, 670);
            this.UCStaff1.TabIndex = 3;
            // 
            // UCCategories1
            // 
            this.UCCategories1.Location = new System.Drawing.Point(300, 30);
            this.UCCategories1.Name = "UCCategories1";
            this.UCCategories1.Size = new System.Drawing.Size(900, 670);
            this.UCCategories1.TabIndex = 2;
            // 
            // UCProducts1
            // 
            this.UCProducts1.Location = new System.Drawing.Point(300, 30);
            this.UCProducts1.Name = "UCProducts1";
            this.UCProducts1.Padding = new System.Windows.Forms.Padding(5);
            this.UCProducts1.Size = new System.Drawing.Size(900, 670);
            this.UCProducts1.TabIndex = 1;
            // 
            // UCCustomers1
            // 
            this.UCCustomers1.Location = new System.Drawing.Point(300, 30);
            this.UCCustomers1.Name = "UCCustomers1";
            this.UCCustomers1.Padding = new System.Windows.Forms.Padding(5);
            this.UCCustomers1.Size = new System.Drawing.Size(900, 670);
            this.UCCustomers1.TabIndex = 0;
            // 
            // Gn2TglSwtch
            // 
            this.Gn2TglSwtch.Animated = true;
            this.Gn2TglSwtch.BackColor = System.Drawing.Color.Transparent;
            this.Gn2TglSwtch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Gn2TglSwtch.CheckedState.BorderRadius = 0;
            this.Gn2TglSwtch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Gn2TglSwtch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.Gn2TglSwtch.CheckedState.InnerBorderRadius = 0;
            this.Gn2TglSwtch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.Gn2TglSwtch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gn2TglSwtch.Location = new System.Drawing.Point(90, 555);
            this.Gn2TglSwtch.Name = "Gn2TglSwtch";
            this.Gn2TglSwtch.Size = new System.Drawing.Size(70, 25);
            this.Gn2TglSwtch.TabIndex = 5;
            this.Gn2TglSwtch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Gn2TglSwtch.UncheckedState.BorderRadius = 0;
            this.Gn2TglSwtch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Gn2TglSwtch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.Gn2TglSwtch.UncheckedState.InnerBorderRadius = 0;
            this.Gn2TglSwtch.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.Gn2TglSwtch.UseTransparentBackground = true;
            this.Gn2TglSwtch.CheckedChanged += new System.EventHandler(this.Gn2TglSwtch_CheckedChanged);
            // 
            // LbThShd
            // 
            this.LbThShd.AutoSize = true;
            this.LbThShd.BackColor = System.Drawing.Color.Transparent;
            this.LbThShd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbThShd.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbThShd.ForeColor = System.Drawing.Color.SeaShell;
            this.LbThShd.Location = new System.Drawing.Point(168, 553);
            this.LbThShd.Name = "LbThShd";
            this.LbThShd.Size = new System.Drawing.Size(118, 28);
            this.LbThShd.TabIndex = 11;
            this.LbThShd.Text = "Dark | Light";
            this.LbThShd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbTheme
            // 
            this.LbTheme.AutoSize = true;
            this.LbTheme.BackColor = System.Drawing.Color.Transparent;
            this.LbTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbTheme.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTheme.ForeColor = System.Drawing.Color.SeaShell;
            this.LbTheme.Location = new System.Drawing.Point(9, 553);
            this.LbTheme.Name = "LbTheme";
            this.LbTheme.Size = new System.Drawing.Size(75, 28);
            this.LbTheme.TabIndex = 12;
            this.LbTheme.Text = "Theme";
            this.LbTheme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.Gn2Pnl1);
            this.Controls.Add(this.Gn2Pnl2);
            this.Controls.Add(this.Pnl3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminMainForm";
            this.Text = "AdminMainForm";
            this.Load += new System.EventHandler(this.AdminMainForm_Load);
            this.Gn2Pnl1.ResumeLayout(false);
            this.Gn2Pnl1.PerformLayout();
            this.Gn2Pnl2.ResumeLayout(false);
            this.Gn2Pnl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gn2PB1)).EndInit();
            this.Pnl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Gn2Pnl1;
        private Guna.UI2.WinForms.Guna2Panel Gn2Pnl2;
        private Guna.UI2.WinForms.Guna2ControlBox Gn2CBMin;
        private Guna.UI2.WinForms.Guna2ControlBox Gn2CBClose;
        private System.Windows.Forms.Label LbHeading;
        private Guna.UI2.WinForms.Guna2PictureBox Gn2PB1;
        private System.Windows.Forms.Label LbAdmin;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnCustms;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnProds;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnCategories;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnStaff;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnDashboard;
        private System.Windows.Forms.Label LbUser;
        private Guna.UI2.WinForms.Guna2Button Gn2BtnLogout;
        private Guna.UI2.WinForms.Guna2DragControl Gn2DC1;
        private Guna.UI2.WinForms.Guna2MessageDialog Gn2MD1;
        private Guna.UI2.WinForms.Guna2MessageDialog Gn2MD2;
        private Guna.UI2.WinForms.Guna2AnimateWindow Gn2AW1;
        private System.Windows.Forms.Panel Pnl3;
        private UCCategories UCCategories1;
        private UCProducts UCProducts1;
        private UCCustomers UCCustomers1;
        private UCDashboard UCDashboard1;
        private UCStaff UCStaff1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch Gn2TglSwtch;
        private System.Windows.Forms.Label LbThShd;
        private System.Windows.Forms.Label LbTheme;
    }
}