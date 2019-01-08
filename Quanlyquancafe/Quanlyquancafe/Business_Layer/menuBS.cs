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
   public class menuBS
    {
        //ket noi
        private connect ketnoi = new connect();

        //load du lieu
        public List<menuDB> loadMenu()
        {
            List<menuDB> loadMenu = new List<menuDB>();
            try
            {
                SqlConnection cn = new SqlConnection(ketnoi.cn);
                cn.Open();
                string sql = "SELECT * FROM menu";
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    menuDB mn = new menuDB();
                    mn.ma_sp = rd.GetString(0);
                    mn.ten_sp = rd.GetString(1);
                    mn.gia = rd.GetDecimal(2);
                    mn.ma_loai = rd.GetString(3);
                    mn.img = rd.GetString(4);
                    loadMenu.Add(mn);
                }
                rd.Close();
            }
            catch
            {
                
            }

            return loadMenu;

        }



       //Tim kiem
        public List<menuDB> menu_timkiemBS(string tencot,string tukhoa)
        {
            List<menuDB> loadMenu = new List<menuDB>();
            try
            {
                SqlConnection cn = new SqlConnection(ketnoi.cn);
                cn.Open();
                string sql = "SELECT * FROM menu WHERE ("+tencot+" LIKE '%" + tukhoa + "%')";

                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    menuDB mn = new menuDB();
                    mn.ma_sp = rd.GetString(0);
                    mn.ten_sp = rd.GetString(1);
                    mn.gia = rd.GetDecimal(2);
                    mn.ma_loai = rd.GetString(3);
                    mn.img = rd.GetString(4);
                    loadMenu.Add(mn);
                }
                rd.Close();
            }
            catch
            {

            }

            return loadMenu;

        }

       //Them mot ban ghi

        public void menu_themBS(string ma_sp, string tensp, decimal gia, string maloai, string img)   
        {
            try
            {
                connect cnt = new connect();
                string sql = "insert into menu values ('" + ma_sp + "',N'" + tensp + "','" + gia + "','" + maloai + "','" + img + "')";
                cnt.Excute(sql);
            }
            catch
            {
               
            }
        }


       //Xoa mot ban ghi

        public void menu_xoaBS(string ma_sp)
        {
            try
            {
                connect cnt = new connect();
                string sql = "delete from menu where ma_sp = '"+ma_sp+"'";
                cnt.Excute(sql);
            }
            catch
            {

            }
        }

        //Sua mot ban ghi

        public void menu_suaBS(string masp,string tensp, decimal gia, string maloai,string img)
        {
            try
            {
                connect cnt = new connect();
                string sql = "update menu set ten_sp = N'"+tensp+"', gia = '"+gia+"' , ma_loai = '"+maloai+"', img ='"+img+"' where ma_sp = '"+masp+"'";
                cnt.Excute(sql);
            }
            catch
            {

            }
        }
    }
}
