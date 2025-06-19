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
    public partial class acilis_ekrani: Form
    {
        public acilis_ekrani()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ana_ekran ekran = new ana_ekran();
            ekran.Show();

        }

        private void acilis_ekrani_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cylinder_anaekran ekran = new cylinder_anaekran();
            ekran.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            brick_anaekran ekran = new brick_anaekran();
            ekran.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            e_modulus_anaekran ekran = new e_modulus_anaekran();
            ekran.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            beams3_anaekran ekran = new beams3_anaekran();
            ekran.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            beams4_anaekran ekran = new beams4_anaekran();
            ekran.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            border_stones_anaekran ekran = new border_stones_anaekran();
            ekran.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            shear_blocks_anaekran ekran = new shear_blocks_anaekran();
            ekran.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            shear_stones_anaekran ekran = new shear_stones_anaekran();
            ekran.Show();
        }
    }
}
