using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SuperMarketMS
{
    internal class UsersData
    {
        public UsersData() { }
        
        readonly string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\SuperMarketMS\SuperMarket.mdf;Integrated Security=True";

        public int Id { get; set; }
        public string SellerName { get; set; }
        public string Password { get; set; }
        public string DOB {  get; set; }
        public string Status { get; set; }
        public string DateInsert { get; set; }

        public List<UsersData> ListUsers()
        {
            List<UsersData> usrslst = new List<UsersData>();

            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = "Select * From Users Where Role = @role";

                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        selcmd.Parameters.AddWithValue("@role", "Seller");
                        SqlDataReader sdr = selcmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            UsersData ud = new UsersData();

                            ud.Id = (int)sdr["Id"];
                            ud.SellerName = (string)sdr["Username"];
                            ud.Password = (string)sdr["Password"];
                            ud.Status = (string)sdr["Status"];
                            ud.DateInsert = (Convert.ToDateTime(sdr["DateRegister"])).ToString("dd-MM-yyyy");

                            ud.DOB = (sdr["DOB"] != DBNull.Value) ? (Convert.ToDateTime(sdr["DOB"])).ToString("dd-MM-yyyy") : null;

                            usrslst.Add(ud);
                        }
                    }
                        
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex, "UsersData");
                }

                return usrslst;
            }


        }
    }
}
