namespace SuperMarketMS
{
    partial class FormLoad
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
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Gn2CPB1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.LbHeading = new System.Windows.Forms.Label();
            this.Gn2PB1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Gn2DC1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Gn2CPB1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(543, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // Gn2CPB1
            // 
            this.Gn2CPB1.FillColor = System.Drawing.Color.Transparent;
            this.Gn2CPB1.Image = global::SuperMarketMS.Properties.Resources.ShopBasket;
            this.Gn2CPB1.ImageRotate = 0F;
            this.Gn2CPB1.Location = new System.Drawing.Point(175, 194);
            this.Gn2CPB1.Name = "Gn2CPB1";
            this.Gn2CPB1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Gn2CPB1.Size = new System.Drawing.Size(250, 250);
            this.Gn2CPB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Gn2CPB1.TabIndex = 1;
            this.Gn2CPB1.TabStop = false;
            // 
            // LbHeading
            // 
            this.LbHeading.AutoSize = true;
            this.LbHeading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbHeading.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHeading.ForeColor = System.Drawing.Color.PaleGreen;
            this.LbHeading.Location = new System.Drawing.Point(10, 76);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(581, 36);
            this.LbHeading.TabIndex = 2;
            this.LbHeading.Text = "SUPERMARKET MANAGEMENT SYSTEM";
            this.LbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Gn2PB1
            // 
            this.Gn2PB1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gn2PB1.Location = new System.Drawing.Point(0, 520);
            this.Gn2PB1.Name = "Gn2PB1";
            this.Gn2PB1.ProgressBrushMode = Guna.UI2.WinForms.Enums.BrushMode.SolidTransition;
            this.Gn2PB1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Gn2PB1.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Gn2PB1.ShowText = true;
            this.Gn2PB1.Size = new System.Drawing.Size(600, 30);
            this.Gn2PB1.TabIndex = 3;
            this.Gn2PB1.Text = "guna2ProgressBar1";
            this.Gn2PB1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Gn2PB1.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Value;
            this.Gn2PB1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 30;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Gn2DC1
            // 
            this.Gn2DC1.DockIndicatorTransparencyValue = 0.6D;
            this.Gn2DC1.TargetControl = this;
            this.Gn2DC1.UseTransparentDrag = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Ysabeau ExtraBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaShell;
            this.label1.Location = new System.Drawing.Point(86, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 44);
            this.label1.TabIndex = 4;
            this.label1.Text = "AMRUTHA SUPERMARKET";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Gn2PB1);
            this.Controls.Add(this.LbHeading);
            this.Controls.Add(this.Gn2CPB1);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLoad";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Gn2CPB1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox Gn2CPB1;
        private System.Windows.Forms.Label LbHeading;
        private Guna.UI2.WinForms.Guna2ProgressBar Gn2PB1;
        private System.Windows.Forms.Timer Timer1;
        private Guna.UI2.WinForms.Guna2DragControl Gn2DC1;
        private System.Windows.Forms.Label label1;
    }
}

