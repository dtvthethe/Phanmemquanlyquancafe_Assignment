using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Quanlyquancafe.Data_Layer;
using Quanlyquancafe.Connect;
using System.Windows.Forms;

namespace Quanlyquancafe.Business_Layer
{
   public class goiMonBS
    {
        //ket noi
        private connect ketnoi = new connect();


        //load du lieu
        public List<goiMonDB> loadGoiMon()
        {
            List<goiMonDB> loadGoiMon = new List<goiMonDB>();
            try
            {
                SqlConnection cn = new SqlConnection(ketnoi.cn);
                cn.Open();
                string sql = "SELECT * FROM goi_mon";
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    goiMonDB gm = new goiMonDB();
                    gm.ma_goimon = rd.GetString(0);
                    gm.matang = rd.GetString(1);
                    gm.maban = rd.GetString(2);
                    gm.matk = rd.GetString(3);

                    loadGoiMon.Add(gm);
                }
                rd.Close();
            }
            catch
            {

            }

            return loadGoiMon;

        }

       //hien thi danh sach goi mon
 
        public List<goiMonDB> tim_ma(string ma_tang,string ma_ban)
        {
            List<goiMonDB> tim_ma = new List<goiMonDB>();
            try
            {
                SqlConnection cn = new SqlConnection(ketnoi.cn);
                cn.Open();
                string sql = "SELECT * FROM goi_mon where ma_tang = '" + ma_tang + "' and ma_ban = '"+ma_ban+"' and trang_thai = 'True'";
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    goiMonDB gm = new goiMonDB();
                    gm.ma_goimon = rd.GetString(0);
                    gm.matang = rd.GetString(1);
                    gm.maban = rd.GetString(2);
                    gm.matk = rd.GetString(3);
                    tim_ma.Add(gm);
                }
                rd.Close();
            }
            catch
            {

            }

            return tim_ma;

        }



        public List<goiMonDB> laymasogoimon(string maban)
        {
            List<goiMonDB> laymasogoimon = new List<goiMonDB>();
            try
            {
                SqlConnection cn = new SqlConnection(ketnoi.cn);
                cn.Open();
                string sql = "SELECT ma_goi_mon FROM goi_mon where ma_ban = '" + maban + "' and trangthai = 'True'";
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    goiMonDB gm = new goiMonDB();
                    gm.ma_goimon = rd.GetString(0);

                    laymasogoimon.Add(gm);
                }
                rd.Close();
            }
            catch
            {
            }
            return laymasogoimon;

        }


        //Them mot ban ghi

        public void goimon_themBS(string magoimon, string matang, string maban, string matk)
        {
            string sql = "insert into goi_mon values (" + magoimon + ",'" + matang + "','" + maban + "','" + matk + "','True')";
            ketnoi.Excute(sql);
        }


        //Them vao danh sach cac mon dc goi

        public void danhsach_goimon_themBS(string magoimon, string masp, int soluong)
        {
            string sql = "insert into danh_sach_goi_mon values ('" + magoimon + "','" + masp + "'," + soluong + ",'True')";
            ketnoi.Excute(sql);
        }


        //xoa di mot mon an trong ds

        public void danhsach_goimon_xoaBS(string ma)
        {
            string sql = "delete from danh_sach_goi_mon where ma_sp = '" + ma + "' and trang_thai = 'True'";
            ketnoi.Excute(sql);
        }


        //Thanh toan

        public void danhsach_goimon_thanhtoanBS(string mads_goimon,string maban)
        {
            string sql = "update danh_sach_goi_mon set trang_thai = 'False' where ma_goi_mon = '" + mads_goimon + "' and trang_thai = 'True'";
            ketnoi.Excute(sql);

            string sql1 = "update goi_mon set trangthai = 'False' where ma_goi_mon = '" + mads_goimon + "' and trangthai = 'True'";
            ketnoi.Excute(sql1);

            string sql2 = "update ban set trang_thai = 'False' where ma_ban = '" + maban + "' and trang_thai = 'True'";
            ketnoi.Excute(sql2);
        }






































































































        public List<danhsachGoiMon> dsgoimon(string magoimon)
        {
            List<danhsachGoiMon> dsgoimon = new List<danhsachGoiMon>();
            try
            {
                SqlConnection cn = new SqlConnection(ketnoi.cn);
                cn.Open();
                string sql = "SELECT * FROM danh_sach_goi_mon where ma_goi_mon = '" + magoimon + "' and trang_thai = 'True'";
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    danhsachGoiMon gm = new danhsachGoiMon();
                    gm.ma_sp = rd.GetString(0);
                    gm.soluong = rd.GetInt32(1);

                    dsgoimon.Add(gm);
                }
                rd.Close();
            }
            catch
            {

            }

            return dsgoimon;

        }





    }
}
