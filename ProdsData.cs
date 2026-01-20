using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SuperMarketMS
{
    internal class ProdsData
    {
        public ProdsData() { }

        readonly string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\SuperMarketMS\SuperMarket.mdf;Integrated Security=True";

        public int Id { get; set; }
        public string ProdId { get; set; } // 1
        public string ProdName { get; set; } // 2
        public string Category { get; set; } // 3
        public string Brand  { get; set; } // 4
        public int Stock { get; set; } // 5
        public float Price { get; set; } // 6
        public string Status { get; set; } // 7
        public string ImagePath { get; set; } // 8
        public string DateInsert { get; set; } // 9
        public string DateUpdate { get; set; } // 10

        public List<ProdsData> ListProducts()
        {
            List<ProdsData> pdslst = new List<ProdsData>();

            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = "Select * From Products Where DateDelete is NULL AND ProdStatus != 'Deleted'";

                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        SqlDataReader sdr = selcmd.ExecuteReader();

                        while (sdr.Read())
                        {
                            ProdsData pd = new ProdsData();

                            pd.Id = (int)sdr["Id"];
                            pd.ProdId = (string)sdr["ProdId"];
                            pd.ProdName = (string)sdr["ProdName"];
                            pd.Category = (string)sdr["CategoryName"];
                            pd.Brand = (string)sdr["Brand"];
                            pd.Stock = (int)sdr["ProdStock"];
                            pd.Price = Convert.ToSingle(sdr["ProdPrice"]);
                            pd.Status = (string)sdr["ProdStatus"];
                            pd.ImagePath = (string)sdr["ImagePath"];
                            pd.DateInsert = (Convert.ToDateTime(sdr["DateInsert"])).ToString("dd-MM-yyyy hh:mm tt");
                            pd.DateUpdate = (sdr["DateUpdate"] != DBNull.Value) ? (Convert.ToDateTime(sdr["DateUpdate"]).ToString("dd-MM-yyyy")) : null;

                            pdslst.Add(pd);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "ProdsData");
                }
            }
            return pdslst;
        }

        public List<ProdsData> ListAvlProducts()
        {
            List<ProdsData> pdslst = new List<ProdsData>();

            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = "Select * From Products Where DateDelete is NULL AND ProdStatus = @st";

                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        selcmd.Parameters.AddWithValue("@st", "Available");
                        SqlDataReader sdr = selcmd.ExecuteReader();

                        while (sdr.Read())
                        {
                            ProdsData pd = new ProdsData();

                            pd.Id = (int)sdr["Id"];
                            pd.ProdId = (string)sdr["ProdId"];
                            pd.ProdName = (string)sdr["ProdName"];
                            pd.Category = (string)sdr["CategoryName"];
                            pd.Brand = (string)sdr["Brand"];
                            pd.Stock = (int)sdr["ProdStock"];
                            pd.Price = Convert.ToSingle(sdr["ProdPrice"]);
                            pd.Status = (string)sdr["ProdStatus"];
                            pd.ImagePath = (string)sdr["ImagePath"];
                            pd.DateInsert = (Convert.ToDateTime(sdr["DateInsert"])).ToString("dd-MM-yyyy hh:mm tt");
                            pd.DateUpdate = (sdr["DateUpdate"] != DBNull.Value) ? (Convert.ToDateTime(sdr["DateUpdate"]).ToString("dd-MM-yyyy")) : null;

                            pdslst.Add(pd);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "ProdsData");
                }
            }
            return pdslst;
        }
    }
}
