using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Quanlyquancafe.Data_Layer;
using Quanlyquancafe.Connect;

namespace Quanlyquancafe.Business_Layer
{
   public class danhsachgoimonBS
    {
        //ket noi
        private connect ketnoi = new connect();

        //load du lieu
        public List<danhsachGoiMon> load_ds_goimon(string ma)
        {
            List<danhsachGoiMon> load_ds_goimon = new List<danhsachGoiMon>();
            try
            {
                SqlConnection cn = new SqlConnection(ketnoi.cn);
                cn.Open();
                //string sql = "SELECT danh_sach_goi_mon.ma_goi_mon, menu.ten_sp, danh_sach_goi_mon.so_luong,danh_sach_goi_mon.ma_sp, danh_sach_goi_mon.trang_thai FROM danh_sach_goi_mon INNER JOIN menu ON danh_sach_goi_mon.ma_sp = menu.ma_sp WHERE ma_goi_mon = '" + ma + "' and trang_thai = 'True'";
                string sql = "SELECT danh_sach_goi_mon.ma_goi_mon, menu.ten_sp, danh_sach_goi_mon.so_luong, danh_sach_goi_mon.ma_sp, danh_sach_goi_mon.trang_thai, menu.gia FROM danh_sach_goi_mon INNER JOIN menu ON danh_sach_goi_mon.ma_sp = menu.ma_sp WHERE ma_goi_mon = '" + ma + "' and trang_thai = 'True'";
               
                
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    danhsachGoiMon mn = new danhsachGoiMon();
                    mn.ma_goi_mon = rd.GetString(0);
                    mn.ma_sp = rd.GetString(1);
                    mn.soluong = rd.GetInt32(2);
                    mn.ma_sp1 = rd.GetString(3);
                    mn.trangthai = rd.GetBoolean(4);
                    mn.gia = rd.GetDecimal(5);
                    load_ds_goimon.Add(mn);
                }
                rd.Close();
            }
            catch
            {}
            return load_ds_goimon;
        }



        //lay ma goi mon
        public List<danhsachGoiMon> lay_magoimon(string maban)
        {
            List<danhsachGoiMon> lay_magoimon = new List<danhsachGoiMon>();
            try
            {
                SqlConnection cn = new SqlConnection(ketnoi.cn);
                cn.Open();
                //string sql = "SELECT danh_sach_goi_mon.ma_goi_mon, menu.ten_sp, danh_sach_goi_mon.so_luong,danh_sach_goi_mon.ma_sp, danh_sach_goi_mon.trang_thai FROM danh_sach_goi_mon INNER JOIN menu ON danh_sach_goi_mon.ma_sp = menu.ma_sp WHERE ma_goi_mon = '" + ma + "' and trang_thai = 'True'";
                string sql = "select ma_goi_mon from goi_mon where ma_ban = '"+maban+"' and trangthai = 'True' ";


                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    danhsachGoiMon mn = new danhsachGoiMon();
                    mn.ma_goi_mon = rd.GetString(0);
                    lay_magoimon.Add(mn);
                }
                rd.Close();
            }
            catch
            { }
            return lay_magoimon;
        }


       //them vaodanh sach goi mon

        public void themvao_ds_goimon(string magm,string masp,int soluong)
        {
            try
            {
                connect cnt = new connect();
                string sql = "insert into danh_sach_goi_mon values ('" + magm + "','" + masp + "','" + soluong + "','True')";
                cnt.Excute(sql);
            }
            catch
            { }
            

        }

    }
}




