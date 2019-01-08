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
    public partial class frmTang : Form
    {
        public frmTang()
        {
            InitializeComponent();
        }


        private bool them_sua = false;
        private bool of = false;

        private void load_tang()
        {
            listView1.Items.Clear();
            TangBS bs = new TangBS();

            List<TangDB> ds = bs.tang();

            for (int i = 0; i < ds.Count; i++)
            {
                listView1.Items.Add(ds[i].matang.ToString());
                listView1.Items[i].SubItems.Add(ds[i].tentang.ToString());
            }

        }



        private void trung_dl()
        {

            TangBS bs = new TangBS();

            List<TangDB> ds = bs.tang();

            for (int i = 0; i < ds.Count; i++)
            {
                if (txtMatang.Text == ds[i].matang.ToString())
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
                    txtMatang.Text = "";
                    txtMatang.Focus();

                }
                else
                {
                    TangBS them = new TangBS();
                    them.tang_themBS(txtMatang.Text, txtTentang.Text);

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
                TangBS bs = new TangBS();
                bs.tang_suaBS(txtMatang.Text, txtTentang.Text);
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

            if (txtMatang.Text=="" & txtTentang.Text=="")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin vào các textbox");
                txtMatang.Focus();
            }
            else if (txtMatang.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào Mã tầng");
                txtMatang.Focus();
            }
            else if (txtTentang.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào Tên tầng");
                txtTentang.Focus();
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


        private void frmBan_Load(object sender, EventArgs e)
        {
            load_tang();

            txtMatang.Enabled = false;
            txtTentang.Enabled = false;
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

            txtMatang.Text = listView1.SelectedItems[0].Text;
            txtTentang.Text = listView1.SelectedItems[0].SubItems[1].Text;


            txtMatang.Enabled = false;
            txtTentang.Enabled = false;
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
            txtMatang.Text = "";
            txtTentang.Text = "";
            txtMatang.Enabled = true;
            txtTentang.Enabled = true;
            listView1.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnBoqua.Enabled = true;
            txtMatang.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Có phải bạn muốn xóa " + txtMatang.Text + " " + txtTentang.Text + " không?\r Nếu bạn xóa giá trị này có thể các vị trí ngồi trong khu vực này sẽ bị xóa", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            try
            {
                if (msg == DialogResult.OK)
                {
                    //xóa
                    TangBS bs = new TangBS();
                    bs.tang_xoaBS(txtMatang.Text);

                    MessageBox.Show("Xóa thành công");
                    //hiển thị lại 
                    txtMatang.Text="";
                    txtTentang.Text = "";
                    load_tang();
                    txtMatang.Enabled = false;
                    txtTentang.Enabled = false;
                    listView1.Enabled = true;
                    btnThem.Enabled = true;
                    btnXoa.Enabled = false;
                    btnSua.Enabled = false;
                    btnLuu.Enabled = false;
                    btnBoqua.Enabled = false;

                }
            }
            catch
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình xóa");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them_sua = true;
           
            load_tang();
            txtMatang.Enabled = false;
            txtTentang.Enabled = true;
            listView1.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnBoqua.Enabled = true;
            txtMatang.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            this.space();
            load_tang();
            txtMatang.Text = "";
            txtTentang.Text = "";
            txtMatang.Enabled = false;
            txtTentang.Enabled = false;
            listView1.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            if (txtTentang.Enabled == true)
            {
                DialogResult msg = MessageBox.Show("Bạn có muốn lưu lại thông tin đã nhập vào các Textbox không?", "Lưu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (msg == DialogResult.OK)
                {
                    this.space();

                }
            }
            load_tang();
            txtMatang.Text = "";
            txtTentang.Text = "";
            txtMatang.Enabled = false;
            txtTentang.Enabled = false;
            listView1.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
        }

        private void txtMatang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString().IndexOfAny(@"!@#$%^&*()_+=|\{} []?>/<.,';:".ToCharArray()) != -1)
            {
                e.Handled = true;
                MessageBox.Show("Gía trị nhập vào không được chứa các ký tự đặc biệt");
                txtMatang.Text = "";
                txtMatang.Focus();
            }
        }

    }
}
