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
    public partial class beams4_anaekran: Form
    {
        public beams4_anaekran()
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

        private void textBox3_MouseDown(object sender, MouseEventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void textBox2_MouseDown(object sender, MouseEventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void textBox5_MouseDown(object sender, MouseEventArgs e)
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

        private void textBox5_Enter(object sender, EventArgs e)
        {
            aktifTextBox = textBox5;
            aktifTextBox.Clear();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (aktifTextBox != null)
            {
                Button btn = sender as Button;
                aktifTextBox.Text += btn.Text;

            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (aktifTextBox != null)
            {
                Button btn = sender as Button;
                aktifTextBox.Text += btn.Text;

            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (aktifTextBox != null)
            {
                Button btn = sender as Button;
                aktifTextBox.Text += btn.Text;

            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (aktifTextBox != null)
            {
                Button btn = sender as Button;
                aktifTextBox.Text += btn.Text;

            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (aktifTextBox != null)
            {
                Button btn = sender as Button;
                aktifTextBox.Text += btn.Text;

            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (aktifTextBox != null)
            {
                Button btn = sender as Button;
                aktifTextBox.Text += btn.Text;

            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (aktifTextBox != null)
            {
                Button btn = sender as Button;
                aktifTextBox.Text += btn.Text;

            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (aktifTextBox != null)
            {
                Button btn = sender as Button;
                aktifTextBox.Text += btn.Text;

            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (aktifTextBox != null)
            {
                Button btn = sender as Button;
                aktifTextBox.Text += btn.Text;

            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (aktifTextBox != null)
            {
                Button btn = sender as Button;
                aktifTextBox.Text += btn.Text;

            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (aktifTextBox != null)
            {
                Button btn = sender as Button;
                aktifTextBox.Text += btn.Text;

            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (aktifTextBox != null)
            {
                Button btn = sender as Button;
                aktifTextBox.Text += btn.Text;

            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (aktifTextBox != null && aktifTextBox.Text.Length > 0)
            {
                Button btn = sender as Button;
                aktifTextBox.Text = aktifTextBox.Text.Substring(0, aktifTextBox.Text.Length - 1);

            }
        }
    }
}
