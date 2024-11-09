using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aracSatis
{
    public partial class Islem : Form
    {


        public Islem()
        {
            InitializeComponent();
        }



        private void bAracAl_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
           f1.ShowDialog();
        }


        private void bAracSat_Click(object sender, EventArgs e)
        {
            aracSat aracSat = new aracSat();
            aracSat.ShowDialog();
        }
    }
}
