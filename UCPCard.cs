using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarketMS
{
    public partial class UCPCard : UserControl
    {
        public UCPCard()
        {
            InitializeComponent();
        }

        public int Id { get; set; }
        public string ProdId { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }

        public string PdName
        {
            get { return LbPdName.Text; }
            set { LbPdName.Text = value; }
        }

        public string Stock
        {
            get { return LbStock.Text; }
            set { LbStock.Text = value; }
        }

        public string Price
        {
            get { return LbPrice.Text; }
            set { LbPrice.Text = value; }
        }

        public string PdImage
        {
            get { return PicBxPd.ImageLocation; }
            set {  PicBxPd.ImageLocation = value; }
        }

        public int PdQty
        {
            get { return (int)NUDQty.Value; }
            set { NUDQty.Value = (int)value; }
        }

        public event EventHandler SelectCard = null;
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SelectCard.Invoke(this, EventArgs.Empty);   
        }

       
    }
}
