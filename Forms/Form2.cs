﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mortal_Combat
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
            textBox1.Text = "";
            textBox3.PasswordChar = '*';
            textBox1.MaxLength = 8;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {

                MessageBox.Show("Please write it is empty!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                try
                {

                    using (MailMessage mail = new MailMessage())
                    {
                        //write your maile addres
                        mail.From = new MailAddress("***********@gmail.com");
                        mail.To.Add(textBox2.Text);
                        mail.Subject = "Fight Game";
                        mail.Body = "<h1>Thank You, you have successfully Registered!</h1>";
                        mail.IsBodyHtml = true;

                        using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                        {
                            //add your gmail key in passwd repository
                            smtp.Credentials = new System.Net.NetworkCredential("***********@gmail.com", "passwd");
                            smtp.EnableSsl = true;
                            smtp.Send(mail);
                            label1.Text = "Send Mail";

                            //pakvi hajorty bacvi 
                            this.Close();
                            Form3 frm3 = new Form3();
                            frm3.Show();

                        }

                    }
                }
                catch (Exception ex)
                {
                    label1.Text =  ex.Message;
                }

            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
                    }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
