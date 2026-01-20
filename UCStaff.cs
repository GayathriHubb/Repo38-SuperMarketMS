using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;

namespace SuperMarketMS
{
    public partial class UCStaff : UserControl
    {
        public UCStaff()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\SuperMarketMS\SuperMarket.mdf;Integrated Security=True";

        private void UCStaff_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                try
                {
                    DisplayUsers();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex, "UCStaffLoad");
                }
            }
        }

        private void Gn2GBtnIns_Click(object sender, EventArgs e)
        {
            if (CheckEmptyFields())
            {
                Gn2MD1.Show();
                return;
            }
            else
            {
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        string insdata = "Insert Into Users (Username, Password, Role, Status, DateRegister, DOB) Values (@un, @pswrd, @role, @status, @dtrg, @dob)";
                        using (SqlCommand inscmd = new SqlCommand(insdata, sqlcon))
                        {
                            inscmd.Parameters.AddWithValue("@un", Gn2TBName.Text.Trim());
                            inscmd.Parameters.AddWithValue("@pswrd", Gn2TBPswrd.Text.Trim());
                            inscmd.Parameters.AddWithValue("@role", "Seller");
                            inscmd.Parameters.AddWithValue("@status", "Active");
                            inscmd.Parameters.AddWithValue("@dtrg", DateTime.Today);
                            inscmd.Parameters.AddWithValue("@dob", MskdTBDOB.Text);

                            inscmd.ExecuteNonQuery();
                            DisplayUsers();
                            MessageBox.Show("User Record Inserted Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            ClearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex, "StaffIns");
                    }
                }
            }
        }

        private void Gn2BtnUpd_Click(object sender, EventArgs e)
        {
            if (CheckEmptyFields())
            {
                Gn2MD1.Show();
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

                            string upddata = "Update Users Set Username = @un, Password = @pswrd, DOB = @dob, Status = @st Where Id = @id";
                            using (SqlCommand updcmd = new SqlCommand(upddata, sqlcon))
                            {
                                updcmd.Parameters.AddWithValue("@un", Gn2TBName.Text.Trim());
                                updcmd.Parameters.AddWithValue("@pswrd", Gn2TBPswrd.Text.Trim());
                                updcmd.Parameters.AddWithValue("@dob", MskdTBDOB.Text);
                                updcmd.Parameters.AddWithValue("@st", CmbBxStatus.Text.Trim());

                                updcmd.ExecuteNonQuery();
                            }
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex, "StaffUpd");
                        }
                    }
                }

            }
        }

        private void Gn2BtnDel_Click(object sender, EventArgs e)
        {
           if (string.IsNullOrEmpty(Gn2TBName.Text) || id == 0)
           {
                MessageBox.Show("Pls Select Record First", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
           }
           else
           {
                DialogResult dr = MessageBox.Show($"Are you Sure to Delete Id: {id} ? ", "Delete Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (SqlConnection sqlcon = new SqlConnection(constring))
                    {
                        try
                        {
                            sqlcon.Open();

                            string deldata = "Delete From Users Where Id = @id";
                            using (SqlCommand delcmd = new SqlCommand(deldata, sqlcon))
                            {
                                delcmd.Parameters.AddWithValue("@id", id);

                                delcmd.ExecuteNonQuery();

                                DisplayUsers();
                                MessageBox.Show("User Record Deleted Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                ClearFields();  
                            }
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex, "StaffDel");
                        }
                    }
                }

           }
        }

        private void Gn2BtnClr_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        int id;
        private void DGVUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = DGVUsers.Rows[e.RowIndex];

                    Gn2TBName.Text = row.Cells[1].Value?.ToString();
                    Gn2TBPswrd.Text = row.Cells[2].Value?.ToString();
                    MskdTBDOB.Text = row.Cells[3].Value?.ToString();
                    CmbBxStatus.Text = row.Cells[4].Value?.ToString();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex, "DGVUsers");
            }
        }

        private void ClearFields()
        {
            Gn2TBName.Clear();
            Gn2TBPswrd.Clear();
            MskdTBDOB.Clear();
            CmbBxStatus.SelectedIndex = -1;
        }

        private bool CheckEmptyFields()
        {
            if (string.IsNullOrEmpty(Gn2TBName.Text) || string.IsNullOrEmpty(Gn2TBPswrd.Text) ||
                string.IsNullOrEmpty(MskdTBDOB.Text) || CmbBxStatus.SelectedIndex == -1)
            {
                return true;
            }
            return false;
        }

        public void DisplayUsers()
        {
            UsersData ud = new UsersData();
            DGVUsers.DataSource = ud.ListUsers();
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            DisplayUsers();
        }
    }   
    
}
