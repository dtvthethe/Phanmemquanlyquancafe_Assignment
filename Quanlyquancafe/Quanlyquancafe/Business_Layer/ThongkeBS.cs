using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Quanlyquancafe.Data_Layer;
using Quanlyquancafe.Connect;

namespace Quanlyquancafe.Business_Layer
{
    public class ThongkeBS
    {
        //ket noi
        private connect ketnoi = new connect();

        //load du lieu
        public List<ThongkeDB> thongke()
        {
            List<ThongkeDB> thongke = new List<ThongkeDB>();
            try
            {
                SqlConnection cn = new SqlConnection(ketnoi.cn);
                cn.Open();
                string sql = "SELECT menu.ten_sp, SUM(danh_sach_goi_mon.so_luong) AS Expr1 FROM danh_sach_goi_mon INNER JOIN menu ON danh_sach_goi_mon.ma_sp = menu.ma_sp GROUP BY menu.ten_sp ORDER BY Expr1 DESC";
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    ThongkeDB ld = new ThongkeDB();
                    ld.tensp = rd.GetString(0);
                    ld.soluong = rd.GetInt32(1);

                    thongke.Add(ld);
                }
                rd.Close();
            }
            catch
            {

            }

            return thongke;

        }
    }
}


