using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Quanlyquancafe.form;

namespace Quanlyquancafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void time()
        {
            if (progressBar1.Value==0)
            {
                label1.Text = "Start: 0.";
            }
            else if (progressBar1.Value == 10)
            {
                label1.Text = "Start: 10..";
            }
            else if (progressBar1.Value == 20)
            {
                label1.Text = "Start: 20...";
            }
            else if (progressBar1.Value == 30)
            {
                label1.Text = "Start: 30.";
            }
            else if (progressBar1.Value == 40)
            {
                label1.Text = "Start: 40..";
            }
            else if (progressBar1.Value == 50)
            {
                label1.Text = "Start: 50...";
            }
            else if (progressBar1.Value == 60)
            {
                label1.Text = "Start: 60.";
            }
            else if (progressBar1.Value == 70)
            {
                label1.Text = "Start: 70..";
            }
            else if (progressBar1.Value == 80)
            {
                label1.Text = "Start: 80...";
            }
            else if (progressBar1.Value == 90)
            {
                label1.Text = "Start: 90.";
            }
            else if (progressBar1.Value == 100)
            {
                label1.Text = "Start: 100..";
                timer1.Stop();
                this.Hide();

                frmDangNhap dangnhap = new frmDangNhap();
                dangnhap.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        { 
            progressBar1.Increment(1);
            time();

        }
    }
}
