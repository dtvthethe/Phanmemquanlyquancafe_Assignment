using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quanlyquancafe.Data_Layer;
using Quanlyquancafe.Connect;
using System.Data.SqlClient;

namespace Quanlyquancafe.Business_Layer
{
    public class TangBS
    {
        //ket noi
        private connect ketnoi = new connect();

        // tang
        public List<TangDB> tang()
        {
            List<TangDB> tang = new List<TangDB>();

            try
            {
                SqlConnection cn = new SqlConnection(ketnoi.cn);
                cn.Open();
                string sql = "select * from tang";
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    TangDB floor = new TangDB();
                    floor.matang = rd.GetString(0);
                    floor.tentang = rd.GetString(1);
                    tang.Add(floor);
                }
                rd.Close();
            }
            catch
            { }
            return tang;
        }


        //Them mot ban ghi

        public void tang_themBS(string ma_tang, string tentang)
        {
            try
            {
                connect cnt = new connect();
                string sql = "insert into tang values ('" + ma_tang + "',N'" + tentang + "')";
                cnt.Excute(sql);
            }
            catch
            {

            }
        }



        //Xoa mot ban ghi

        public void tang_xoaBS(string ma_tang)
        {
            try
            {
                connect cnt = new connect();

                //string sql1 = "delete from ban where ma_tang = '" + ma_tang + "'";
                //cnt.Excute(sql1);

                string sql = "delete from tang where ma_tang = '" + ma_tang + "'";
                cnt.Excute(sql);

                
            }
            catch
            {

            }
        }

        //Sua mot ban ghi

        public void tang_suaBS(string ma_tang, string tentang)
        {
            try
            {
                connect cnt = new connect();
                string sql = "update tang set  ten_tang = '" + tentang + "' where ma_tang = '" + ma_tang + "'";
                cnt.Excute(sql);
            }
            catch
            {

            }
        }



    }
}
