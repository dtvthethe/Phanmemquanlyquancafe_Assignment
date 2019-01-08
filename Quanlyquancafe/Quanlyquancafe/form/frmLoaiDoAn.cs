using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Quanlyquancafe.Data_Layer;
using Quanlyquancafe.Business_Layer;
using System.Text.RegularExpressions;

namespace Quanlyquancafe.form
{
    public partial class frmLoaiDoAn : Form
    {
        public frmLoaiDoAn()
        {
            InitializeComponent();
        }


        private bool them_sua = false;
        private bool of = false;



        private void load_loaidoan()
        {
            listView1.Items.Clear();
            loaiDoANBS bs = new loaiDoANBS();

            List<loaiDoAnDB> ds = bs.loadloaiDoAn();

            for (int i = 0; i < ds.Count; i++)
            {
                listView1.Items.Add(ds[i].maloai.ToString());
                listView1.Items[i].SubItems.Add(ds[i].tenloai.ToString());
            }

        }



        private void trung_dl()
        {

            loaiDoANBS bs = new loaiDoANBS();

            List<loaiDoAnDB> ds = bs.loadloaiDoAn();

            for (int i = 0; i < ds.Count; i++)
            {
                if (txtMa.Text== ds[i].maloai.ToString())
                {
                    of = true;
                    break;
                }
            }
        }


        private void them()
        {
            trung_dl();
            try
            {
                if (of == true)
                {
                    MessageBox.Show("Dữ liệu bạn nhập vào bị trùng ở textbox Mã tầng xin vui lòng kiểm ta lại");
                    txtMa.Text = "";
                    txtMa.Focus();

                }
                else
                {
                    loaiDoANBS them = new loaiDoANBS();
                    them.ldoan_themBS(txtMa.Text, txtTen.Text);

                    MessageBox.Show("Thêm thành công!");
                }


                of = false;
                them_sua = false;


            }
            catch
            {
                MessageBox.Show("Đã có lỗi xảy ra trong quá trình thêm");
            }

        }


        private void sua()
        {
            try
            {
                loaiDoANBS bs = new loaiDoANBS();
                bs.ldoan_suaBS(txtMa.Text, txtTen.Text);
                MessageBox.Show("Sửa thành công!");
                of = false;
                them_sua = false;
            }
            catch
            {
                MessageBox.Show("Đã có lỗi xảy ra trong quá trình sửa");
            }
        }


        private void space()
        {

            if (txtMa.Text == "" & txtTen.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin vào các textbox");
                txtMa.Focus();
            }
            else if (txtMa.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào Mã tầng");
                txtMa.Focus();
            }
            else if (txtTen.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào Tên tầng");
                txtTen.Focus();
            }
            else
            {
                if (them_sua == false)
                {
                    this.them();
                }
                else if (them_sua == true)
                {
                    this.sua();
                }
            }


        }

        private void frmLoaiDoAn_Load(object sender, EventArgs e)
        {
            load_loaidoan();
            
            txtMa.Enabled = false;
            txtTen.Enabled = false;
            listView1.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;

            txtMa.Text = listView1.SelectedItems[0].Text;
            txtTen.Text = listView1.SelectedItems[0].SubItems[1].Text;


            txtMa.Enabled = false;
            txtTen.Enabled = false;
            listView1.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them_sua = false;
            txtMa.Text = "";
            txtTen.Text = "";
            txtMa.Enabled = true;
            txtTen.Enabled = true;
            listView1.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnBoqua.Enabled = true;
            txtMa.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            them_sua = true;
            txtMa.Enabled = false;
            txtTen.Enabled = true;
            listView1.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnBoqua.Enabled = true;
            txtMa.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            this.space();
            load_loaidoan();
            txtMa.Text = "";
            txtTen.Text = "";
            txtMa.Enabled = false;
            txtTen.Enabled = false;
            listView1.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            them_sua = false;
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            if (txtTen.Enabled == true)
            {
                DialogResult msg = MessageBox.Show("Bạn có muốn lưu lại các giá trị đã nhập ở các textbox không? ", "Lưu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (msg == DialogResult.OK)
                {
                    this.space();
                }
                else
                { }

            }
            load_loaidoan();
            txtMa.Text = "";
            txtTen.Text = "";
            txtMa.Enabled = false;
            txtTen.Enabled = false;
            listView1.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            them_sua = false;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
             DialogResult msg = MessageBox.Show("Có phải bạn muốn xóa " + txtTen.Text + " không?", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
             try
             {
                 if (msg == DialogResult.OK)
                 {
                     //xóa
                     loaiDoANBS bs = new loaiDoANBS();
                     bs.ldoan_xoaBS(txtMa.Text);
                     MessageBox.Show("Xóa thành công");

                 }
                 else
                 {
 
                 }

             }
             catch 
             {
                 MessageBox.Show("Đã có lỗi xảy ra trong quá trình xóa");

             }

             
             load_loaidoan();
             txtMa.Text = "";
             txtTen.Text = "";
             txtMa.Enabled = false;
             txtTen.Enabled = false;
             listView1.Enabled = true;
             btnThem.Enabled = true;
             btnXoa.Enabled = false;
             btnSua.Enabled = false;
             btnLuu.Enabled = false;
             btnBoqua.Enabled = false;
        }

        private void txtMa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString().IndexOfAny(@"!@#$%^&*()_+=|\{} []?>/<.,';:".ToCharArray()) != -1)
            {
                e.Handled = true;
                MessageBox.Show("Gía trị nhập vào không được chứa các ký tự đặc biệt");
                txtMa.Text = "";
                txtMa.Focus();
            }
        }
    }
}
