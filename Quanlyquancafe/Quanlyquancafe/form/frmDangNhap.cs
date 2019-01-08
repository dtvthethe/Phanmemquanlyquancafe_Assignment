using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Quanlyquancafe.Business_Layer;
using Quanlyquancafe.Data_Layer;
using System.Text.RegularExpressions;

namespace Quanlyquancafe.form
{
    public partial class frmDangNhap : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dang_nhap()
        {
            dangNhapBS bs = new dangNhapBS();
            List<dangNhapDB> ds = bs.dangnhap(txtTk.Text, txtMk.Text);
            if (ds.Count == 0)
            {
                MessageBox.Show("Sai tên đăng nhập hoặc tài khoản");
            }
            else if (ds.Count > 1)
            {
                MessageBox.Show("Sai tên đăng nhập hoặc tài khoản");
            }
            else
            {
                for (int i = 0; i < ds.Count; i++)
                {
                    if (ds[i].chucvu.ToString() == "nv")
                    {
                        frmNhanVien nv = new frmNhanVien();
                        nv.user.Text = ds[i].tk.ToString();
                        nv.user.Tag = ds[i].tk.ToString();
                        nv.Show();
                        this.Close();
                    }
                    else if (ds[i].chucvu.ToString() == "ad")
                    {
                        frmQuanLycs ql = new frmQuanLycs();
                        ql.Show();
                        this.Close();
                    }
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.dang_nhap();
        }

        private void txtTk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString().IndexOfAny(@"!@#$%^&*()_+=|\{} []?>/<.,';:".ToCharArray()) != -1)
            {
                e.Handled = true;
                MessageBox.Show("Gía trị nhập vào không được chứa các ký tự đặc biệt");
                txtTk.Text = "";
                txtTk.Focus();
            }
        }

        private void txtMk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString().IndexOfAny(@"!@#$%^&*()_+=|\{} []?>/<.,';:".ToCharArray()) != -1)
            {
                e.Handled = true;
                MessageBox.Show("Gía trị nhập vào không được chứa các ký tự đặc biệt");
                txtMk.Text = "";
                txtMk.Focus();
            }
        }

        private void txtMk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.dang_nhap();
            } 
        }

        private void txtTk_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
