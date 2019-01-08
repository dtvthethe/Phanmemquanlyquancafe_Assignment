using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Quanlyquancafe.Data_Layer;
using Quanlyquancafe.Connect;

namespace Quanlyquancafe.Business_Layer
{
   public class loadPassWordBS
    {
        //ket noi
        private connect ketnoi = new connect();

        //load du lieu
        public List<loadPasswordDB> loadpass(string ma)
        {
            List<loadPasswordDB> loadpass = new List<loadPasswordDB>();
            try
            {
                SqlConnection cn = new SqlConnection(ketnoi.cn);
                cn.Open();
                string sql = "select mat_khau from dang_nhap where ma_tk = '"+ma+"'";

                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    loadPasswordDB tk = new loadPasswordDB();
                    tk.mk = rd.GetString(0);
                    loadpass.Add(tk);
                }
                rd.Close();
            }
            catch
            {

            }

            return loadpass;

        }
    }
}
