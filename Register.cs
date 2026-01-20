using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace SuperMarketMS
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }


        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\SuperMarketMS\SuperMarket.mdf;Integrated Security = True";

        private void Gn2BtnSignUp_Click(object sender, EventArgs e)
        {
            if (CmbBxRole.SelectedIndex == -1)
            {
                Gn2MD6.Show(); return;
            }
            if (string.IsNullOrEmpty(Gn2TBUsername.Text) || string.IsNullOrEmpty(Gn2TBPswrd.Text) || string.IsNullOrEmpty(Gn2TBCnfmPswrd.Text))
            {
                Gn2MD1.Show(); return;
            }
            if (Gn2TBPswrd.Text.Length < 8)
            {
                Gn2MD2.Show(); return;
            }
            if (Gn2TBPswrd.Text.Trim() != Gn2TBCnfmPswrd.Text.Trim())
            {
                Gn2MD3.Show(); return;
            }
            else
            {
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        string chkun = "Select Count(Id) From Users Where Username = @un";
                        using (SqlCommand chkuncmd = new SqlCommand(chkun, sqlcon))
                        {
                            chkuncmd.Parameters.AddWithValue("@un", Gn2TBUsername.Text.Trim());
                            int rc = 0;
                            object result = chkuncmd.ExecuteScalar();
                            if (result != DBNull.Value)
                            {
                                rc = (int)result;
                            }

                            if (rc > 0)
                            {
                                string tempun = $"{Gn2TBUsername.Text.Trim().Substring(0, 1).ToUpper()}{Gn2TBUsername.Text.Trim().Substring(1)}";
                                Gn2MD5.Show($"Username: {tempun} is Existing Already.. Use a Different name");
                                return;
                            }

                        }
                        string insdata = "Insert Into Users (Username, Password, Role, Status, DateRegister) Values (@un, @pswrd, @role, @st, @dtrg)";
                        using (SqlCommand inscmd = new SqlCommand(insdata, sqlcon))
                        {
                            inscmd.Parameters.AddWithValue("@un", Gn2TBUsername.Text.Trim());
                            inscmd.Parameters.AddWithValue("@pswrd", Gn2TBPswrd.Text.Trim());
                            inscmd.Parameters.AddWithValue("@role", CmbBxRole.Text.Trim());
                            inscmd.Parameters.AddWithValue("@st", "Active");
                            inscmd.Parameters.AddWithValue("@dtrg", DateTime.Today);

                            inscmd.ExecuteNonQuery();

                            Gn2MD4.Show();

                            FormLogin frmlgn = new FormLogin();
                            frmlgn.Show();
                            Hide();
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "Register");
                    }
                }
            }
        }

        private void Gn2BtnSignin_Click(object sender, EventArgs e)
        {
            FormLogin frmlgn = new FormLogin();   
            frmlgn.Show();
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
            Gn2TBCnfmPswrd.UseSystemPasswordChar = !Gn2ChkBx1.Checked;
        }
    }
}
