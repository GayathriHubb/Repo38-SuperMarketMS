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
using System.IO;
using System.Data.SqlClient;

namespace SuperMarketMS
{
    public partial class UCProducts : UserControl
    {
        public UCProducts()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\SuperMarketMS\SuperMarket.mdf;Integrated Security=True";

        string targetpath;
        private void UCProducts_Load(object sender, EventArgs e)
        {

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                try
                {
                    DisplayProducts();
                    DisplayCategories();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex, "ProductsLoad");
                }
            }
        }

        private void Gn2GBtnIns_Click(object sender, EventArgs e)
        {
            if (CheckEmptyFields())
            {
                MessageBox.Show("Empty Fields.. Pls Fill All the Fields Properly and Select a Photo", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidPrice(Gn2TxtBxPrice.Text, out float price))
            {
                MessageBox.Show("Invalid Price.. Pls Enter a Valid Price", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string pid = Gn2TxtBxPId.Text.Trim().ToUpper();
                try
                {
                    string basedirectory = AppDomain.CurrentDomain.BaseDirectory;
                    string relativepath = Path.Combine("ProdsDirectory", $"{pid}.jpg");
                    targetpath = Path.Combine(basedirectory, relativepath);

                    string directorypath = Path.GetDirectoryName(targetpath);
                    if (!Directory.Exists(directorypath))
                    {
                        Directory.CreateDirectory(directorypath);
                    }

                    if (!string.IsNullOrEmpty(PicBxProd.ImageLocation))
                    {
                        File.Copy(PicBxProd.ImageLocation, targetpath, true);
                    }
                    MessageBox.Show("Image Inserted Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex, "PicBxIns");
                }
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        string chkpid = "Select Count(Id) From Products Where ProdId = @pid";
                        using (SqlCommand chkcmd = new SqlCommand(chkpid, sqlcon))
                        {
                            chkcmd.Parameters.AddWithValue("@pid", pid);

                            int rc = 0;
                            object result = chkcmd.ExecuteScalar();
                            if (result != DBNull.Value)
                            {
                                rc = Convert.ToInt32(result);
                            }
                            if (rc != 0)
                            {
                                MessageBox.Show($"ProductId: {pid} is Existing Already", "Warning",  MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                                return;
                            }
                            string insdata = "Insert Into Products (ProdId, ProdName, CategoryName, Brand, ProdStock, ProdPrice, ProdStatus, ImagePath, DateInsert) Values (@pid, @pname, @ctname, @brnd, @stck, @price, @stus, @imgpath, @dtins)";

                            using (SqlCommand inscmd = new SqlCommand(insdata, sqlcon))
                            {
                                inscmd.Parameters.AddWithValue("@pid", pid);
                                inscmd.Parameters.AddWithValue("@pname", Gn2TxtBxPname.Text.Trim());
                                inscmd.Parameters.AddWithValue("@ctname", CmbBxCategory.Text.Trim());
                                inscmd.Parameters.AddWithValue("@brnd", Gn2TxtBxBrand.Text.Trim());
                                inscmd.Parameters.AddWithValue("@stck", (int)Gn2NUDStck.Value);
                                inscmd.Parameters.AddWithValue("@price", price.ToString("0.##"));
                                inscmd.Parameters.AddWithValue("@stus", CmbBxStatus.Text.Trim());
                                inscmd.Parameters.AddWithValue("@imgpath", targetpath ?? string.Empty);
                                inscmd.Parameters.AddWithValue("@dtins", DateTime.Now);

                                inscmd.ExecuteNonQuery();
                                DisplayProducts();
                                MessageBox.Show("Product Record Inserted Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                ClearFields();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "ProdsIns");
                    }
                }
            }
        }

        private void Gn2BtnUpd_Click(object sender, EventArgs e)
        {
            if (CheckEmptyFields())
            {
                MessageBox.Show("Empty Fields.. Pls Fill All the Fields Properly and Select a Photo", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidPrice(Gn2TxtBxPrice.Text, out float price))
            {
                MessageBox.Show("Invalid Price.. Pls Enter a Valid Price", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string pid = Gn2TxtBxPId.Text.Trim().ToUpper();
                DialogResult dr = MessageBox.Show($"Are you Sure to Update Id: {id} ?", "Update Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        string basedirectory = AppDomain.CurrentDomain.BaseDirectory;
                        string relativepath = Path.Combine("ProdsDirectory", $"{pid}.jpg");
                        targetpath = Path.Combine(basedirectory, relativepath);

                        if (!string.IsNullOrEmpty(PicBxProd.ImageLocation))
                        {
                            File.Copy(PicBxProd.ImageLocation, targetpath, true);
                        }
                        MessageBox.Show("Image Updated Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "PicBxUpd");
                    }
                    
                    using (SqlConnection sqlcon = new SqlConnection(constring))
                    {
                        try
                        {
                            sqlcon.Open();

                            string upddata = "Update Products Set ProdName = @pname, CategoryName = @ctname, Brand = @brnd, ProdStock = @stck, ProdPrice = @price, ProdStatus = @status, ImagePath = @imgpath, DateUpdate = @dtupd Where ProdId = @pid AND Id = @id";

                            using (SqlCommand updcmd = new SqlCommand(upddata, sqlcon))
                            {
                                updcmd.Parameters.AddWithValue("@pid", pid);
                                updcmd.Parameters.AddWithValue("@pname", Gn2TxtBxPname.Text.Trim());
                                updcmd.Parameters.AddWithValue("@ctname", CmbBxCategory.Text.Trim());
                                updcmd.Parameters.AddWithValue("@brnd", Gn2TxtBxBrand.Text.Trim());
                                updcmd.Parameters.AddWithValue("@stck", (int)Gn2NUDStck.Value);
                                updcmd.Parameters.AddWithValue("@price", price.ToString("0.##"));
                                updcmd.Parameters.AddWithValue("@status", CmbBxStatus.Text.Trim());
                                updcmd.Parameters.AddWithValue("@imgpath", targetpath ?? string.Empty);
                                updcmd.Parameters.AddWithValue("@dtupd", DateTime.Today);
                                updcmd.Parameters.AddWithValue("@id", id);

                                updcmd.ExecuteNonQuery();
                                DisplayProducts();
                                MessageBox.Show("Product Record Updated Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                ClearFields();
                            }
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex.Message, "ProdsUpd");
                        }
                    }
                    
                }
                
            }
        }
        

        private void Gn2BtnDel_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(Gn2TxtBxPname.Text) || id == 0)
            {
                MessageBox.Show("Pls Select Record First Or Enter ProductId to Delete", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return; 
            }
            else
            {
                DialogResult dr = MessageBox.Show($"Are you Sure to Delete Id: {id} ?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (SqlConnection sqlcon = new SqlConnection(constring))
                    {
                        try
                        {
                            sqlcon.Open();

                            string deldata= "Update Products Set DateDelete = @dtdel AND ProdStatus = @pdst Where Id = @id";

                            using (SqlCommand delcmd = new SqlCommand(deldata, sqlcon))
                            {
                                delcmd.Parameters.AddWithValue("@dtdel", DateTime.Today);
                                delcmd.Parameters.AddWithValue("@pdst", "Deleted");

                                delcmd.ExecuteNonQuery();
                                DisplayProducts();
                                MessageBox.Show("Product Record Deleted Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                ClearFields();
                            }
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex.Message, "ProdsDel");
                        }
                    }
                }
            }
        }

        private void Gn2BtnClr_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void Gn2BtnPhoto_Click(object sender, EventArgs e)
        {
            string imgpath = string.Empty;

            try
            {
                if (Ofd1.ShowDialog() == DialogResult.OK)
                {
                    imgpath = Ofd1.FileName;
                    PicBxProd.ImageLocation = imgpath;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message, "BtnPhoto");    
            }
        }

        int id;
        private void DGVProds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = DGVProds.Rows[e.RowIndex];

                    id = (int)row.Cells[0].Value;
                    Gn2TxtBxPId.Text = (string)row.Cells[1].Value;
                    Gn2TxtBxPname.Text = (string)row.Cells[2].Value;
                    Gn2TxtBxBrand.Text = (string) row.Cells[4].Value;
                    CmbBxCategory.Text = (string)row.Cells[3].Value;
                    Gn2NUDStck.Value = Convert.ToInt32(row.Cells[5].Value);
                    Gn2TxtBxPrice.Text = (Convert.ToSingle(row.Cells[6].Value)).ToString();
                    CmbBxStatus.Text = (string)row.Cells[7].Value;

                    string imgpath = row.Cells[8].Value.ToString();
                    if(File.Exists(imgpath))
                    {
                        PicBxProd.ImageLocation = imgpath;
                    }
                    PicBxProd.Image = null;

                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message, "DGVProds");
            }
        }

        private void ClearFields()
        {
            Gn2TxtBxPId.Clear();    
            Gn2TxtBxPname.Clear();
            Gn2TxtBxBrand.Clear();
            Gn2TxtBxPrice.Clear();
            CmbBxCategory.SelectedIndex = -1;
            CmbBxStatus.SelectedIndex = -1;
            Gn2NUDStck.Value = 0;
            PicBxProd.Image = null;
        }

        private bool CheckEmptyFields()
        {
            if (string.IsNullOrEmpty(Gn2TxtBxPId.Text) || string.IsNullOrEmpty(Gn2TxtBxPname.Text) || string.IsNullOrEmpty(Gn2TxtBxBrand.Text) || string.IsNullOrEmpty(Gn2TxtBxPrice.Text) ||
                CmbBxCategory.SelectedIndex == -1 || CmbBxStatus.SelectedIndex == -1 || Gn2NUDStck.Value == 0|| PicBxProd.Image == null)
            {
                return true;
            }
            return false;
        }

        private bool ValidPrice(string pricetext, out float price)
        {
            if(float.TryParse(pricetext, out price))
            {
                if (price >= 0)
                {
                    return true;
                }
            }
            return false;
        }

        public void DisplayProducts()
        {
            ProdsData pd = new ProdsData();
            DGVProds.DataSource = pd.ListProducts();
        }

        public void DisplayCategories()
        {
            using(SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    CmbBxCategory.Items.Clear();
                    string seldata = "Select * From Categories";
                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        SqlDataReader sdr = selcmd.ExecuteReader();
                        if (sdr.HasRows)
                        {
                            while (sdr.Read())
                            {
                                CmbBxCategory.Items.Add(sdr["CategoryName"]);
                            }
                        }
                        sdr.Close();

                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex, "DispCats");
                }
            }
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }

            DisplayProducts();
            DisplayCategories();
        }

        
    }
}
