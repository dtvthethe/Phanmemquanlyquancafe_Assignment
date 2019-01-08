using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Quanlyquancafe.Connect
{
    public class connect
    {
        //chuoi ket noi
        public string cn = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\QLCF.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        
        

        //thuc thi
        public void Excute(string sql)
        {

            try
            {
                SqlConnection ketnoi = new SqlConnection(cn);
                ketnoi.Open();
                SqlCommand cm = new SqlCommand(sql, ketnoi);
                cm.ExecuteNonQuery();
                ketnoi.Close();
            
            }
            catch
            { }
                


            
        }


    }


    

}
