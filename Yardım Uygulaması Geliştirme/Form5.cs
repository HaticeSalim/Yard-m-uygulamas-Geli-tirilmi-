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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label2.Text = textBox1.Text;
            }

            if (radioButton2.Checked)
            {
                label2.Text = textBox1.Text;
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            float zekat=0;
            float malvarlığı;
            malvarlığı = Convert.ToInt32(label2.Text);

            if (radioButton1.Checked && malvarlığı > 28000)
            {
                malvarlığı = Convert.ToInt32(label2.Text);
                zekat = (malvarlığı *25)/1000 ;
            }

            if(radioButton2.Checked && malvarlığı > 80)
            {
                malvarlığı = Convert.ToInt32(label2.Text);
                zekat = (malvarlığı *25)/1000;
            }

            textBox2.Text= zekat.ToString();

           

        }

        
    }
}
