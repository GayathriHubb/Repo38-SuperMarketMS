using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Printing;


namespace SuperMarketMS
{
    public partial class UCOrders : UserControl
    {
        public UCOrders()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\SuperMarketMS\SuperMarket.mdf;Integrated Security=True";

        private void UCOrders_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                try
                {
                    LoadProdCards();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex, "UCOrdersLoad");
                }
            }
        }

        public void CardItems(int id, string pdid, string category, string brand, string pdname, string pdstock, string pdprice, string imgpath, int pdqty)
        {
            UCPCard ucp = new UCPCard
            {
                Id = id,
                ProdId = pdid,
                Category = category,
                Brand = brand,
                PdName = pdname,
                Stock = pdstock,
                Price = pdprice,
                PdImage = imgpath,
                PdQty = pdqty,
            };

            FLP1.Controls.Add(ucp);

            ucp.SelectCard += Ucp_SelectCard;
        }

        public void LoadProdCards()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    FLP1.Controls.Clear();
                    sqlcon.Open();

                    string seldata = "Select * From Products Where DateDelete is NULL";

                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        SqlDataReader sdr = selcmd.ExecuteReader();

                        while (sdr.Read())
                        {
                            int id = (int)sdr["Id"];
                            string pdid = (sdr["ProdId"] != DBNull.Value) ? (string)sdr["ProdId"] : "N/A";
                            string pname = (sdr["ProdName"] != DBNull.Value) ? (string)sdr["ProdName"] : "N/A";
                            string cat = (sdr["CategoryName"] != DBNull.Value) ? (string)sdr["CategoryName"] : "N/A";
                            string brand = (sdr["Brand"] != DBNull.Value) ? (string)sdr["Brand"] : "N/A";
                            string stock = (sdr["ProdStock"] != DBNull.Value) ? sdr["ProdStock"].ToString() : "0";
                            string price = (sdr["ProdPrice"] != DBNull.Value) ? $"{sdr["ProdPrice"]:0.##}" : "0.00";
                            string imgpth = (sdr["ImagePath"] != DBNull.Value) ? (string)sdr["ImagePath"] : string.Empty;

                            CardItems(id, pdid, cat, brand, pname, stock, price, imgpth, default);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "SelectCard");
                }

            }
        }

        int getqty; float getprice; double tppp;
        private void Ucp_SelectCard(object sender, EventArgs e)
        {
            UCPCard selectedcard = sender as UCPCard;
            bool flag = false;
            try
            {
                IdGenerator();

                foreach (DataGridViewRow row in DGVOrders.Rows)
                {
                    if (row.Cells["Col2Id"].Value != null && (int)row.Cells["Col2Id"].Value == selectedcard.Id)
                    {
                        if (selectedcard.PdQty > 0)
                        {
                            getprice = Convert.ToSingle(selectedcard.Price);
                            getqty = selectedcard.PdQty;
                            tppp = getprice * getqty;

                            row.Cells["Col1CustId"].Value = $"CST{count}";
                            row.Cells["Col6Price"].Value = tppp;
                            row.Cells["Col5Qty"].Value = selectedcard.PdQty;

                            flag = true;
                            break;
                        }
                    }
                }

                if (selectedcard.PdQty <= 0)
                {
                    MessageBox.Show("Qty Cannot be 0 or Less..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!flag)
                {
                    getprice = Convert.ToSingle(selectedcard.Price);
                    getqty = selectedcard.PdQty;
                    tppp = getprice * getqty;
                    
                    DGVOrders.Rows.Add($"CST{count}", selectedcard.Id, selectedcard.PdName, selectedcard.Brand, selectedcard.PdQty, tppp, selectedcard.ProdId);
                }
                CalcTotalPrice();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message, "SelectCard");
            }
        }
    
        public int count = 1;
        public void IdGenerator()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string countdata = "Select Count(Id) From Orders";

                    count = 1;
                    using (SqlCommand countcmd = new SqlCommand(countdata, sqlcon))
                    {
                        object result = countcmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            count = Convert.ToInt32(result) + 1;
                           
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "IdGenerator - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }

        DataGridViewRow row; int getid;
        private void DGVOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = DGVOrders.Rows[e.RowIndex];

            getid = (int)row.Cells[1].Value;
        }

        private void Gn2GBtnPO_Click(object sender, EventArgs e)
        {
            if (!amntchk)
            {
                MessageBox.Show("Please Enter Valid Tendered Amount and Press Enter Key", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dr = MessageBox.Show("Are you Sure to Place Order ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        IdGenerator();

                        List<string> PdIds = new List<string>();
                        List<string> PdQts = new List<string>();
                        List<string> PdBrands = new List<string>();
                        List<string> PdPrices = new List<string>();

                        foreach (DataGridViewRow row in DGVOrders.Rows)
                        {
                            if (row.Cells["Col2Id"].Value != null)
                            {
                                PdIds.Add(row.Cells["Col2Id"].Value.ToString());
                                PdBrands.Add(row.Cells["Col4Brand"].Value.ToString());  
                                PdQts.Add(row.Cells["Col5Qty"].Value.ToString());
                                PdPrices.Add(row.Cells["Col6Price"].Value.ToString());
                            }
                        }

                        string pdidsstr = string.Join(", ", PdIds);
                        string pdqtsstr = string.Join(", ", PdQts);
                        string pdbrandsstr = string.Join(", ", PdBrands);
                        string pdpricesstr = string.Join(", ", PdPrices);

                        string insdata = "Insert Into Orders (CustId, PdIds, PdQtys, PdBrands, PdTPrices, TotalPrice, DateOrder) Values (@cid, @pids, @pqtys, @pbrnds, @pprs, @tp, @orddt)";

                        using (SqlCommand inscmd = new SqlCommand(insdata, sqlcon))
                        {
                            inscmd.Parameters.AddWithValue("@cid", $"CST{count}");
                            inscmd.Parameters.AddWithValue("@pids", pdidsstr);
                            inscmd.Parameters.AddWithValue("@pqtys", pdqtsstr);
                            inscmd.Parameters.AddWithValue("@pbrnds", pdbrandsstr);
                            inscmd.Parameters.AddWithValue("@pprs", pdpricesstr);
                            inscmd.Parameters.AddWithValue("@tp", Convert.ToSingle(Gn2TBTP.Text.Trim()));
                            inscmd.Parameters.AddWithValue("@orddt", DateTime.Today);

                            int ra = inscmd.ExecuteNonQuery();

                            // Update Products Stock
                            if (ra > 0)
                            {
                                for (int i = 0; i < PdIds.Count; i++)
                                {
                                    string getprodid = PdIds[i];
                                    int getqty = Convert.ToInt32(PdQts[i]);
                                    string updatestock = "Update Products Set ProdStock = ProdStock - @qty Where Id = @id";
                                    using (SqlCommand upcmd = new SqlCommand(updatestock, sqlcon))
                                    {
                                        upcmd.Parameters.AddWithValue("@qty", getqty);
                                        upcmd.Parameters.AddWithValue("@id", getprodid);

                                        upcmd.ExecuteNonQuery();
                                    }
                                }
                            }
                        }

                        MessageBox.Show("Order Placed Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                        string insdata2 = "Insert Into Customers (CustId, TotalPrice, Amount, Change, DateOrder) Values (@cstid, @tp, @amnt, @chng, @orddt)";

                        using (SqlCommand inscmd2 = new SqlCommand(insdata2, sqlcon))
                        {
                            inscmd2.Parameters.AddWithValue("@cstid", $"CST{count}");
                            inscmd2.Parameters.AddWithValue("@tp", Convert.ToSingle(Gn2TBTP.Text.Trim()));
                            inscmd2.Parameters.AddWithValue("@amnt", Convert.ToSingle(Gn2TBAmnt.Text.Trim()));
                            inscmd2.Parameters.AddWithValue("@chng", Convert.ToSingle(Gn2TBChange.Text.Trim()));
                            inscmd2.Parameters.AddWithValue("@orddt", DateTime.Today);

                            inscmd2.ExecuteNonQuery();
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Orders - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Gn2BtnReomve_Click(object sender, EventArgs e)
        {
            if (DGVOrders.RowCount == 0 || getid == 0)
            {
                MessageBox.Show("Pls Select Item First", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show($"Are you Sure to Remove Id: {getid} ?", "Remove Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        if (row != null)
                        {
                            DGVOrders.Rows.Remove(row);
                            CalcTotalPrice();

                            MessageBox.Show("Item Removed Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "DGV|Error");
                        Debug.WriteLine(ex, "DGVOrders");
                    }

                }
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
                Debug.WriteLine(ex, "BtnReceipt");
            }
        }

        private void CalcTotalPrice()
        {
            double totalprice = 0;

            foreach (DataGridViewRow row in DGVOrders.Rows)
            {
                if (DGVOrders.Rows.Count == 0)
                {
                    Gn2TBTP.Text = string.Empty;
                }
                if (row.Cells["Col6Price"].Value != null)
                {
                    double colvalues = Convert.ToDouble(row.Cells["Col6Price"].Value);
                    totalprice += colvalues;
                }
            }
            Gn2TBTP.Text = $"{totalprice:F2}";
        }

        int rowindex;
        private void PD1_PrintPage(object sender, PrintPageEventArgs e)
        {
            IdGenerator();
            CalcTotalPrice();


            int y = 50;
            int left = 50;
            int colwidth = 150;

            Font headerfont = new Font("Cambria", 18, FontStyle.Bold);
            Font font = new Font("Arial", 12, FontStyle.Bold);
            Font smallfont = new Font("Segoe UI", 10, FontStyle.Bold);

            int centrex1 = (int)(e.PageBounds.Width - e.Graphics.MeasureString("AMRUTHA SUPERMARKET", headerfont).Width) / 2;
            int centrex2 = (int)(e.PageBounds.Width - e.Graphics.MeasureString("Thank You for Shopping!", font).Width) / 2;
            int centrex3 = (int)(e.PageBounds.Width - e.Graphics.MeasureString("Visit Again!", font).Width) / 2;

            // ✅ Store Header
            e.Graphics.DrawString("AMRUTHA SUPERMARKET", headerfont, Brushes.Firebrick, centrex1, y);
            y += 80;

            string date = $"Date: {DateTime.Now:dd/MM/yyyy hh:mm tt}";
            int datex = (int)((left + 750) - e.Graphics.MeasureString(date, font).Width);

            // ✅ Date + Bill No
            e.Graphics.DrawString($"Bill No: {count - 1}", font, Brushes.Black, left, y);
            e.Graphics.DrawString(date, font, Brushes.Black, datex, y);
            y += 30;

            e.Graphics.DrawLine(Pens.Black, left, y, left + 750, y);
            y += 20;

            // ✅ Table Headers
            string[] headers = { "Product Id", "ProductName", "Brand", "Quantity", "Price" };
            for (int i = 0; i < headers.Length; i++)
            {
                e.Graphics.DrawString(headers[i], font, Brushes.Navy, left + (i * colwidth), y);
            }
            y += 25;

            e.Graphics.DrawLine(Pens.Black, left, y, left + 750, y);
            y += 10;

            // ✅ Table Rows
            while (rowindex < DGVOrders.Rows.Count)
            {
                DataGridViewRow row = DGVOrders.Rows[rowindex];

                e.Graphics.DrawString(row.Cells[6].Value.ToString(), smallfont, Brushes.Black, left + 0, y);

                string pname = row.Cells[2].Value.ToString();

                // Limit text width so it wraps
                int textwidth = 150;
                SizeF textsize = e.Graphics.MeasureString(pname, smallfont, textwidth);

                // Draw wrapped product name
                e.Graphics.DrawString(pname, smallfont, Brushes.Black, new RectangleF(left + 150, y, textwidth, textsize.Height));
                e.Graphics.DrawString(row.Cells[3].Value.ToString(), smallfont, Brushes.Black, left + 300, y);
                e.Graphics.DrawString(row.Cells[4].Value.ToString(), smallfont, Brushes.Black, left + 450, y);
                e.Graphics.DrawString(row.Cells[5].Value.ToString(), smallfont, Brushes.Black, left + 600, y);

                y += (int)textsize.Height > 25 ? (int)textsize.Height : 25;
                rowindex++;

                if (y > e.MarginBounds.Height)
                {
                    e.HasMorePages = true;
                    return;
                }
            }
            y += 20;
            e.Graphics.DrawLine(Pens.Black, left, y, left + 750, y);
            y += 30;

            // ✅ Summary Price Section
            DrawRightAligned(e.Graphics, "TotalPrice(₹):", $"{Gn2TBTP.Text: 0.00}", font, left, ref y);
            DrawRightAligned(e.Graphics, "TenderedCash(₹):", $"{Gn2TBAmnt.Text: 0.00}", font, left, ref y);
            DrawRightAligned(e.Graphics, "TenderedChange(₹):", $"{Gn2TBChange.Text: 0.00}", font, left, ref y);

            y += 30;
            e.Graphics.DrawLine(Pens.Black, left, y, left + 750, y);
            y += 30;

            // ✅ Footer
            e.Graphics.DrawString("Thank You for Shopping!", font, Brushes.Black, centrex2, y);
            y += 25;
            e.Graphics.DrawString("Visit Again!", smallfont, Brushes.Black, centrex3, y);

            e.HasMorePages = false;

        }

        private void DrawRightAligned(Graphics g, string label, string value, Font font, int left, ref int y)
        {
            g.DrawString(label, font, Brushes.Navy, left + 300, y);
            g.DrawString(value, font, Brushes.Black, left + 520, y);
            y += 30;
        }

        
        public void RefreshData()
        {
            if(InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            LoadProdCards();
        }

        bool amntchk;
        private void Gn2TBAmnt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    float totalprice = float.Parse(Gn2TBTP.Text);
                    float amount = float.Parse(Gn2TBAmnt.Text);

                    float change = amount - totalprice;
                    if (change < 0)
                    {
                        MessageBox.Show("Amount Cannot be Less than TotalPrice", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        Gn2TBAmnt.Focus();
                        amntchk = false;
                    }
                    Gn2TBChange.Text = $"{change:F2}";
                    amntchk = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Amount - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    amntchk = false;
                }
                e.SuppressKeyPress = true;
            }
        }

        private void Gn2BtnClear_Click(object sender, EventArgs e)
        {
            Gn2TBTP.Clear();
            Gn2TBAmnt.Clear();
            Gn2TBChange.Clear();
        }

        
        private void SetCustIdOrders()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    IdGenerator();
                    sqlcon.Open();
                    int cstid = 0;
                    string seldata = "Select Max(CustId) From Orders";
                    using (SqlCommand selcmd = new SqlCommand (seldata, sqlcon))
                    {
                        object result = selcmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            cstid = (int)result;
                        }
                    }

                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
        }

    }
}
