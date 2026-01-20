using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace SuperMarketMS
{
    public partial class StaffMainForm : Form
    {
        public StaffMainForm()
        {
            InitializeComponent();
        }

        private void StaffMainForm_Load(object sender, EventArgs e)
        {
            string un = SuperMarketData.Username;
            LbUser.Text = $"{un.Substring(0, 1).ToUpper()}{un.Substring(1)}";

            Gn2BtnDashboard.FillColor = Color.OliveDrab;

            UCDashboard1.Show();
            UCProducts1.Hide();
            UCOrders1.Hide();
            UCCustomers1.Hide();
        }

        private void Gn2CBClose_Click(object sender, EventArgs e)
        {
            DialogResult dr = Gn2MD1.Show();
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }
        private void Gn2BtnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you Sure to Logout ? ", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                FormLogin frmlgn = new FormLogin();
                frmlgn.Show();
                Hide();
            }
        }

        private void StaffMainBtns_Click(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;

            foreach (Guna2Button b in Gn2Pnl2.Controls.OfType<Guna2Button>())
            {
                if ((string) b.Tag == "MainBtns")
                {
                    b.FillColor = Color.DarkOliveGreen;
                }
            }
            btn.FillColor = Color.OliveDrab;

            if (Gn2TglSwtch.Checked)
            {
                foreach (Guna2Button b in Gn2Pnl2.Controls.OfType<Guna2Button>())
                {
                    if ((string)b.Tag == "MainBtns")
                    {
                        b.FillColor = Color.LightSteelBlue;
                        b.ForeColor = Color.MidnightBlue;
                    }
                }
                btn.FillColor = Color.LightCoral;
            }

            switch(btn.Name)
            {
                case "Gn2BtnDashboard":
                    UCDashboard1.Show();
                    UCProducts1.Hide();
                    UCOrders1.Hide();
                    UCCustomers1.Hide();

                    UCDashboard ucd = UCDashboard1 as UCDashboard;
                    ucd?.RefreshData();
                    break;
                case "Gn2BtnProds":
                    UCDashboard1.Hide();
                    UCProducts1.Show();
                    UCOrders1.Show();
                    UCCustomers1.Hide();

                    UCProducts ucp = UCProducts1 as UCProducts;
                    ucp?.RefreshData();
                    break;
                case "Gn2BtnOrders":
                    UCDashboard1.Hide();
                    UCProducts1.Hide();
                    UCOrders1.Show();
                    UCCustomers1.Hide();

                    UCOrders uco = UCOrders1 as UCOrders;
                    uco?.RefreshData();
                    break;
                case "Gn2BtnCustms":
                    UCDashboard1.Hide();
                    UCProducts1.Hide();
                    UCOrders1.Hide();
                    UCCustomers1.Show();

                    UCCustomers ucct = UCCustomers1 as UCCustomers;
                    ucct?.RefreshData();
                    break;
            }
        }

        private void Gn2TglSwtch_CheckedChanged(object sender, EventArgs e)
        {
            if (Gn2TglSwtch.Checked) // Light
            {
                // Form 
                Gn2Pnl1.FillColor = Color.LightGreen;
                Gn2Pnl2.FillColor = Color.LightSeaGreen;
                LbHeading.ForeColor = Color.MidnightBlue;
                LbTheme.ForeColor = Color.MidnightBlue;
                LbThShd.ForeColor = Color.MidnightBlue;

                foreach (Guna2Button b in Gn2Pnl2.Controls.OfType<Guna2Button>())
                {
                    b.FillColor = Color.LightSteelBlue;
                    b.ForeColor = Color.MidnightBlue;
                }

                ColorSetForUCLight();
            }
            else// Default Dark
            {
                // Form
                Gn2Pnl1.FillColor = Color.DarkOliveGreen;
                Gn2Pnl2.FillColor = Color.Olive;
                foreach (Guna2Button b in Gn2Pnl2.Controls.OfType<Guna2Button>())
                {
                    b.FillColor = Color.DarkOliveGreen;
                    b.ForeColor = Color.White;
                }

                ColorSetForUCDark();    
            }
        }

        private void ColorSetForUCLight()
        {
            Color c1 = Color.LightCoral;
            Color c2 = Color.LightSeaGreen;
            
            UCDashboard1.Gn2GrdPnl1.FillColor = c1;
            UCDashboard1.Gn2GrdPnl2.FillColor = c1;
            UCDashboard1.Gn2GrdPnl1.FillColor2 = c2;
            UCDashboard1.Gn2GrdPnl2.FillColor2 = c2;
            UCProducts1.Gn2GP1.FillColor = c1;
            UCProducts1.Gn2GP2.FillColor = c1;
            UCProducts1.Gn2GP2.FillColor2 = c2;
            UCProducts1.Gn2GP2.FillColor2 = c2;
            UCCustomers1.Gn2GP1.FillColor = c1;
            UCCustomers1.Gn2GP1.FillColor2 = c2;
            UCOrders1.FLP1.BackColor = c1;
            UCOrders1.Gn2GrdPnl1.FillColor = c1;
            UCOrders1.Gn2GrdPnl1.FillColor2 = c2;
        }

        private void ColorSetForUCDark()
        {
            Color c1 = Color.DarkOliveGreen;
            Color c2 = Color.YellowGreen;
            
            UCDashboard1.Gn2GrdPnl1.FillColor = c1;
            UCDashboard1.Gn2GrdPnl2.FillColor = c1;
            UCDashboard1.Gn2GrdPnl1.FillColor2 = c2;
            UCDashboard1.Gn2GrdPnl2.FillColor2 = c2;
            UCProducts1.Gn2GP1.FillColor = c1;
            UCProducts1.Gn2GP2.FillColor = c1;
            UCProducts1.Gn2GP2.FillColor2 = c2;
            UCProducts1.Gn2GP2.FillColor2 = c2;
            UCCustomers1.Gn2GP1.FillColor = c1;
            UCCustomers1.Gn2GP1.FillColor2 = c2;
            UCOrders1.FLP1.BackColor = c1;
            UCOrders1.Gn2GrdPnl1.FillColor = c1;
            UCOrders1.Gn2GrdPnl1.FillColor2 = c2;
        }
    }
}
