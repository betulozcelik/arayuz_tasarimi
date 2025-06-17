using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace staj_proje
{
    public partial class test_bolumu: Form
    {
        public test_bolumu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ana_ekran ekran = new ana_ekran();
            ekran.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            grafik ciz = new grafik();
            ciz.Show();
            this.Hide();
        }
    }
}
