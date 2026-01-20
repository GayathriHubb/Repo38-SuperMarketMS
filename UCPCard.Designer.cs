namespace SuperMarketMS
{
    partial class UCPCard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.PicBxPd = new System.Windows.Forms.PictureBox();
            this.LbPdName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LbQty = new System.Windows.Forms.Label();
            this.LbPrice = new System.Windows.Forms.Label();
            this.LbStock = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.NUDQty = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxPd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDQty)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PicBxPd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 198);
            this.panel1.TabIndex = 0;
            // 
            // PicBxPd
            // 
            this.PicBxPd.BackColor = System.Drawing.Color.DimGray;
            this.PicBxPd.Location = new System.Drawing.Point(0, 0);
            this.PicBxPd.Name = "PicBxPd";
            this.PicBxPd.Size = new System.Drawing.Size(200, 200);
            this.PicBxPd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBxPd.TabIndex = 0;
            this.PicBxPd.TabStop = false;
            // 
            // LbPdName
            // 
            this.LbPdName.AutoSize = true;
            this.LbPdName.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPdName.ForeColor = System.Drawing.Color.Navy;
            this.LbPdName.Location = new System.Drawing.Point(202, 9);
            this.LbPdName.Name = "LbPdName";
            this.LbPdName.Size = new System.Drawing.Size(127, 21);
            this.LbPdName.TabIndex = 1;
            this.LbPdName.Text = "ProductName";
            this.LbPdName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(202, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stock:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(202, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price(₹):";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbQty
            // 
            this.LbQty.AutoSize = true;
            this.LbQty.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbQty.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.LbQty.Location = new System.Drawing.Point(202, 120);
            this.LbQty.Name = "LbQty";
            this.LbQty.Size = new System.Drawing.Size(41, 21);
            this.LbQty.TabIndex = 4;
            this.LbQty.Text = "Qty";
            this.LbQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbPrice
            // 
            this.LbPrice.AutoSize = true;
            this.LbPrice.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPrice.ForeColor = System.Drawing.Color.Navy;
            this.LbPrice.Location = new System.Drawing.Point(281, 72);
            this.LbPrice.Name = "LbPrice";
            this.LbPrice.Size = new System.Drawing.Size(18, 21);
            this.LbPrice.TabIndex = 8;
            this.LbPrice.Text = "?";
            this.LbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbStock
            // 
            this.LbStock.AutoSize = true;
            this.LbStock.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbStock.ForeColor = System.Drawing.Color.Navy;
            this.LbStock.Location = new System.Drawing.Point(281, 38);
            this.LbStock.Name = "LbStock";
            this.LbStock.Size = new System.Drawing.Size(18, 21);
            this.LbStock.TabIndex = 7;
            this.LbStock.Text = "?";
            this.LbStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnAdd
            // 
            this.BtnAdd.AutoSize = true;
            this.BtnAdd.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.SeaShell;
            this.BtnAdd.Location = new System.Drawing.Point(223, 152);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(95, 33);
            this.BtnAdd.TabIndex = 9;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // NUDQty
            // 
            this.NUDQty.BackColor = System.Drawing.Color.White;
            this.NUDQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NUDQty.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDQty.Location = new System.Drawing.Point(254, 115);
            this.NUDQty.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NUDQty.Name = "NUDQty";
            this.NUDQty.Size = new System.Drawing.Size(75, 31);
            this.NUDQty.TabIndex = 10;
            // 
            // UCPCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(180)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.NUDQty);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.LbPrice);
            this.Controls.Add(this.LbStock);
            this.Controls.Add(this.LbQty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LbPdName);
            this.Controls.Add(this.panel1);
            this.Name = "UCPCard";
            this.Size = new System.Drawing.Size(348, 198);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBxPd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LbPdName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LbQty;
        private System.Windows.Forms.PictureBox PicBxPd;
        private System.Windows.Forms.Label LbPrice;
        private System.Windows.Forms.Label LbStock;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.NumericUpDown NUDQty;
    }
}
