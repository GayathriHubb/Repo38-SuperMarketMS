using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SuperMarketMS
{
    internal class CustomersData
    {
        public CustomersData() { }

        readonly string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\SuperMarketMS\SuperMarket.mdf;Integrated Security=True";

        public int Id { get; set; }
        public string CustId { get; set; }
        public float TotalPrice { get; set; }
        public float TenderedCash {  get; set; }
        public float TenderedChange {  get; set; }
        public string DateOrder { get; set; }

        public List<CustomersData> ListCustomers()
        {
            List<CustomersData> cdlst = new List<CustomersData>();

            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = "Select * From Customers";
                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        SqlDataReader sdr = selcmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            CustomersData cd = new CustomersData();

                            cd.Id = (int)sdr["Id"];
                            cd.CustId = (string)sdr["CustId"];
                            cd.TotalPrice = Convert.ToSingle(sdr["TotalPrice"]);
                            cd.TenderedCash = Convert.ToSingle(sdr["Amount"]);
                            cd.TenderedChange = Convert.ToSingle(sdr["Change"]);
                            cd.DateOrder = (Convert.ToDateTime(sdr["DateOrder"])).ToString("dd-MM-yyyy");

                            cdlst.Add(cd);  
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "CustmsData");
                }
            }
            return cdlst;

        }
    }
}
