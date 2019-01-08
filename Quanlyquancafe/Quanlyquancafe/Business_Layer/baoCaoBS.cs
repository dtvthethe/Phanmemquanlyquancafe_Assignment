using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Quanlyquancafe.Data_Layer;
using Quanlyquancafe.Connect;


namespace Quanlyquancafe.Business_Layer
{
   public class baoCaoBS
    {
        //ket noi
       private connect ketnoi = new connect();

        //load du lieu
        public List<BaocaoDB> baocao()
        {
            List<BaocaoDB> baocao = new List<BaocaoDB>();
            try
            {
                SqlConnection cn = new SqlConnection(ketnoi.cn);
                cn.Open();
                string sql = "SELECT  menu.ten_sp, SUM(danh_sach_goi_mon.so_luong) AS Expr1, SUM(menu.gia) AS Expr2 FROM  menu INNER JOIN danh_sach_goi_mon ON menu.ma_sp = danh_sach_goi_mon.ma_sp GROUP BY menu.ten_sp";
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    BaocaoDB ld = new BaocaoDB();
                    ld.tensp = rd.GetString(0);
                    ld.soluong_banra = rd.GetInt32(1);
                    ld.gia = rd.GetDecimal(2);

                    baocao.Add(ld);
                }
                rd.Close();
            }
            catch
            {

            }

            return baocao;

        }
    }
}


