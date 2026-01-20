using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarketMS
{
    public partial class UCDashboard : UserControl
    {
        public UCDashboard()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\SuperMarketMS\SuperMarket.mdf;Integrated Security=True";

        private void UCDashboard_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                try
                {
                    TotalSellersCount();
                    TotalProdsCount();
                    TodayRevenue();
                    TotalRevenue();
                    DisplayAvlPrds();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "CustmsLoad");
                }
            }
        }

        public void TotalSellersCount()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = "Select Count(Id) as TotSlrs From Users Where Role = @role";

                    using (SqlCommand selcmd =  new SqlCommand(seldata, sqlcon))
                    {
                        selcmd.Parameters.AddWithValue("@role", "Seller");

                        SqlDataReader sdr = selcmd.ExecuteReader();  
                        
                        if (sdr.Read())
                        {
                            if (sdr["TotSlrs"] != DBNull.Value)
                            {
                                LbTS.Text = Convert.ToInt32(sdr["TotSlrs"]).ToString();
                            }
                        }

                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex, "TotSellersCnt");
                }
            }
        }

        public void TotalProdsCount()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = "Select Count(Id) as TotPds From Products Where DateDelete is NULL";

                    using (SqlCommand selcmd = new SqlCommand( seldata, sqlcon))
                    {
                        SqlDataReader sdr = selcmd.ExecuteReader();

                        if (sdr.Read())
                        {
                            if (sdr["TotPds"] != DBNull.Value)
                            {
                                LbTPds.Text = Convert.ToInt32(sdr["TotPds"]).ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex, "TotProdsCnt");
                }
            }
        }

        public void TodayRevenue()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = "Select SUM(TotalPrice) as TodRev From Customers Where DateOrder = @dtord";

                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        selcmd.Parameters.AddWithValue("@dtord", DateTime.Today);

                        SqlDataReader sdr = selcmd.ExecuteReader();
                        if (sdr.Read())
                        {
                            if (sdr["TodRev"] != DBNull.Value)
                            {
                                LbTodRev.Text = Convert.ToSingle(sdr["TodRev"]).ToString("C2");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex, "TodRev");
                }
            }
        }

        public void TotalRevenue()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = "Select SUM(TotalPrice) as TotRev From Customers";

                    using (SqlCommand selcmd = new SqlCommand( seldata, sqlcon))
                    {
                        SqlDataReader sdr = selcmd.ExecuteReader();
                        if (sdr.Read())
                        {
                            if (sdr["TotRev"] != DBNull.Value)
                            {
                                LbTotRev.Text = Convert.ToSingle(sdr["TotRev"]).ToString("C2");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex, "TotRev");
                }
            }
        }

        public void Top3Brands()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = "Select * From Orders";
                    using (SqlCommand selcmd = new SqlCommand (seldata, sqlcon))
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(selcmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        //Chart1.DataSource = dt; 
                        //Chart1.DataBind();

                        //Chart1.Series[0].XValueMember = "Brand";
                        //Chart1.Series[0].YValueMembers = "Brand";

                        //Chart1.Series[1].XValueMember = "";
                    }
                }
                catch (Exception ex)
                {

                }
            }
            
        }

        public void DisplayAvlPrds()
        {
            ProdsData pd = new ProdsData();
            DGVDashboard.DataSource = pd.ListAvlProducts();
        }

        public void RefreshData()
        {
            if(InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }

            TotalSellersCount();
            TotalProdsCount();  
            TodayRevenue();
            TotalRevenue();
            DisplayAvlPrds();
        }

    }
}
