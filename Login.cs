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

namespace SuperMarketMS
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\SuperMarketMS\SuperMarket.mdf;Integrated Security = True";

        private void Gn2BtnLogin_Click(object sender, EventArgs e)
        {
            if (CmbBxRole.SelectedIndex == -1)
            {
                Gn2MD1.Show(); return;
            }
            if (string.IsNullOrEmpty(Gn2TBUsername.Text) || string.IsNullOrEmpty(Gn2TBPswrd.Text))
            {
                Gn2MD2.Show(); return;
            }
            else
            {
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        string chkdata = "Select Count(*) From Users Where Username = @un AND Password = @pswrd AND Role = @role";

                        using (SqlCommand selcmd = new SqlCommand(chkdata, sqlcon))
                        {
                            selcmd.Parameters.AddWithValue("@un", Gn2TBUsername.Text.Trim());
                            selcmd.Parameters.AddWithValue("@pswrd", Gn2TBPswrd.Text.Trim());
                            selcmd.Parameters.AddWithValue("@role", CmbBxRole.Text.Trim());

                            int rc = 0;
                            object result = selcmd.ExecuteScalar();
                            if (result != DBNull.Value)
                            {
                                rc = Convert.ToInt32(result);
                            }

                            if (rc > 0)
                            {
                                Gn2MD4.Show(); 

                                if (CmbBxRole.Text.Trim() == "Admin")
                                {
                                    SuperMarketData.Username = Gn2TBUsername.Text;
                                    AdminMainForm amf = new AdminMainForm();
                                    amf.Show();
                                    Hide();
                                }
                                if (CmbBxRole.Text.Trim() == "Seller")
                                {
                                    SuperMarketData.Username = Gn2TBUsername.Text;
                                    StaffMainForm smf = new StaffMainForm();
                                    smf.Show();
                                    Hide();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Credentials/Role", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex, "Login");
                    }
                }
            }
        }
        private void Gn2BtnRegister_Click(object sender, EventArgs e)
        {
            FormRegister frmrg = new FormRegister();
            frmrg.Show();
            Hide();
        }

        private void Gn2BtnClear_Click(object sender, EventArgs e)
        {
            Gn2TBUsername.Clear();
            Gn2TBPswrd.Clear();
        }

        private void Gn2ChkBx1_CheckedChanged(object sender, EventArgs e)
        {
            Gn2TBPswrd.UseSystemPasswordChar = !Gn2ChkBx1.Checked;
        }
    }
}
