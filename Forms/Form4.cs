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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            
        }

        
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            this.Close();
            Form5 frm5 = new Form5();
            frm5.Show();



        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
            Form7 frm7 = new Form7();
            frm7.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Close();
            Form9 frm9 = new Form9();
            frm9.Show();
        }
    }
}
