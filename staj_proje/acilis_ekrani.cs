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
            this.Close();
        }


    }
}
