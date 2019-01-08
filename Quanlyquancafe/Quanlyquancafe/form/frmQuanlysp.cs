using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Quanlyquancafe.Data_Layer;
using Quanlyquancafe.Business_Layer;

namespace Quanlyquancafe.form
{
    public partial class frmQuanlysp : Form
    {
        public frmQuanlysp()
        {
            InitializeComponent();
        }

        private int i;
        private string picturex;
        private string img = "0";
        private int maLoaiDoan;
        private string tenLoaiDoAn;
        private bool them_sua = false;
        private bool of = false;
        private string ma_tim;




        private void load_menu()
        {
            listView1.Items.Clear();
            menuBS bs = new menuBS();

            List<menuDB> ds = bs.loadMenu();

                for (int i = 0; i < ds.Count; i++)
                {
                    listView1.Items.Add(ds[i].ma_sp.ToString());
                    listView1.Items[i].SubItems.Add(ds[i].ten_sp.ToString());
                    listView1.Items[i].SubItems.Add(ds[i].gia.ToString());
                    listView1.Items[i].SubItems.Add(ds[i].ma_loai.ToString());
                    listView1.Items[i].SubItems.Add(ds[i].img.ToString());
                }
        }

        private void load_loaidoan()
        {
            cmdLoaiDoAn.Items.Clear();
            loaiDoANBS bs = new loaiDoANBS();

            List<loaiDoAnDB> ds = bs.loadloaiDoAn();

            for (int i = 0; i < ds.Count; i++)
            {
                cmdLoaiDoAn.Items.Add(ds[i].tenloai.ToString());
            }

        }

        private void load_timkiem()
        {
            listView1.Items.Clear();
            menuBS bs = new menuBS();
            List<menuDB> ds = bs.menu_timkiemBS(ma_tim, txtTim.Text);

            for (int i = 0; i < ds.Count; i++)
            {
                listView1.Items.Add(ds[i].ma_sp.ToString());
                listView1.Items[i].SubItems.Add(ds[i].ten_sp.ToString());
                listView1.Items[i].SubItems.Add(ds[i].gia.ToString());
                listView1.Items[i].SubItems.Add(ds[i].ma_loai.ToString());
                listView1.Items[i].SubItems.Add(ds[i].img.ToString());
            }
        }

        private void sua()
        {
            try
            {
                loaiDoANBS bs = new loaiDoANBS();

                List<loaiDoAnDB> ds = bs.loadloaiDoAn();
                tenLoaiDoAn = ds[maLoaiDoan].maloai.ToString();
               

                string ten = "0";


                
                //sua hinh
                if (img != "0")
                {
                    //xoa file hinh anh hien tai
                    System.IO.File.Delete(@"img\" + txtMaSP.Text + ".jpg");

                    //coppy file hinh
                    string from1 = @"" + img + "";
                    string to1 = @"img\" + txtMaSP.Text + ".jpg";
                    System.IO.File.Copy((string)from1, (string)to1);
                    ten = txtMaSP.Text;
                }

                menuBS bs1 = new menuBS();
                bs1.menu_suaBS(txtMaSP.Text, txtTenSP.Text, Convert.ToDecimal(txtGia.Text), tenLoaiDoAn,ten);
               
                img = "0";
                ten = "0";

                MessageBox.Show("Sửa thành công!");
            }
            catch
            {
                MessageBox.Show("Đã có lỗi xảy ra trong quá trình sửa");
            }
        }


        private void them()
        {
            trung_dl();
            try
            {
                
                loaiDoANBS bs = new loaiDoANBS();

                List<loaiDoAnDB> ds = bs.loadloaiDoAn();
                tenLoaiDoAn = ds[maLoaiDoan].maloai.ToString();
                //lu vao csdl

                string ten = "0";

                if (img != "0")
                {
                    //coppy file hinh
                    string from1 = @"" + img + "";
                    string to1 = @"img\" + txtMaSP.Text + ".jpg";
                    System.IO.File.Copy((string)from1, (string)to1);
                    ten = txtMaSP.Text;
                }
                else if (of == true)
                {
                    MessageBox.Show("Dữ liệu bạn nhập vào bị trùng ở textbox Mã sản phẩm xin vui lòng kiểm ta lại");
                    txtMaSP.Text = "";
                    txtMaSP.Focus();
                }
                else
                {
                    menuBS them = new menuBS();
                    them.menu_themBS(txtMaSP.Text, txtTenSP.Text, Convert.ToDecimal(txtGia.Text), tenLoaiDoAn, ten);
                    MessageBox.Show("Thêm thành công!");
                    
                }

                img = "0";
                ten = "0";
            }
            catch
            {
                MessageBox.Show("Một lỗi xảy ra khi ứng dụng đang cố gắng add file hình ảnh này");
            }

        }

        private void trung_dl()
        {
            
            menuBS bs = new menuBS();

            List<menuDB> ds = bs.loadMenu();

            for (int i = 0; i < ds.Count; i++)
            {
                if (txtMaSP.Text == ds[i].ma_sp.ToString())
                {
                    of = true;
                    break;
                }
            }
        }


        private void space()
        {
            
            if (txtMaSP.Text == "" & txtTenSP.Text == "" & txtGia.Text == "" & cmdLoaiDoAn.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin vào các textbox");
                txtMaSP.Focus();
            }
            else if (txtMaSP.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào Mã của sản phẩm");
                txtMaSP.Focus();
            }
            else if (txtTenSP.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào Tên của sản phẩm");
                txtTenSP.Focus();
            }
            else if (txtGia.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào Gía của sản phẩm");
                txtGia.Focus();
            }
            else if (cmdLoaiDoAn.Text == "")
            {
                MessageBox.Show("Bạn chưa lựa chọn Loại đồ ăn của sản phẩm");
                cmdLoaiDoAn.Focus();
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




        private void frmQuanlysp_Load(object sender, EventArgs e)
        {

            load_menu();
            load_loaidoan();

            pictureBox1.ImageLocation = @"img\no.jpg";

            txtMaSP.Enabled = false;
            txtTenSP.Enabled = false;
            cmdLoaiDoAn.Enabled = false;
            txtGia.Enabled = false;
            //txtTim.Enabled = true;
            btnBr.Enabled = false;
            listView1.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnDong.Enabled = true;


        }

        private void load_anh(string patch)
        {
            if (patch == "0")
            {
                pictureBox1.ImageLocation = @"img\no.jpg";
            }
            else
            {
                pictureBox1.ImageLocation = @"img\"+patch+".jpg";
 
            }
        }


        private string  convertTo(string ma)
        {
            string text = "";
            loaiDoANBS bs = new loaiDoANBS();

            List<loaiDoAnDB> ds = bs.loadloaiDoAn();

            for (int i = 0; i < ds.Count; i++)
            {
                if (ma == ds[i].maloai.ToString())
                {
                    text = ds[i].tenloai.ToString();
                    break;
                }
            }
            return text;
 
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            i = Convert.ToInt32( listView1.SelectedIndices[0].ToString());

            txtMaSP.Text = listView1.SelectedItems[0].Text;
           txtTenSP.Text = listView1.SelectedItems[0].SubItems[1].Text;
           txtGia.Text = listView1.SelectedItems[0].SubItems[2].Text;
           //txtLoai.Text = listView1.SelectedItems[0].SubItems[3].Text;
           //cmdLoaiDoAn.Text = ;
           cmdLoaiDoAn.Text = convertTo(listView1.SelectedItems[0].SubItems[3].Text);
           picturex = listView1.SelectedItems[0].SubItems[4].Text;
           this.load_anh(picturex);


           txtMaSP.Enabled = false;
           txtTenSP.Enabled = false;
           cmdLoaiDoAn.Enabled = false;
           txtGia.Enabled = false;
           btnBr.Enabled = false;
          // txtTim.Enabled = true;
           listView1.Enabled = true;
           btnThem.Enabled = true;
           btnXoa.Enabled = true;
           btnSua.Enabled = true;
           btnLuu.Enabled = false;
           btnDong.Enabled = true;




        }




        private void btnDong_Click(object sender, EventArgs e)
        {
            if (txtGia.Enabled == true | txtTenSP.Enabled == true)
            {
                DialogResult msg = MessageBox.Show("Bạn có muốn lưu lại các giá trị đã nhập vào các Textbox  không?", "Lưu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (msg == DialogResult.OK)
                {
                    this.space();
                    of = false;
                    img = "0";
                    load_menu();
                    picturex = "0";
                    them_sua = false;
                    load_loaidoan();

                    pictureBox1.ImageLocation = @"img\no.jpg";

                   
                 
                }
         
            }
            txtMaSP.Enabled = false;
            txtTenSP.Enabled = false;
            cmdLoaiDoAn.Enabled = false;
            txtGia.Enabled = false;
            //txtTim.Enabled = true;
            btnBr.Enabled = false;
            listView1.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnDong.Enabled = true;
       
        }


        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"img\no.jpg";
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            cmdLoaiDoAn.Text = "";
            txtGia.Text = "";

            txtMaSP.Enabled = true;
            txtTenSP.Enabled = true;
            cmdLoaiDoAn.Enabled = true;
            txtGia.Enabled = true;
            btnBr.Enabled = true;
            //txtTim.Enabled = false;
            listView1.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnDong.Enabled = true;
            them_sua = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog opdal = new OpenFileDialog();
            opdal.Filter = "(*.jpg)|*.jpg";  
            if (opdal.ShowDialog() == DialogResult.OK)
            {
                img = opdal.FileName;
                pictureBox1.ImageLocation = img;
 
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            this.space();
            img = "0";
            of = false;
            load_menu();
            picturex = "0";
            them_sua = false;
            load_loaidoan();

            pictureBox1.ImageLocation = @"img\no.jpg";

            txtMaSP.Text = "";
            txtTenSP.Text = "";
            cmdLoaiDoAn.Text = "";
            txtGia.Text = "";

            txtMaSP.Enabled = false;
            txtTenSP.Enabled = false;
            cmdLoaiDoAn.Enabled = false;
            txtGia.Enabled = false;
           // txtTim.Enabled = true;
            btnBr.Enabled = false;
            listView1.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnDong.Enabled = true;
        }

        private void cmdLoaiDoAn_SelectedIndexChanged(object sender, EventArgs e)
        {

           maLoaiDoan = cmdLoaiDoAn.SelectedIndex;
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Có phải bạn muốn xóa " + txtMaSP.Text + " " + txtTenSP.Text + " không?", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            try
            {
                if (msg == DialogResult.OK)
                {
                    //xóa
                    menuBS bs = new menuBS();
                    bs.menu_xoaBS(txtMaSP.Text);
                    //xóa hinh anh
                    System.IO.File.Delete(@"img\" + picturex + ".jpg");
                    //hiển thị lại 

                    txtMaSP.Text = "";
                    txtTenSP.Text = "";
                    txtGia.Text = "";
                    cmdLoaiDoAn.Text = "";
                    pictureBox1.ImageLocation = @"img\no.jpg";

                    load_menu();
                    load_loaidoan();



                    txtMaSP.Enabled = false;
                    txtTenSP.Enabled = false;
                    cmdLoaiDoAn.Enabled = false;
                    txtGia.Enabled = false;
                    btnBr.Enabled = false;
                   // txtTim.Enabled = true;
                    listView1.Enabled = true;
                    btnThem.Enabled = true;
                    btnXoa.Enabled = false;
                    btnSua.Enabled = false;
                    btnLuu.Enabled = false;
                    btnDong.Enabled = true;

                } 
            }
            catch
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình xóa");
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            txtMaSP.Enabled = false;
            txtTenSP.Enabled = true;
            cmdLoaiDoAn.Enabled = true;
            txtGia.Enabled = true;
            btnBr.Enabled = true;
          //  txtTim.Enabled = false;
            listView1.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnDong.Enabled = true;

            them_sua = true;
        }

        private void txtMaSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString().IndexOfAny(@"!@#$%^&*()_+=|\{} []?>/<.,';:".ToCharArray()) != -1)
            {
                e.Handled = true;
                MessageBox.Show("Mã sản phẩm không được chứa các ký tự đặc biệt");
                txtMaSP.Text = "";
                txtMaSP.Focus();


            }
        }

        private void txtTenSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString().IndexOfAny(@"!@#$%^&*()_+=|\{} []?>/<.,';:".ToCharArray()) != -1)
            {
                e.Handled = true;
                MessageBox.Show("Tên sản phẩm không được chứa các ký tự đặc biệt");
                txtTenSP.Text = "";
                txtTenSP.Focus();


            }
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString().IndexOfAny(@"QWERTYUIOPASDFGHJKLZXCVBNMqwertyuioplkjhgfdsazxcvbnm!@#$%^&*()_+=|\{} []?>/<.,';:".ToCharArray()) != -1)
            {
                e.Handled = true;
                MessageBox.Show("Đây không phải là kiểu dữ liệu tiền tệ");
                txtGia.Text = "";
                txtGia.Focus();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbtim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbtim.SelectedIndex ==0)
            {
                ma_tim = "ma_sp";
            }
            else if (cmbtim.SelectedIndex == 1)
            {
                ma_tim = "ten_sp";
            }
            else if (cmbtim.SelectedIndex == 2)
            {
                ma_tim = "gia";
            }
            else if (cmbtim.SelectedIndex == 3)
            {
                ma_tim = "ma_loai";
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTim.Text == "")
            {
                MessageBox.Show("Bạn phải nhập vào từ khóa cần tìm kiếm!");
                txtTim.Text = "";
            }
            else if (cmbtim.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn từ Combobox");
            }
            else
            {
                load_timkiem();
            }
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            if (txtTim.Text == "")
            {
                load_menu();
            }
            
        }
    }
}