using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Quanlyquancafe.Data_Layer;
using Quanlyquancafe.Connect;

namespace Quanlyquancafe.Business_Layer
{
   public  class TaiKhoanBS
    {
        //ket noi
        private connect ketnoi = new connect();

        //load du lieu
        public List<TaiKhoanDB> loadtk()
        {
            List<TaiKhoanDB> loadtk = new List<TaiKhoanDB>();
            try
            {
                SqlConnection cn = new SqlConnection(ketnoi.cn);
                cn.Open();
                string sql = "SELECT nguoi_dung.ma_tk, dang_nhap.ten_dang_nhap, dang_nhap.chuc_vu, nguoi_dung.ten, nguoi_dung.dia_chi, nguoi_dung.sdt, nguoi_dung.email, nguoi_dung.img FROM dang_nhap INNER JOIN nguoi_dung ON dang_nhap.ma_tk = nguoi_dung.ma_tk";

                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    TaiKhoanDB tk = new TaiKhoanDB();
                    tk.matk = rd.GetString(0);
                    tk.tentk = rd.GetString(1);
                    tk.chucvu = rd.GetString(2);
                    tk.hoten = rd.GetString(3);
                    tk.diachi = rd.GetString(4);
                    tk.sdt = rd.GetString(5);
                    tk.email = rd.GetString(6);
                    tk.img = rd.GetString(7);
                    loadtk.Add(tk);
                }
                rd.Close();
            }
            catch
            {

            }

            return loadtk;

        }



        //Them mot ban ghi

        public void menu_themBS(string matk, string hoten, string diachi, string sdt, string email, string img, string tentk, string matkhau, string chucvu)
        {
            try
            {
                connect cnt = new connect();
                string sql = "insert into nguoi_dung values ('" + matk + "',N'" + hoten + "',N'" + diachi + "','" + sdt + "','" + email + "','" + img + "')";
                cnt.Excute(sql);

                string sql1 = "insert into dang_nhap values ('" + matk + "','" + tentk + "','" + matkhau + "','" + chucvu + "')";
                cnt.Excute(sql1);
            }
            catch
            {

            }
        }




        //Sua mot ban ghi

        public void tk_suaBS(string hoten,string diachi,string sdt,string email,string img,string ma)
        {
            try
            {
                connect cnt = new connect();
                string sql = "update nguoi_dung set ten = N'" + hoten + "', dia_chi = N'" + diachi + "' , sdt = '" + sdt + "', email ='" + email + "',img = '"+img+"' where ma_tk = '" + ma + "'";
                cnt.Excute(sql);
            }
            catch
            {

            }
        }

        //Sua mot ban ghi

        public void tk_doimkBS(string matkhau, string ma)
        {
            try
            {
                connect cnt = new connect();
                string sql = "update dang_nhap set mat_khau = '" + matkhau + "' where ma_tk = '" + ma + "'";
                cnt.Excute(sql);
            }
            catch
            {

            }
        }



        //Sua mot ban ghi

        public void tk_phanquyenBS(string ma,string cv)
        {
            try
            {
                connect cnt = new connect();
                string sql = "update dang_nhap set chuc_vu = '" + cv + "' where ma_tk = '" + ma + "'";
                cnt.Excute(sql);
            }
            catch
            {

            }
        }


        //load du lieu
        public List<TaiKhoanDB> timttk(string cot, string gaitri)
        {
            List<TaiKhoanDB> loadtk = new List<TaiKhoanDB>();
            try
            {
                SqlConnection cn = new SqlConnection(ketnoi.cn);
                cn.Open();
                string sql = "SELECT nguoi_dung.ma_tk, dang_nhap.ten_dang_nhap, dang_nhap.chuc_vu, nguoi_dung.ten, nguoi_dung.dia_chi, nguoi_dung.sdt, nguoi_dung.email, nguoi_dung.img FROM dang_nhap INNER JOIN nguoi_dung ON dang_nhap.ma_tk = nguoi_dung.ma_tk where "+cot+" like '%" + gaitri + "%'";

                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    TaiKhoanDB tk = new TaiKhoanDB();
                    tk.matk = rd.GetString(0);
                    tk.tentk = rd.GetString(1);
                    tk.chucvu = rd.GetString(2);
                    tk.hoten = rd.GetString(3);
                    tk.diachi = rd.GetString(4);
                    tk.sdt = rd.GetString(5);
                    tk.email = rd.GetString(6);
                    tk.img = rd.GetString(7);
                    loadtk.Add(tk);
                }
                rd.Close();
            }
            catch
            {

            }

            return loadtk;

        }




    
    }
}
