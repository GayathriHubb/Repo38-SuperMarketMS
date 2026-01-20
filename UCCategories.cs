using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarketMS
{
    public partial class UCCategories : UserControl
    {
        public UCCategories()
        {
            InitializeComponent();
        }
        readonly string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\SuperMarketMS\SuperMarket.mdf;Integrated Security=True";

        private void UCCategories_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                try
                {
                    DisplayCategories();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex, "CategoriesLoad");
                }
            }
        }

        private void Gn2GBtnIns_Click(object sender, EventArgs e)
        {
            if (CheckEmptyFields())
            {
                MessageBox.Show("Empty Fields.. Pls Fill All the Fields Properly", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        string chkcatid = "Select Count(Id) From Categories Where CategoryId = @catid";

                        using (SqlCommand chkcmd = new SqlCommand(chkcatid, sqlcon))
                        {
                            chkcmd.Parameters.AddWithValue("@catid", Gn2TBCatId.Text.Trim());
                            int rc = 0;
                            object result = chkcmd.ExecuteScalar();
                            if (result != DBNull.Value)
                            {
                                rc = (int)result;
                            }

                            if (rc > 0)
                            {
                                MessageBox.Show($"CategoryId: {Gn2TBCatId.Text.Trim()} is Existing Already", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                                return;
                            }

                            string insdata = "Insert Into Categories (CategoryId, CategoryName, Status, DateInsert) Values (@catid, @catname, @st, @dtins)";
                            using (SqlCommand inscmd = new SqlCommand(insdata, sqlcon))
                            {
                                inscmd.Parameters.AddWithValue("@catid", Gn2TBCatId.Text.Trim());
                                inscmd.Parameters.AddWithValue("@catname", Gn2TBCatName.Text.Trim());
                                inscmd.Parameters.AddWithValue("@st", CmbBxStatus.Text.Trim());
                                inscmd.Parameters.AddWithValue("@dtins", DateTime.Today);

                                inscmd.ExecuteNonQuery();

                                DisplayCategories();
                                MessageBox.Show("Category Record Inserted Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                ClearFields();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex, "CatIns");
                    }
                }
            }
        }

        private void Gn2BtnUpd_Click(object sender, EventArgs e)
        {
            if(CheckEmptyFields())
            {
                MessageBox.Show("Empty Fields.. Pls Fill All the Fields Properly", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show($"Are you Sure to Update Id: {id} ?", "Update Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (SqlConnection sqlcon = new SqlConnection(constring))
                    {
                        try
                        {
                            sqlcon.Open();

                            string chkcatid = "Select Count(Id) From Categories Where CategoryId = @catid";

                            using (SqlCommand chkcmd = new SqlCommand(chkcatid, sqlcon))
                            {
                                chkcmd.Parameters.AddWithValue("@catid", Gn2TBCatId.Text.Trim());

                                int rc = 0;
                                object result = chkcmd.ExecuteScalar();
                                if (result != DBNull.Value)
                                {
                                    rc = (int)result;
                                }

                                if (rc >= 2)
                                {
                                    MessageBox.Show($"CategoryId: {Gn2TBCatId.Text.Trim()} is Existing Already", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                                    return;
                                }
                                string upddata = "Update Categories Set CategoryId = @catid, CategoryName = @ctname, Status = @status, DataUpdate = @dtupd Where Id = @id";

                                using (SqlCommand updcmd = new SqlCommand(upddata, sqlcon))
                                {
                                    updcmd.Parameters.AddWithValue("@catid", Gn2TBCatId.Text.Trim());
                                    updcmd.Parameters.AddWithValue("@ctname", Gn2TBCatName.Text.Trim());
                                    updcmd.Parameters.AddWithValue("@st", CmbBxStatus.Text.Trim());
                                    updcmd.Parameters.AddWithValue("@dtupd", DateTime.Today);
                                    updcmd.Parameters.AddWithValue("@id", id);

                                    updcmd.ExecuteNonQuery();
                                    DisplayCategories();
                                    MessageBox.Show("Category Record Updated Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                    ClearFields();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex, "CatUpd");
                        }
                    }
                }
            }
        }

        private void Gn2BtnDel_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(Gn2TBCatId.Text) || id == 0)
            {
                MessageBox.Show("Pls Select Record First or Enter CategoryId to Delete", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show($"Are you Sure to Delete Id: {id} ?", "Delete Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (SqlConnection sqlcon = new SqlConnection(constring))
                    {
                        try
                        {
                            sqlcon.Open();

                            string deldata = "Delete From Categories Where CategoryId = @catid AND Id = @id";

                            using (SqlCommand delcmd = new SqlCommand(deldata, sqlcon))
                            {
                                delcmd.Parameters.AddWithValue("@catid", Gn2TBCatId.Text.Trim());
                                delcmd.Parameters.AddWithValue("@id", id);

                                delcmd.ExecuteNonQuery();
                                DisplayCategories();
                                MessageBox.Show("Category Record Deleted Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                ClearFields();
                            }
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex, "CatDel");
                        }
                    }
                }
            }
        }

        private void Gn2BtnClr_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        

        private void ClearFields()
        {
            Gn2TBCatId.Clear();
            Gn2TBCatName.Clear();
            CmbBxStatus.SelectedIndex = -1;
        }

        private bool CheckEmptyFields()
        {
            if(string.IsNullOrEmpty(Gn2TBCatId.Text) || string.IsNullOrEmpty(Gn2TBCatName.Text) || CmbBxStatus.SelectedIndex == -1)
            {
                return true;
            }
            return false;
        }

        public void DisplayCategories()
        {
            CategoriesData cd = new CategoriesData();
            DGVCategories.DataSource = cd.ListCategories();
        }

        public void RefreshData()
        {
            if(InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }

            DisplayCategories();
        }

        int id;
        private void DGVCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    DataGridViewRow row = DGVCategories.Rows[e.RowIndex];

                    id = (int)row.Cells[0].Value;
                    Gn2TBCatId.Text = (string)row.Cells[1].Value;
                    Gn2TBCatName.Text = (string)row.Cells[2].Value;
                    CmbBxStatus.Text = (string)row.Cells[3].Value;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message, "DGVCats");
            }
        }





            
        
    }
}
