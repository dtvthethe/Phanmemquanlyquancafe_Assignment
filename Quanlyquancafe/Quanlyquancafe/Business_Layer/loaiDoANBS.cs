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
    public class loaiDoANBS
    {
        //ket noi
        private connect ketnoi = new connect();

          //load du lieu
        public List<loaiDoAnDB> loadloaiDoAn()
        {
            List<loaiDoAnDB> loadloaiDoAn = new List<loaiDoAnDB>();
            try
            {
                SqlConnection cn = new SqlConnection(ketnoi.cn);
                cn.Open();
                string sql = "SELECT * FROM loai_do_an";
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    loaiDoAnDB ld = new loaiDoAnDB();
                    ld.maloai = rd.GetString(0);
                    ld.tenloai = rd.GetString(1);
                    
                    loadloaiDoAn.Add(ld);
                }
                rd.Close();
            }
            catch
            {
                
            }

            return loadloaiDoAn;

        }


        //Them mot ban ghi

        public void ldoan_themBS(string ma_loai, string tenloai)
        {
            try
            {
                connect cnt = new connect();
                string sql = "insert into loai_do_an values ('" + ma_loai + "',N'" + tenloai + "')";
                cnt.Excute(sql);
            }
            catch
            {

            }
        }



        //Xoa mot ban ghi

        public void ldoan_xoaBS(string ma_loai)
        {
            try
            {
                connect cnt = new connect();
                string sql = "delete from loai_do_an where ma_loai = '" + ma_loai + "'";
                cnt.Excute(sql);
            }
            catch
            {

            }
        }


        //Sua mot ban ghi

        public void ldoan_suaBS(string ma_loai, string tenloai)
        {
            try
            {
                connect cnt = new connect();
                string sql = "update loai_do_an  set  ten_loai = N'" + tenloai + "' where ma_loai = '" + ma_loai + "'";
                cnt.Excute(sql);
            }
            catch
            {

            }
        }


    }
}
