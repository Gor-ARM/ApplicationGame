using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//new add
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;
namespace Mortal_Combat
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        [DllImport("UnityPlayer.dll")]
        static extern IntPtr SetParent(IntPtr hwc, IntPtr hwp);

        private void button1_Click(object sender, EventArgs e)
        {
            Process p = Process.Start("C:\\Users\\Gor\\Desktop\\Naruto\\Mortal_Combat\\Mortal_Combat\\fight.exe");
            Thread.Sleep(500);
            p.WaitForInputIdle();
            //  SetParent(p.MainWindowHandle, this.Handle);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 frm4 = new Form4();
            frm4.Show();
        }
    }
}
