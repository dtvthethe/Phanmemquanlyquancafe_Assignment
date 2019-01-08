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

namespace Quanlyquancafe.form
{
    public partial class frmNhanVien : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private string picturex;
        private string ma_ban;
        private string ten_ban;
        private string timtheo;
        private string ma_tang;

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


        private string convertTo(string ma)
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

        private void load_anh(string patch)
        {
            if (patch == "0")
            {
                pictureBox1.ImageLocation = @"img\no.jpg";
            }
            else
            {
                pictureBox1.ImageLocation = @"img\" + patch + ".jpg";

            }
        }

        private void load_tang()
        {
            listView1.Items.Clear();
            TangBS bs = new TangBS();

            List<TangDB> ds = bs.tang();

            for (int i = 0; i < ds.Count; i++)
            {
                cmbTang.Items.Add(ds[i].tentang.ToString());
         
            }

        }


        private void timkiem()
        {
            listView2.Items.Clear();
            BanBS bs = new BanBS();

            List<BanDB> ds = bs.ban_timkiem(txtTim.Text, timtheo,ma_tang);

            for (int i = 0; i < ds.Count; i++)
            {
                listView2.Items.Add(ds[i].ma_ban.ToString());
                listView2.Items[i].SubItems.Add(ds[i].ten_ban.ToString());
                listView2.Items[i].SubItems.Add(ds[i].trang_thai.ToString());
                listView2.Items[i].SubItems.Add(ds[i].matang.ToString());
            }
        }


        public void view()
        {
            listView2.Items.Clear();
            BanBS bs = new BanBS();
            List<BanDB> ds = bs.ban_view(convertToMa(cmbTang.SelectedItem.ToString()));

            for (int i = 0; i < ds.Count; i++)
            {
                listView2.Items.Add(ds[i].ma_ban.ToString());
                listView2.Items[i].SubItems.Add(ds[i].ten_ban.ToString());
                listView2.Items[i].SubItems.Add(ds[i].trang_thai.ToString());
                listView2.Items[i].SubItems.Add(ds[i].matang.ToString());
            }

            try
            {
                for (int i = 0; i < ds.Count; i++)
                {
                    if (ds[i].trang_thai.ToString() == "True")
                    {
                        listView2.Items[i].BackColor = Color.Red;

                    }
                }
            }
            catch
            {
            }
        }


      



        private string convertToMa(string ten)
        {
            string text="";
            TangBS bs = new TangBS();

            List<TangDB> ds = bs.tang();

            for (int i = 0; i < ds.Count; i++)
            {
                if (ten == ds[i].tentang.ToString())
                {
                    text = ds[i].matang.ToString();
                }
            }
            return text;
        }



        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            this.load_tang();
            this.load_menu();

            
            if (listView2.Items.Count > 0)
            {
                listView2.ContextMenuStrip = contextMenuStrip1;
            }
            else if (listView2.Items.Count == 0)
            {
                listView2.ContextMenuStrip = null;
            }

            btnTim.Enabled = false;

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            //i = Convert.ToInt32(listView1.SelectedIndices[0].ToString());

            txtMaSP.Text = listView1.SelectedItems[0].Text;
            txtTenSP.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtGia.Text = listView1.SelectedItems[0].SubItems[2].Text;
           
            txtLoaiDoAn.Text = convertTo(listView1.SelectedItems[0].SubItems[3].Text);
            picturex = listView1.SelectedItems[0].SubItems[4].Text;
            this.load_anh(picturex);
        }

        private void cmbTang_SelectedIndexChanged(object sender, EventArgs e)
        {

            TangBS bs = new TangBS();
            List<TangDB> ds = bs.tang();

            for (int i = 0; i < ds.Count; i++)
            {
                if (cmbTang.SelectedItem.ToString() == ds[i].tentang.ToString())
                {
                    ma_tang = ds[i].matang.ToString();
                }
            }

            if (cmbTang.Text != "" & txtTim.Text != "" & cmbTim.Text != "")
            {
                btnTim.Enabled = true;
                
            }
            else if (cmbTang.Text == "" | txtTim.Text == "" | cmbTim.Text == "")
            {
                btnTim.Enabled = false;
            }

            

            listView2.Items.Clear();
            this.view();
            listView2.Focus();

            if (listView2.Items.Count > 0)
            {
                listView2.ContextMenuStrip = contextMenuStrip1;
            }
            else if (listView2.Items.Count == 0)
            {
                listView2.ContextMenuStrip = null;
            }

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count == 0) return;
          
           ma_ban =  listView2.SelectedItems[0].Text;
           ten_ban = listView2.SelectedItems[0].SubItems[1].Text;


        }

        private void xemThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
            frmDanhsachgoimon f = new frmDanhsachgoimon();
            f.user.Text = user.Text;
            f.cmbTang.Text = cmbTang.SelectedItem.ToString();
            f.cmbBan.Text = ten_ban;

            if (listView2.SelectedItems[0].SubItems[2].Text == "True")
            {

                f.btnSudungban.Enabled = false;
            }
            else
            {
                f.btnSudungban.Enabled = true;
            }

            f.ShowDialog();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void refeshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view();
        }

        private void cmbTim_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbTang.Text != "" & txtTim.Text != "" & cmbTim.Text != "")
            {
                btnTim.Enabled = true;

            }
            else if (cmbTang.Text == "" | txtTim.Text == "" | cmbTim.Text == "")
            {
                btnTim.Enabled = false;
            }



            if (cmbTim.SelectedItem.ToString()=="Mã bàn")
            {
                timtheo= "ma_ban";
            }
            else if (cmbTim.SelectedItem.ToString() == "Tên bàn")
            {
                timtheo= "ten_ban";
            }
            else if (cmbTim.SelectedItem.ToString()=="Mã tầng")
            {
                timtheo= "ma_tang";
            }
            
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (cmbTang.Text != "" & txtTim.Text != "" & cmbTim.Text != "")
            {
                btnTim.Enabled = true;
               
            }
            else if (cmbTang.Text == "" | txtTim.Text == "" | cmbTim.Text == "")
            {
                btnTim.Enabled = false;
            }

            timkiem();
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            if (cmbTang.Text != "" & txtTim.Text != "" & cmbTim.Text != "")
            {
                btnTim.Enabled = true;

            }
            else if (cmbTang.Text == "" | txtTim.Text == "" | cmbTim.Text == "")
            {
                btnTim.Enabled = false;
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBanQuyen n = new frmBanQuyen();
            n.ShowDialog();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThongtin n = new frmThongtin();
            n.ShowDialog();
        }
    }
}
