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
    public partial class ana_ekran: Form
    {
        public ana_ekran()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            acilis_ekrani acik = new acilis_ekrani();
            acik.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            test_bolumu test = new test_bolumu();
            test.Show();
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
