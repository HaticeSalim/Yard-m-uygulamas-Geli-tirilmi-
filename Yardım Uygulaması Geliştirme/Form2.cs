﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 temelıhtıyacsecenek = new Form3();
            temelıhtıyacsecenek.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 kurbanbağışsecenek = new Form4();
            kurbanbağışsecenek.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 zekatsecenek = new Form5();
            zekatsecenek.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 sadakasecenek = new Form6();
            sadakasecenek.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 zekatsecenek = new Form7();
            zekatsecenek.Show();
            this.Hide();
        }
    }
}
