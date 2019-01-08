using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Quanlyquancafe.Data_Layer;
using Quanlyquancafe.Connect;

namespace Quanlyquancafe.Business_Layer
{
    public class dangNhapBS
    {
        // ket noi
        private connect ketnoi = new connect();

        // dang nhap
        public List<dangNhapDB> dangnhap(string tk, string mk)
        {
            List<dangNhapDB> dangnhap = new List<dangNhapDB>();
            try
            {
                SqlConnection cn = new SqlConnection(ketnoi.cn);
                cn.Open();
                string sql = "select * from dang_nhap where ten_dang_nhap = '" + tk + "' and mat_khau = '" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    dangNhapDB dn = new dangNhapDB();
                    dn.ma = rd.GetString(0);
                    dn.tk = rd.GetString(1);
                    dn.mk = rd.GetString(2);
                    dn.chucvu = rd.GetString(3);
                    dangnhap.Add(dn);
                }
                rd.Close();

            }
            catch
            { }
            return dangnhap;
        }


    }
}
