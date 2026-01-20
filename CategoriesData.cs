using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SuperMarketMS
{
    internal class CategoriesData
    {
        public CategoriesData() { }

        readonly string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\SuperMarketMS\SuperMarket.mdf;Integrated Security=True";

        public int Id { get; set; }
        public string CategoryId {  get; set; }
        public string CategoryName { get; set; }
        public string Status { get; set; }
        public string DateInsert { get; set; }

        public List<CategoriesData> ListCategories()
        {
            List<CategoriesData> catslst = new List<CategoriesData>();

            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = "Select * From Categories";

                    using (SqlCommand selcmd =  new SqlCommand(seldata, sqlcon))
                    {
                        SqlDataReader sdr = selcmd.ExecuteReader();

                        while (sdr.Read())
                        {
                            CategoriesData cd = new CategoriesData();

                            cd.Id = (int)sdr["Id"];
                            cd.CategoryId = (string)sdr["CategoryId"];
                            cd.CategoryName = (string)sdr["CategoryName"];
                            cd.Status = (string)sdr["Status"];
                            cd.DateInsert = (Convert.ToDateTime(sdr["DateInsert"])).ToString("dd-MM-yyyy");

                            catslst.Add(cd);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex, "CategoriesData");
                }
            }

            return catslst;
        }
    }
}
