using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yardım_Uygulaması_Geliştirme
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            int makarnafiyat, bulgurfiyat, sıvıyağfiyat, unfiyat;
            int tuzfiyat, şekerfiyat, nohutfiyat, salçafiyat;

            if (checkBox1.Checked)
            {
                makarnafiyat = Convert.ToInt32(label1.Text);
                toplam = toplam + makarnafiyat;
            }

            if (checkBox2.Checked)
            {
                bulgurfiyat = Convert.ToInt32(label2.Text);
                toplam = toplam + bulgurfiyat;
            }

            if (checkBox3.Checked)
            {
                sıvıyağfiyat = Convert.ToInt32(label3.Text);
                toplam = toplam + sıvıyağfiyat;
            }

            if (checkBox4.Checked)
            {
                unfiyat = Convert.ToInt32(label4.Text);
                toplam = toplam + unfiyat;
            }

            if (checkBox5.Checked)
            {
                tuzfiyat = Convert.ToInt32(label5.Text);
                toplam = toplam + tuzfiyat;
            }

            if (checkBox6.Checked)
            {
                şekerfiyat = Convert.ToInt32(label6.Text);
                toplam = toplam + şekerfiyat;
            }

            if (checkBox7.Checked)
            {
                nohutfiyat = Convert.ToInt32(label7.Text);
                toplam = toplam + nohutfiyat;
            }

            if (checkBox8.Checked)
            {
                salçafiyat = Convert.ToInt32(label8.Text);
                toplam = toplam + salçafiyat;
            }

            textBox1.Text = toplam.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
