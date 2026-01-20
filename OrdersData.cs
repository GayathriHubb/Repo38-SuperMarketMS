using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SuperMarketMS
{
    public class OrdersData
    {
        readonly string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\SuperMarketMS\SuperMarket.mdf;Integrated Security=True";

        public string CustId { get; set; }
        public int Id { get; set; }
        public string ProdName { get; set; }
        public string Brand { get; set; }
        public int Qty { get; set; }
        public float Price { get; set; }
        public string PdId { get; set; }

        
    }
}
