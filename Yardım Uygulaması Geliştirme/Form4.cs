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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Text = textBox1.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int hissesayısı;
            int kurbantoplam;

            hissesayısı = Convert.ToInt32(label2.Text);
            kurbantoplam = hissesayısı * 850;

            textBox2.Text = kurbantoplam.ToString(); 

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
