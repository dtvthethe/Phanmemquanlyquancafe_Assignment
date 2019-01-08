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
    public partial class frmBan : Form
    {
        public frmBan()
        {
            InitializeComponent();
        }

        private bool them_sua = false;
        private bool of = false;


        private void loadban()
        {
            listView1.Items.Clear();
            BanBS bs = new BanBS();
            List<BanDB> ds = bs.tang();
            for (int i = 0; i < ds.Count; i++)
            {
                listView1.Items.Add(ds[i].ma_ban.ToString());
                listView1.Items[i].SubItems.Add(ds[i].ten_ban.ToString());
                listView1.Items[i].SubItems.Add(ds[i].trang_thai.ToString());
                listView1.Items[i].SubItems.Add(ds[i].matang.ToString());
            }
            mau();
        }

        private void mau()
        {
            BanBS bs = new BanBS();
            List<BanDB> ds = bs.tang();
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i].trang_thai.ToString() == "True")
                {
                    listView1.Items[i].BackColor = Color.Red;
                }
            }
        }

        private void frmBan_Load(object sender, EventArgs e)
        {
            
            txtMa.Text = "";
            txtTen.Text = "";
            txtTrangThai.Text = "";
            cmbTang.Text = "";

            txtMa.Enabled = false;
            txtTen.Enabled = false;
            txtTrangThai.Enabled = false;
            cmbTang.Enabled = false;
            listView1.Enabled = true;

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;


            this.loadban();
            this.loadtang();
        }

        private string convetToTT(string trangthai)
        {
            string ten = "";
            if (trangthai == "True")
            {
                ten = "Đang sử dụng";
            }
            else if (trangthai == "False")
            {
                ten = "Không sử dụng";
            }
            return ten;
        }

        private string convertTo(string ma)
        {
            string text = "";
            TangBS bs = new TangBS();

            List<TangDB> ds = bs.tang();

            for (int i = 0; i < ds.Count; i++)
            {
                if (ma == ds[i].matang.ToString())
                {
                    text = ds[i].tentang.ToString();
                    break;
                }
            }
            return text;
        }

        private string convertToMa(string ten)
        {
            string ma="";
            TangBS bs = new TangBS();

            List<TangDB> ds = bs.tang();

            for (int i=0;i<ds.Count;i++)
            {
                if (ten == ds[i].tentang.ToString())
                {
                    ma = ds[i].matang.ToString();
                    break;
                }
            }
            return ma;
        }


        private void loadtang()
        {
            TangBS bs = new TangBS();

            List<TangDB> ds = bs.tang();

            for (int i = 0; i < ds.Count; i++)
            {
                cmbTang.Items.Add(ds[i].tentang.ToString());
            }
        }

        private void trung_dl()
        {
            BanBS bs = new BanBS();

            List<BanDB> ds = bs.tang();

            for (int i = 0; i < ds.Count; i++)
            {
                if (txtMa.Text == ds[i].ma_ban.ToString())
                {
                    of = true;
                    break;
                }
            }
        }

        private void them()
        {
           
            try
            {
                trung_dl();
                if (of == true)
                {
                    MessageBox.Show("Dữ liệu bạn nhập vào bị trùng ở textbox Mã tầng xin vui lòng kiểm ta lại");
                    txtMa.Text = "";
                    txtMa.Focus();
                }
                else
                {
                    BanBS them = new BanBS();
                    them.ban_themBS(txtMa.Text,txtTen.Text,convertToMa(cmbTang.Text));

                    MessageBox.Show("Thêm thành công!");
                }
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
                BanBS bs = new BanBS();
                bs.ban_suaBS(txtTen.Text, convertToMa(cmbTang.Text), txtMa.Text);
                MessageBox.Show("Sửa thành công!");
                
            }
            catch
            {
                MessageBox.Show("Đã có lỗi xảy ra trong quá trình sửa");
            }
        }

        private void space()
        {

            if (txtMa.Text == "" & txtTen.Text == "" & cmbTang.Text=="")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin vào các textbox");
                txtMa.Focus();
            }
            else if (txtMa.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào Mã bàn");
                txtMa.Focus();
            }
            else if (txtTen.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào Tên bàn");
                txtTen.Focus();
            }
            else if (cmbTang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn tầng cho bàn");
                cmbTang.Focus();
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtMa.Enabled = false;
            txtTen.Enabled = false;
            txtTrangThai.Enabled = false;
            cmbTang.Enabled = false;
            listView1.Enabled = true;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            
            if (listView1.SelectedItems.Count == 0) return;

            txtMa.Text = listView1.SelectedItems[0].Text;
            txtTen.Text = listView1.SelectedItems[0].SubItems[1].Text;
            //trangthai = listView1.SelectedItems[0].SubItems[2].Text;
            txtTrangThai.Text = convetToTT(listView1.SelectedItems[0].SubItems[2].Text);
            //cmbTang.Text = listView1.SelectedItems[0].SubItems[3].Text;
            cmbTang.Text= convertTo(listView1.SelectedItems[0].SubItems[3].Text);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them_sua = false;


            txtMa.Text = "";
            txtTen.Text = "";
            txtTrangThai.Text = "";
            cmbTang.Text = "";

            txtMa.Enabled = true;
            txtTen.Enabled = true;
            txtTrangThai.Enabled = false;
            cmbTang.Enabled = true;
            listView1.Enabled = false;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnBoqua.Enabled = true;
            //btnTim.Enabled = false;
            txtMa.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BanBS bs = new BanBS();

            if (txtTrangThai.Text == "Đang sử dụng")
            {
                MessageBox.Show("Bạn không thể xóa bàn này vì bàn này đang được sử dụng!");
            }
            else if (txtTrangThai.Text == "Không sử dụng")
            {
                DialogResult msg = MessageBox.Show("Có phải bạn muốn xóa " + txtMa.Text + " " + txtTen.Text + " không?", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                try
                {
                    if (msg == DialogResult.OK)
                    {
                        bs.ban_xoaBS(txtMa.Text);

                       
                        MessageBox.Show("Xóa thành công");
                    }
                }
                catch
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình xóa");
                }

            }
            txtMa.Text = "";
            txtTen.Text = "";
            txtTrangThai.Text = "";
            cmbTang.Text = "";

            txtMa.Enabled = false;
            txtTen.Enabled = false;
            txtTrangThai.Enabled = false;
            cmbTang.Enabled = false;
            listView1.Enabled = true;

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            this.loadban();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them_sua = true;
            txtMa.Enabled = false;
            txtTen.Enabled = true;
            txtTrangThai.Enabled =false;
            cmbTang.Enabled = true;
            listView1.Enabled = false;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnBoqua.Enabled = true;
            txtTen.Focus();
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            if (txtTen.Enabled==true | txtTrangThai.Enabled == true)
            {
                DialogResult msg = MessageBox.Show("Bạn có muốn lưu lại các thông tin bạn đã nhập vào các textbox?", "Lưu thông tin", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (msg == DialogResult.OK)
                {
                    this.space();
                }
            }

            txtMa.Text = "";
            txtTen.Text = "";
            txtTrangThai.Text = "";
            cmbTang.Text = "";

            txtMa.Enabled = false;
            txtTen.Enabled = false;
            txtTrangThai.Enabled = false;
            cmbTang.Enabled = false;
            listView1.Enabled = true;

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            this.loadban();

            of = false;
            them_sua = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            this.space();

            if (of != true)
            {
                this.loadban();
                txtMa.Text = "";
                txtTen.Text = "";
                txtTrangThai.Text = "";
                cmbTang.Text = "";

                txtMa.Enabled = false;
                txtTen.Enabled = false;
                txtTrangThai.Enabled = false;
                cmbTang.Enabled = false;
                listView1.Enabled = true;

                //btnTim.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnLuu.Enabled = false;
                btnBoqua.Enabled = false;
            }
            of = false;
            them_sua = false;
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

        private void txtTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString().IndexOfAny(@"!@#$%^&*()_+=|\{} []?>/<.,';:".ToCharArray()) != -1)
            {
                e.Handled = true;
                MessageBox.Show("Gía trị nhập vào không được chứa các ký tự đặc biệt");
                txtTen.Text = "";
                txtTen.Focus();
            }
        }
    }
}
