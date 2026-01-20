using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarketMS
{
    public partial class UCCustomers : UserControl
    {
        public UCCustomers()
        {
            InitializeComponent();
        }

        private void UCCustomers_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                try
                {
                    DisplayCustmsData();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "CustmsLoad");
                }
            }
        }

        DataGridViewRow row;
        private void DGVCustms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != - 1)
            {
                row = DGVCustms.Rows[e.RowIndex];    
            }
        }

        private void Gn2BtnReceipt_Click(object sender, EventArgs e)
        {
            try
            {
                PPD1.ShowDialog();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message, "CustmsReceipt");
            }
        }

        private void PD1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                Graphics g = e.Graphics;

                int centrex1 = (int)(e.PageBounds.Width - g.MeasureString("AMRUTHA SUPERMARKET", new Font("Tribuchet MS", 16, FontStyle.Bold)).Width) / 2;
                int centrex2 = (int)(e.PageBounds.Width - g.MeasureString("------------  HAVE A GREAT DAY  ------------", new Font("Tribuchet MS", 16, FontStyle.Bold)).Width) / 2;
                int heading1y = 100;
                int remdatay = heading1y + 100;
                int left = 20;

                Font f = new Font("Gadugi", 13, FontStyle.Bold);

                g.DrawString("AMRUTHA SUPERMARKET", new Font("Cambria", 16, FontStyle.Bold), Brushes.Firebrick, new Point(centrex1, heading1y));

                DrawLeftAligned(e.Graphics, "Customer Id: ", row?.Cells[1].Value.ToString(), f, left, ref remdatay);
                DrawLeftAligned(e.Graphics, "TotalPrice: ", row?.Cells[2].Value.ToString(), f, left, ref remdatay);
                DrawLeftAligned(e.Graphics, "TenderedCash: ", row?.Cells[3].Value.ToString(), f, left, ref remdatay);
                DrawLeftAligned(e.Graphics, "TenderedChange: ", row?.Cells[4].Value.ToString(), f, left, ref remdatay);
                DrawLeftAligned(e.Graphics, "OrderDate: ", row?.Cells[5].Value.ToString(), f, left, ref remdatay);

                g.DrawString("------------  HAVE A GREAT DAY  ------------", f, Brushes.Firebrick, new Point(centrex2, remdatay + 300));

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message, "DGVCustomers");
            }
        }

        private static void DrawLeftAligned(Graphics g, string label, string value, Font font, int left, ref int y)
        {
            g.DrawString(label, font, Brushes.Navy, left + 40, y);
            g.DrawString(value, font, Brushes.Black, left + 260, y);
            y += 40;
        }

        public void DisplayCustmsData()
        {
            CustomersData cd = new CustomersData();
            DGVCustms.DataSource = cd.ListCustomers();
        }

        public void RefreshData()
        {
            if(InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }

            DisplayCustmsData();
        }
    }
        
}
