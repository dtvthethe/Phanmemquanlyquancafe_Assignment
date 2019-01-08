using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Quanlyquancafe.Data_Layer;
using Quanlyquancafe.Business_Layer;

namespace Quanlyquancafe.form
{
    public partial class frmDanhsachgoimon : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmDanhsachgoimon()
        {
            InitializeComponent();
        }

        private int ma_goi_mon;
        private string ten;
        private string magoimon;
        private string maban;
        private string magm;
        private bool trangthai = false;
        //private bool them_themmoi = false;


        private void load_menu()
        {
            listView1.Items.Clear();
            menuBS bs = new menuBS();

            List<menuDB> ds = bs.loadMenu();

            for (int i = 0; i < ds.Count; i++)
            {
                cmbTen.Items.Add(ds[i].ten_sp.ToString());
                
            }
        }

        private void FillCustomerListBox()
        {
            List<dangNhapDB> customers = new List<dangNhapDB>();
            for (int i = 0; i < customers.Count; i++)
            {
                dangNhapDB c = customers[i];
             
                MessageBox.Show(c.ma.ToString());
            }
        }

        private string convertToMaTang(string tang)
        {
            string text = "";
            TangBS bs = new TangBS();

            List<TangDB> ds = bs.tang();

            for (int i = 0; i < ds.Count; i++)
            {
                if (cmbTang.Text == ds[i].tentang.ToString())
                {
                    text = ds[i].matang.ToString();
                    break;
                }
            }
            return text;
        }

        private string convertToMaBan(string ban)
        {
            string text = "";
            BanBS bs = new BanBS();

            List<BanDB> ds = bs.tang();

            for (int i = 0; i < ds.Count; i++)
            {
                if (cmbBan.Text == ds[i].ten_ban.ToString())
                {
                    text = ds[i].ma_ban.ToString();
                    break;
                }
            }
            return text;
        }

        private string laymagoimon()
        {
            string text = "";
            goiMonBS bs = new goiMonBS();

            List<goiMonDB> ds = bs.laymasogoimon(convertToMaBan(cmbBan.Text));

            for (int i = 0; i < ds.Count; i++)
            {
                    text = ds[i].ma_goimon.ToString();
                    magoimon = ds[i].ma_goimon.ToString();
            }
            return text;
        }

        private void loadds_goiMon(string ma)
        {
            listView1.Items.Clear();
            danhsachgoimonBS bs = new danhsachgoimonBS();

            List<danhsachGoiMon> ds = bs.load_ds_goimon(ma);

            for (int i = 0; i < ds.Count; i++)
            {
                    listView1.Items.Add(ds[i].ma_sp.ToString());
                    listView1.Items[i].SubItems.Add(ds[i].soluong.ToString());
                    listView1.Items[i].SubItems.Add(ds[i].ma_sp1.ToString());
                    listView1.Items[i].SubItems.Add(ds[i].gia.ToString());
            }
        }

        private decimal thanhtoan(string ma)
        {
            int soluong = 0;
            decimal gia = 0;
            decimal  tongtien=0;
            danhsachgoimonBS bs = new danhsachgoimonBS();
            List<danhsachGoiMon> ds = bs.load_ds_goimon(ma);
            for (int i = 0; i < ds.Count; i++)
            {
               soluong= Convert.ToInt32(ds[i].soluong.ToString());

               gia= Convert.ToDecimal(ds[i].gia.ToString());

               tongtien += (soluong * gia);
            }
            return tongtien;
        }

        private string convertToMaUser(string ten)
        {
            string text = "";
            TaiKhoanBS bs = new TaiKhoanBS();

            List<TaiKhoanDB> ds = bs.loadtk();

            for (int i = 0; i < ds.Count; i++)
            {
                if (user.Text == ds[i].tentk.ToString())
                {
                    text = ds[i].matk.ToString();
                    break;
                }
            }
            return text;
        }

        private void Valuema_goi_mon()
        {
            goiMonBS bs = new goiMonBS();
            List<goiMonDB> ds = bs.loadGoiMon();
            int a = Convert.ToInt32( ds.Count.ToString());
            if (a == 0)
            {
                ma_goi_mon = 0;
            }
            else
            {
                ma_goi_mon = a + 1;
            }
        }

        private string convertToMaSP(string ten)
        {
            string text = "";
            menuBS bs = new menuBS();

            List<menuDB> ds = bs.loadMenu();

            for (int i = 0; i < ds.Count; i++)
            {
                if ( ten == ds[i].ten_sp.ToString())
                {
                    text = ds[i].ma_sp.ToString();
                    break;
                }
            }
            return text;
        }

        private void hienthidanhsachgoimon()
        {
           
            goiMonBS bs = new goiMonBS();

            List<danhsachGoiMon> ds = bs.dsgoimon(laymagoimon());

            for (int i = 0; i < ds.Count; i++)
            {
                    listView1.Items.Add(ds[i].ma_sp.ToString());
                    listView1.Items[i].SubItems.Add(ds[i].soluong.ToString());
            }
        }


        private void magoimon1()
        {
            danhsachgoimonBS bs = new danhsachgoimonBS();

            List<danhsachGoiMon> ds = bs.lay_magoimon(maban);

            for (int i = 0; i < ds.Count; i++)
            {
                  magm= ds[i].ma_goi_mon.ToString();
            }
        }
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (cmbTen.Text == "" & txtSoLuong.Text == "")
            {
                MessageBox.Show("Bạn phải chọn từ Combobox một sản phẩm và nhập vào Textbox một giá trị");

            }
            else if (cmbTen.Text == "")
            {
                MessageBox.Show("Bạn phải chọn từ Combobox một sản phẩm !");
            }
            else if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Bạn phải nhập một giá trị vào Textbox !");
                txtSoLuong.Focus();
            }
            else
            {
                if (trangthai == false)
                {
                    maban = convertToMaBan(cmbBan.Text);
                    magoimon1();
                    try
                    {
                        danhsachgoimonBS bs = new danhsachgoimonBS();
                        bs.themvao_ds_goimon(magm, convertToMaSP(cmbTen.Text), Convert.ToInt32(txtSoLuong.Text));
                    }
                    catch
                    {
                        MessageBox.Show("Đã có lỗi xảy ra trong quá trình thêm");
                    }
                }
                else if (trangthai == true)
                {
                    try
                    {
                        goiMonBS bs = new goiMonBS();
                        bs.danhsach_goimon_themBS(Convert.ToString(ma_goi_mon), convertToMaSP(cmbTen.Text), Convert.ToInt32(txtSoLuong.Text));

                        MessageBox.Show(Convert.ToString(ma_goi_mon));
                        MessageBox.Show(convertToMaSP(cmbTen.Text));
                        MessageBox.Show(txtSoLuong.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Có lỗi xảy ra trong quá trình thêm");
                    }
                }
            }
                
                



            loadds_goiMon(laymagoimon());
            lbGia.Text = "" + Convert.ToString(thanhtoan(laymagoimon())) + " vnđ";
 
            
        }

        private void frmDanhsachgoimon_Load(object sender, EventArgs e)
        {
            this.load_menu();

            if (btnSudungban.Enabled == true)
            {
                cmbTen.Enabled = false;
                txtSoLuong.Enabled = false;
                btnThem.Enabled = false;
                btnThanhtoan.Enabled = false;
                trangthai = false;
            }
            else if (btnSudungban.Enabled == false)
            {
                decimal gia;
                cmbTen.Enabled = true;
                txtSoLuong.Enabled = true;
                btnThem.Enabled = true;
                btnThanhtoan.Enabled = true;
                loadds_goiMon(laymagoimon());
               //lbGia.Text = ""+ Convert.ToString( thanhtoan(laymagoimon()))+" vnđ";
            gia = Convert.ToDecimal(thanhtoan(laymagoimon()));

            lbGia.Text = string.Format("{0:c}", gia);
               trangthai = false;
            }
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            try
            {
                Valuema_goi_mon();
                goiMonBS goimon = new goiMonBS();
                BanBS banbs = new BanBS();

                //them vao bang goi mon
                goimon.goimon_themBS(Convert.ToString(ma_goi_mon), convertToMaTang(cmbTang.Text), convertToMaBan(cmbBan.Text), convertToMaUser(user.Text));
                banbs.ban_thangthai_suaBS(convertToMaBan(cmbBan.Text));
                MessageBox.Show("Bàn sẵn sàng để sử dụng");

            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra khi sử dụng bàn này");
            }

            btnSudungban.Enabled = false;
            cmbTen.Enabled = true;
            txtSoLuong.Enabled = true;
            btnThem.Enabled = true;
            btnThanhtoan.Enabled = true;  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNhanVien n  = new frmNhanVien();
            MessageBox.Show(n.user.Text);
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            ten = listView1.SelectedItems[0].SubItems[2].Text;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
             DialogResult msg = MessageBox.Show("Có phải bạn muốn xóa " + listView1.SelectedItems[0].Text + " không?", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
             try
             {
                 if (msg == DialogResult.OK)
                 {
                     goiMonBS bs = new goiMonBS();

                     bs.danhsach_goimon_xoaBS(ten);
                     MessageBox.Show("Xóa thành công");
                 }
             }
             catch
             {
                 MessageBox.Show("Đã có lỗi xảy ra trong quá trình xóa");
             }
             loadds_goiMon(laymagoimon());
        }

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Có phải bạn muốn xóa thực hiện thanh toán  không?", "Thanh toán", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            try
            {
                if (msg == DialogResult.OK)
                {
                    goiMonBS bs = new goiMonBS();
                    bs.danhsach_goimon_thanhtoanBS(magoimon, convertToMaBan(cmbBan.Text));
                }
            }
            catch
            {
                MessageBox.Show("Qúa trình thực hiện đã có lỗi");
            }
            cmbBan.Text = "";
            cmbTang.Text = "";
            cmbTen.Text = "";
            cmbBan.Enabled = true;
            cmbTang.Enabled = true;
            cmbTen.Enabled = false;
            btnSudungban.Enabled = true;
            txtSoLuong.Enabled = false;
            btnThem.Enabled = false;
            btnThanhtoan.Enabled = false;
            btnXoa.Enabled = false;

            loadds_goiMon(laymagoimon());
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString().IndexOfAny(@"QWERTYUIOPLKJHGFDSAZXCVBNMqwertyuioplkjhgfdsazxcvbnm!@#$%^&*()_+=|\{} []?>/<.,';:".ToCharArray()) != -1)
            {
                e.Handled = true;
                MessageBox.Show("Gía trị nhập vào không được chứa các ký tự đặc biệt hay ký tự chữ cái");
                txtSoLuong.Text = "";
                txtSoLuong.Focus();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void cmbTen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
