using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitap_indirimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Kitapadet=Convert.ToInt32(textBox1.Text);
            double toplam;
            if (Kitapadet > 0 && Kitapadet <= 20)
            {
                toplam = (Kitapadet * 8) - (Kitapadet * 8 * 0.20);
                label3.Text = toplam + " TL";
            }
         
            if (Kitapadet>=21 && Kitapadet <=40)
            {
                toplam = (Kitapadet * 8)  - (Kitapadet * 8 * 0.40);
                label3.Text = toplam + " TL";
            }  
            if (Kitapadet>=41)
            {
                toplam = (Kitapadet * 8)  - (Kitapadet * 8 * 0.50);
                label3.Text = toplam + " TL";
            }
        }
    }
}
