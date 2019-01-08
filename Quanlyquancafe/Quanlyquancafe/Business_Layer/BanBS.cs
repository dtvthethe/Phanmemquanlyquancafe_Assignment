using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quanlyquancafe.Data_Layer;
using Quanlyquancafe.Connect;
using System.Data.SqlClient;

namespace Quanlyquancafe.Business_Layer
{
   public class BanBS
    {
        //ket noi
        private connect ketnoi = new connect();

        // load ds ban
        public List<BanDB> tang()
        {
            List<BanDB> tang = new List<BanDB>();

            try
            {
                SqlConnection cn = new SqlConnection(ketnoi.cn);
                cn.Open();
                string sql = "select * from ban";
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    BanDB ban = new BanDB();
                    ban.ma_ban= rd.GetString(0);
                    ban.ten_ban = rd.GetString(1);
                    ban.trang_thai = rd.GetBoolean(2);
                    ban.matang = rd.GetString(3);
                    tang.Add(ban);
                }
                rd.Close();
            }
            catch
            { }
            return tang;
        }

        // hien thi ban theo ma -- form nhan vien
        public List<BanDB> ban_view(string ma)
        {
            List<BanDB> bandb = new List<BanDB>();

            try
            {
                SqlConnection cn = new SqlConnection(ketnoi.cn);
                cn.Open();
                string sql = "select * from ban where ma_tang = '"+ma+"'";
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    BanDB ban = new BanDB();
                    ban.ma_ban = rd.GetString(0);
                    ban.ten_ban = rd.GetString(1);
                    ban.trang_thai = rd.GetBoolean(2);
                    ban.matang = rd.GetString(3);
                    bandb.Add(ban);
                }
                rd.Close();
            }
            catch
            { }
            return bandb;
        }

        // hien thi ban theo ma -- form nhan vien
        public List<BanDB> ban_timkiem(string tukhoa,string tim_theo,string tang)
        {
            List<BanDB> bandb = new List<BanDB>();

            try
            {
                SqlConnection cn = new SqlConnection(ketnoi.cn);
                cn.Open();
                string sql = "select * from ban where "+tim_theo+" like '%" + tukhoa + "%' and ma_tang = '"+tang+"'";
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    BanDB ban = new BanDB();
                    ban.ma_ban = rd.GetString(0);
                    ban.ten_ban = rd.GetString(1);
                    ban.trang_thai = rd.GetBoolean(2);
                    ban.matang = rd.GetString(3);
                    bandb.Add(ban);
                }
                rd.Close();
            }
            catch
            { }
            return bandb;
        }


        //Them mot ban ghi

        public void ban_themBS(string ma_ban, string ten_ban,string ma_tang)
        {
            //try
            //{
                connect cnt = new connect();
                string sql = "insert into ban values ('" + ma_ban + "',N'" + ten_ban + "','False','"+ma_tang+"')";
                cnt.Excute(sql);
            //}
            //catch
            //{

            //}
        }


        //Sua tang thai khi su dung

        public void ban_thangthai_suaBS( string ma_ban)
        {
            try
            {
                connect cnt = new connect();
                string sql = "update ban set  trang_thai = 'True' where ma_ban = '" + ma_ban + "'";
                cnt.Excute(sql);
            }
            catch
            {

            }
        }


        //Sua mot ban ghi

        public void ban_suaBS(string ten_ban, string ma_tang,string ma_ban)
        {
            try
            {
                connect cnt = new connect();
                string sql = "update ban set  ten_ban = '" + ten_ban + "', ma_tang = '" + ma_tang + "' where ma_ban = '" + ma_ban + "'";
                cnt.Excute(sql);
            }
            catch
            {

            }
        }

       //Xoa mot ban ghi

        public void ban_xoaBS(string ma_ban)
        {
            try
            {
                connect cnt = new connect();
                string sql = "delete from ban where ma_ban = '"+ma_ban+"'";
                cnt.Excute(sql);
            }
            catch
            {

            }
        }



    }
}
