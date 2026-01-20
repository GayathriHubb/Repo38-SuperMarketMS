using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarketMS
{
    public partial class FormLoad : Form
    {
        public FormLoad()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Gn2PB1.Value += 1;

            if (Gn2PB1.Value >= 100)
            {
                Timer1.Stop();

                FormLogin frmlgn = new FormLogin();
                frmlgn.Show();
                Hide();
            }
        }
    }
}
