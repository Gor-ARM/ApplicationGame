﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mortal_Combat
{
    public partial class Form3 : Form
    {
        Form4 bb = new Form4();
        public Form3()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 1000;
            progressBar1.Maximum = 10;
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 10)
            {
                progressBar1.Value++;
            }
            else
            {
                timer1.Stop();
                bb.Show();
                this.WindowState = FormWindowState.Minimized;
            }
        }
    }
}
