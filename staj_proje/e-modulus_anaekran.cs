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
    public partial class e_modulus_anaekran: Form
    {
        public e_modulus_anaekran()
        {
            InitializeComponent();
        }
        TextBox aktifTextBox = null;
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

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Data saved successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void textBox4_MouseDown(object sender, MouseEventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_MouseDown(object sender, MouseEventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void textBox2_MouseDown(object sender, MouseEventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            aktifTextBox = textBox1;
            aktifTextBox.Clear();
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            aktifTextBox = textBox4;
            aktifTextBox.Clear();
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            aktifTextBox = textBox3;
            aktifTextBox.Clear();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            aktifTextBox = textBox2;
            aktifTextBox.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (aktifTextBox != null)
            {
                Button btn = sender as Button;
                aktifTextBox.Text += btn.Text;

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (aktifTextBox != null)
            {
                Button btn = sender as Button;
                aktifTextBox.Text += btn.Text;

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {

            if (aktifTextBox != null)
            {
                Button btn = sender as Button;
                aktifTextBox.Text += btn.Text;

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (aktifTextBox != null)
            {
                Button btn = sender as Button;
                aktifTextBox.Text += btn.Text;

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

            if (aktifTextBox != null)
            {
                Button btn = sender as Button;
                aktifTextBox.Text += btn.Text;

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {

            if (aktifTextBox != null)
            {
                Button btn = sender as Button;
                aktifTextBox.Text += btn.Text;

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (aktifTextBox != null)
            {
                Button btn = sender as Button;
                aktifTextBox.Text += btn.Text;

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

            if (aktifTextBox != null)
            {
                Button btn = sender as Button;
                aktifTextBox.Text += btn.Text;

            }
        }

        private void button15_Click(object sender, EventArgs e)
        {

            if (aktifTextBox != null)
            {
                Button btn = sender as Button;
                aktifTextBox.Text += btn.Text;

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (aktifTextBox != null)
            {
                Button btn = sender as Button;
                aktifTextBox.Text += btn.Text;

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

            if (aktifTextBox != null)
            {
                Button btn = sender as Button;
                aktifTextBox.Text += btn.Text;

            }
        }

        private void button16_Click(object sender, EventArgs e)
        {

            if (aktifTextBox != null)
            {
                Button btn = sender as Button;
                aktifTextBox.Text += btn.Text;

            }
        }

        private void button17_Click(object sender, EventArgs e)
        {

            if (aktifTextBox != null && aktifTextBox.Text.Length > 0)
            {
                Button btn = sender as Button;
                aktifTextBox.Text = aktifTextBox.Text.Substring(0, aktifTextBox.Text.Length - 1);

            }
        }
    }
}
