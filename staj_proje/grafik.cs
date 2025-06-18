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
    public partial class grafik: Form
    {
        public grafik()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            test_bolumu test = new test_bolumu();
            test.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sonuclar sonuc = new sonuclar();
            sonuc.Show();
            this.Close();

        }

        private void grafik_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            sonuclar sonuc = new sonuclar();
            sonuc.Show();
            this.Hide();
        }
    }
}
