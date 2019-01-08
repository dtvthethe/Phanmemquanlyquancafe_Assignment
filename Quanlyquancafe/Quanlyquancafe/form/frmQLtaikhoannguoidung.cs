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
    public partial class frmQLtaikhoannguoidung : Form
    {
        public frmQLtaikhoannguoidung()
        {
            InitializeComponent();
        }

        private bool of=false;
        private string picture = "0";
       private string cv="nv";
       private string img = "0";
        private bool ps= false;
        private int nghiep_vu = 0;
        private string cot;

        private void load_tk()
        {
            listView1.Items.Clear();
            TaiKhoanBS bs = new TaiKhoanBS();

            List<TaiKhoanDB> ds = bs.loadtk();

            for (int i = 0; i < ds.Count; i++)
            {
                listView1.Items.Add(ds[i].matk.ToString());
                listView1.Items[i].SubItems.Add(ds[i].tentk.ToString());
                listView1.Items[i].SubItems.Add(ds[i].chucvu.ToString());
                listView1.Items[i].SubItems.Add(ds[i].hoten.ToString());
                listView1.Items[i].SubItems.Add(ds[i].diachi.ToString());
                listView1.Items[i].SubItems.Add(ds[i].sdt.ToString());
                listView1.Items[i].SubItems.Add(ds[i].email.ToString());
                listView1.Items[i].SubItems.Add(ds[i].img.ToString());
            }
        }


        private void timkiem()
        {
            listView1.Items.Clear();
            TaiKhoanBS bs = new TaiKhoanBS();
            List<TaiKhoanDB> ds = bs.timttk(cot, txtTimkiem.Text);
            for (int i = 0; i < ds.Count; i++)
            {
                listView1.Items.Add(ds[i].matk.ToString());
                listView1.Items[i].SubItems.Add(ds[i].tentk.ToString());
                listView1.Items[i].SubItems.Add(ds[i].chucvu.ToString());
                listView1.Items[i].SubItems.Add(ds[i].hoten.ToString());
                listView1.Items[i].SubItems.Add(ds[i].diachi.ToString());
                listView1.Items[i].SubItems.Add(ds[i].sdt.ToString());
                listView1.Items[i].SubItems.Add(ds[i].email.ToString());
                listView1.Items[i].SubItems.Add(ds[i].img.ToString());
            }

        }

        private void trung_dl()
        {

            TaiKhoanBS bs = new TaiKhoanBS();

            List<TaiKhoanDB> ds = bs.loadtk();

            for (int i = 0; i < ds.Count; i++)
            {
                if (txtMa.Text == ds[i].matk.ToString())
                {
                    of = true;
                    break;
                }
            }
        }
        


        private string convertToCV(string ten)

        {
            
            if (cmbChucvu.SelectedItem.ToString()== "Thu ngân")
            {
                cv = "nv";
            }
            else if (cmbChucvu.SelectedItem.ToString() == "Admin")
            {
                cv = "ad";
 
            }
            return cv;
        }

        private void them()
        {
            trung_dl();
            try
            {
                //luu vao csdl
                 if (of == true)
                {
                    MessageBox.Show("Dữ liệu bạn nhập vào bị trùng ở textbox Mã sản phẩm xin vui lòng kiểm ta lại");
                    txtMa.Text = "";
                    txtMa.Focus();
                }
                else
                {
                    if (img != "0")
                    {
                        //coppy file hinh
                        string from1 = @"" + img + "";
                        string to1 = @"img\" + txtMa.Text + ".jpg";
                        System.IO.File.Copy((string)from1, (string)to1);
                    }
                   
                    TaiKhoanBS them = new TaiKhoanBS();
                    them.menu_themBS(txtMa.Text, txtTen.Text, txtDiachi.Text, txtsdt.Text, txtEmail.Text,txtMa.Text, txtTentk.Text, txtmkmoi2.Text, convertToCV(cmbChucvu.SelectedItem.ToString()));
                    MessageBox.Show("Thêm thành công!");

                }
            }
            catch
            {
                MessageBox.Show("Một lỗi xảy ra khi ứng dụng đang cố gắng add file hình ảnh này");
            }
            of = false;

            img = "0";
            picture="0";
            cv = "nv";
        }



        private void sua()
        {
            try
            {
                
                //sua hinh
                if (img != "0")
                {
                    //xoa file hinh anh hien tai
                    System.IO.File.Delete(@"img\" + txtMa.Text + ".jpg");

                    //coppy file hinh
                    string from1 = @"" + img + "";
                    string to1 = @"img\" + txtMa.Text + ".jpg";
                    System.IO.File.Copy((string)from1, (string)to1);
                }

                TaiKhoanBS bs1 = new TaiKhoanBS();
                bs1.tk_suaBS(txtTen.Text, txtDiachi.Text, txtsdt.Text, txtEmail.Text,txtMa.Text,txtMa.Text);

                img = "0";
                MessageBox.Show("Sửa thành công!");
            }
            catch
            {
                MessageBox.Show("Đã có lỗi xảy ra trong quá trình sửa");
            }
        }

        private void checkPassWord(string pass)
        {
            loadPassWordBS bs = new loadPassWordBS();
            List<loadPasswordDB> ds = bs.loadpass(txtMa.Text);
            for (int i = 0; i < ds.Count; i++)
            {
                if (pass == ds[i].mk.ToString())
                {
                    ps = true;
                    break;
                }
            }
            
        }
   



        private void doimk()
        {
            checkPassWord(txtmkcu.Text);
            try
            {
                if (txtmkmoi.Text != txtmkmoi2.Text)
                {
                    MessageBox.Show("Mật khẩu nhập vào phải giống nhau");
                    txtmkmoi.Text = "";
                    txtmkmoi2.Text = "";
                    txtmkmoi.Focus();
                }
                else if (ps==false)
                {
                    MessageBox.Show("Mật khẩu cũ không chính xác ");
                    txtmkcu.Text = "";
                    txtmkcu.Focus();
                }
                else
                {
                    TaiKhoanBS bs = new TaiKhoanBS();
                    bs.tk_doimkBS(txtmkmoi2.Text, txtMa.Text);
                    MessageBox.Show("Đổi mật khẩu thành công!");
                }
            }
            catch
            {
                MessageBox.Show("Đã có lỗi xảy ra trong quá trình đổi mật khẩu");
            }
            ps = false;
        }




        private void phanquyen()
        {
            try
            {

                TaiKhoanBS bs1 = new TaiKhoanBS();
                bs1.tk_phanquyenBS(txtMa.Text, cv);
                MessageBox.Show("Phân quyền thành công!");
            }
            catch
            {
                MessageBox.Show("Đã có lỗi xảy ra trong quá trình phân quền");
            }
        }


        private void space()
        {

            if (txtMa.Text == "" & txtTentk.Text == "" & cmbChucvu.Text == "" & txtmkcu.Text == "" & txtmkmoi.Text == "" & txtmkmoi2.Text == "" & txtTen.Text == "" & txtDiachi.Text == "" & txtsdt.Text == "" & txtEmail.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin vào các textbox");
                txtMa.Focus();
            }
            else if (txtMa.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào Mã tài khoản");
                txtMa.Focus();
            }
            else if (txtTentk.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào Tên đăng nhập");
                txtTentk.Focus();
            }
            else if (cmbChucvu.Text == "")
            {
                MessageBox.Show("Bạn chưa lựa chọn chức vụ cho người dùng");
                cmbChucvu.Focus();
            }
            else if (txtmkcu.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào Mật khẩu cũ");
                txtmkcu.Focus();
            }
            else if (txtmkmoi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào Mật khẩu mới 1");
                txtmkmoi.Focus();
            }
            else if (txtmkmoi2.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào Mật khẩu mới 2");
                txtmkmoi2.Focus();
            }
            else if (txtTen.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào Tên người dùng");
                txtTen.Focus();
            }
            else if (txtDiachi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào địa chỉ người dùng");
                txtDiachi.Focus();
            }
            else if (txtsdt.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào SĐT người dùng");
                txtsdt.Focus();
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào Email người dùng");
                txtEmail.Focus();
            }
            else
            {
                if (nghiep_vu == 0)
                {
                    this.them();
                }
                else if (nghiep_vu == 1)
                {
                    
                }
                else if (nghiep_vu == 2)
                {
                    this.sua();
                }
                else if (nghiep_vu == 3)
                {
                    this.doimk();
                }
                else if (nghiep_vu == 4)
                {
                    this.phanquyen();
                }
            }


        }




        private void frmQLtaikhoannguoidung_Load(object sender, EventArgs e)
        {
            load_tk();

            txtMa.Text = "";
            txtTentk.Text = "";
            cmbChucvu.Text = "";
            txtTen.Text = "";
            txtDiachi.Text = "";
            txtsdt.Text = "";
            txtEmail.Text = "";
            txtMa.Enabled = false;
            txtTentk.Enabled = false;
            cmbChucvu.Enabled = false;
            txtTen.Enabled = false;
            txtDiachi.Enabled = false;
            txtsdt.Enabled = false;
            txtEmail.Enabled = false;

            listView1.Enabled = true;
            pictureBox1.ImageLocation = @"img\no.jpg";

            btnBr.Enabled = false;
            btnTimkiem.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            btnDoimk.Enabled = false;
            btnPhanquyen.Enabled = false;

            txtmkcu.Visible = false;
            txtmkmoi.Visible = false;
            txtmkmoi2.Visible = false;
            lb1.Visible = false;
            lb2.Visible = false;
            lb3.Visible = false;

            groupBox1.Height = 173;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            txtMa.Text = listView1.SelectedItems[0].Text;
            txtTentk.Text = listView1.SelectedItems[0].SubItems[1].Text;
            cmbChucvu.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtTen.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtDiachi.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtsdt.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtEmail.Text = listView1.SelectedItems[0].SubItems[6].Text;
            pictureBox1.ImageLocation = @"img\" + listView1.SelectedItems[0].SubItems[7].Text + ".jpg";



            txtMa.Enabled = false;
            txtTentk.Enabled = false;
            cmbChucvu.Enabled = false;
            txtTen.Enabled = false;
            txtDiachi.Enabled = false;
            txtDiachi.Enabled = false;
            txtsdt.Enabled = false;
            txtEmail.Enabled = false;

            listView1.Enabled = true;

            btnBr.Enabled = false;

            btnTimkiem.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            btnDoimk.Enabled = true;
            btnPhanquyen.Enabled = true;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            nghiep_vu = 0;
            groupBox1.Height = 216;
            txtMa.Text = "";
            txtTentk.Text = "";
            cmbChucvu.Text = "";
            txtTen.Text = "";
            txtDiachi.Text = "";
            txtsdt.Text = "";
            txtEmail.Text = "";
            txtMa.Enabled = true;
            txtTentk.Enabled = true;
            cmbChucvu.Enabled = true;
            txtTen.Enabled = true;
            txtDiachi.Enabled = true;
            txtsdt.Enabled = true;
            txtEmail.Enabled = true;

            listView1.Enabled = false;
            pictureBox1.ImageLocation = @"img\no.jpg";
            btnBr.Enabled = true;

            btnTimkiem.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnBoqua.Enabled = true;
            btnDoimk.Enabled = false;
            btnPhanquyen.Enabled = false;

            lb2.Visible = true;
            lb3.Visible = true;
            txtmkmoi.Visible = true;
            txtmkmoi2.Visible = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            nghiep_vu = 2;
            txtMa.Enabled = false;
            txtTentk.Enabled = false;
            cmbChucvu.Enabled = false;
            txtTen.Enabled = true;
            txtDiachi.Enabled = true;
            txtsdt.Enabled = true;
            txtEmail.Enabled = true;

            listView1.Enabled = false;

            btnBr.Enabled = true;

            btnTimkiem.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnBoqua.Enabled = true;
            btnDoimk.Enabled = false;
            btnPhanquyen.Enabled = false;
        }

        private void btnDoimk_Click(object sender, EventArgs e)
        {
            nghiep_vu = 3;
            groupBox1.Height = 216;
            btnDoimk.Enabled = false;
            btnPhanquyen.Enabled = false;
            txtmkcu.Visible = true;
            txtmkmoi.Visible = true;
            txtmkmoi2.Visible = true;
            btnTimkiem.Enabled = false;
            listView1.Enabled = false;
            btnLuu.Enabled = true;
            btnBoqua.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            lb1.Visible = true;
            lb2.Visible = true;
            lb3.Visible = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            this.space();
            load_tk();
            nghiep_vu = 0;
            txtMa.Text = "";
            txtTentk.Text = "";
            cmbChucvu.Text = "";
            txtTen.Text = "";
            txtDiachi.Text = "";
            txtsdt.Text = "";
            txtEmail.Text = "";
            txtmkcu.Text = "";
            txtmkmoi.Text = "";
            txtmkmoi2.Text = "";
            txtMa.Enabled = false;
            txtTentk.Enabled = false;
            cmbChucvu.Enabled = false;
            txtTen.Enabled = false;
            txtDiachi.Enabled = false;
            txtsdt.Enabled = false;
            txtEmail.Enabled = false;

            listView1.Enabled = true;
            pictureBox1.ImageLocation = @"img\no.jpg";
            btnBr.Enabled = false;
            btnTimkiem.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            btnDoimk.Enabled = false;
            btnPhanquyen.Enabled = false;

            txtmkcu.Visible = false;
            txtmkmoi.Visible = false;
            txtmkmoi2.Visible = false;
            lb1.Visible = false;
            lb2.Visible = false;
            lb3.Visible = false;
            groupBox1.Height = 173;
        }

        private void btnPhanquyen_Click(object sender, EventArgs e)
        {
            nghiep_vu = 4;
            btnPhanquyen.Enabled = false;
            btnDoimk.Enabled = false;
            cmbChucvu.Enabled = true;
            btnTimkiem.Enabled = false;
            btnTimkiem.Enabled = false;
            listView1.Enabled = false;
            btnLuu.Enabled = true;
            btnBoqua.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {

            if (cmbChucvu.Enabled == true | txtmkmoi.Enabled == true | txtMa.Enabled == true)
            {
                DialogResult msg = MessageBox.Show("Bạn có muốn lưu lại thông tin đã nhập vào các textbox?", "Bỏ qua", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (msg == DialogResult.OK)
                {
                    this.space();
                }
            }

            this.load_tk();
            nghiep_vu = 0;
            txtMa.Text = "";
            txtTentk.Text = "";
            cmbChucvu.Text = "";
            txtTen.Text = "";
            txtDiachi.Text = "";
            txtsdt.Text = "";
            txtEmail.Text = "";
            txtmkcu.Text = "";
            txtmkmoi.Text = "";
            txtmkmoi2.Text = "";
            txtMa.Enabled = false;
            txtTentk.Enabled = false;
            cmbChucvu.Enabled = false;
            txtTen.Enabled = false;
            txtDiachi.Enabled = false;
            txtsdt.Enabled = false;
            txtEmail.Enabled = false;

            listView1.Enabled = true;
            pictureBox1.ImageLocation = @"img\no.jpg";

            btnBr.Enabled = false;
            btnTimkiem.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            btnDoimk.Enabled = false;
            btnPhanquyen.Enabled = false;

            txtmkcu.Visible = false;
            txtmkmoi.Visible = false;
            txtmkmoi2.Visible = false;
            lb1.Visible = false;
            lb2.Visible = false;
            lb3.Visible = false;

            groupBox1.Height = 173;
        }



        private void cmbChucvu_SelectedIndexChanged(object sender, EventArgs e)
        {
            convertToCV(cmbChucvu.SelectedItem.ToString());
        }

        private void btnBr_Click(object sender, EventArgs e)
        {
            OpenFileDialog opdal = new OpenFileDialog();
            opdal.Filter = "(*.jpg)|*.jpg";
            if (opdal.ShowDialog() == DialogResult.OK)
            {
                img = opdal.FileName;
                pictureBox1.ImageLocation = img;

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            nghiep_vu = 1;
        }

        private void txtMa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString().IndexOfAny(@"!@#$%^&*()_+=|\{} []?>/<.,';:".ToCharArray()) != -1)
            {
                e.Handled = true;
                MessageBox.Show("Mã người dùng không được chứa ký tự đặc biệt");
                txtMa.Text = "";
                txtMa.Focus();
            }
        }

        private void txtTentk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString().IndexOfAny(@"!@#$%^&*()_+=|\{} []?>/<.,';:".ToCharArray()) != -1)
            {
                e.Handled = true;
                MessageBox.Show("Tên tài khoản không được chứa ký tự đặc biệt");
                txtTentk.Text = "";
                txtTentk.Focus();
            }
        }

        private void txtTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString().IndexOfAny(@"!@#$%^&*()_+=|\{} []?>/<.,';:".ToCharArray()) != -1)
            {
                e.Handled = true;
                MessageBox.Show("Tên không được chứa ký tự đặc biệt");
                txtTen.Text = "";
                txtTen.Focus();
            }
        }

        private void txtDiachi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString().IndexOfAny(@"!@#$%^&*()_+=|\{} []?>/<.,';:".ToCharArray()) != -1)
            {
                e.Handled = true;
                MessageBox.Show("Địa chỉ không được chứa ký tự đặc biệt");
                txtDiachi.Text = "";
                txtDiachi.Focus();
            }
        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString().IndexOfAny(@"QWERTYUIOPLKJHGFDSAZXCVBNMpoiuytrewqasdfghjklmnbvcxz!@#$%^&*()_+=|\{} []?>/<.,';:".ToCharArray()) != -1)
            {
                e.Handled = true;
                MessageBox.Show("SĐT không được chứa ký tự đặc biệt");
                txtsdt.Text = "";
                txtsdt.Focus();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString().IndexOfAny(@"!#$%^&*()_+=|\{} []?>/<,';:".ToCharArray()) != -1)
            {
                e.Handled = true;
                MessageBox.Show("Đây không phải là định dạng email");
                txtDiachi.Text = "";
                txtDiachi.Focus();
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (txtTimkiem.Text == "" & cmbTim.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào giá trị tìm kiếm ");
                txtTimkiem.Focus();
            }
            else if (txtTimkiem.Text == "")
            {
                this.load_tk();
            }
            else if (cmbTim.Text == "")
            {
                MessageBox.Show("Bạn chưa lựa chọn kiểu tìm kiếm ");
            }
            else
            {
                timkiem();
 
            }

            
            
        }

        private void cmbTim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTim.Text == "Mã tài khoản")
            {
                cot = "nguoi_dung.ma_tk";
            }
            else if (cmbTim.Text == "Tên đăng nhập")
            {
                cot="dang_nhap.ten_dang_nhap";
            }
            else if (cmbTim.Text == "Họ và tên")
            {
                cot="nguoi_dung.ten";
            }
        }


    }
}

