using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Quanlyquancafe.Data_Layer;
using Quanlyquancafe.Connect;

namespace Quanlyquancafe.Business_Layer
{
     public class NhanvienBs
    {
        //ket noi
        private connect ketnoi = new connect();

        //Them mot ban ghi

        public void goi_themBS(string ma_goimon,string matang,string maban,string matk)
        {
            try
            {
                connect cnt = new connect();
                string sql1 = "insert into goi_mon values ('" + ma_goimon + "','" + matang + "','" + maban + "','" + matk + "')";
                cnt.Excute(sql1);
            }
            catch
            {

            }
        }



        public void dsgoi_themBS(string ma_goimon, string ma_sp, int soluong)
        {
            try
            {
                connect cnt = new connect();
                string sql = "insert into danh_sach_goi_mon values ('" + ma_goimon + "','" + ma_sp + "','" + soluong + "')";
                cnt.Excute(sql);


            }
            catch
            {

            }
        }


    }
}
