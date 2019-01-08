using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Quanlyquancafe.Data_Layer;
using Quanlyquancafe.Business_Layer;

namespace Quanlyquancafe.form
{
    public partial class FRMBaocao : Form
    {
        public FRMBaocao()
        {
            InitializeComponent();
        }


        private  void tinhtongtien()
        {
            decimal tongtien=0;
            int soluong = 0;
           baoCaoBS bs = new baoCaoBS();
           List< BaocaoDB> ds = bs.baocao();
            for (int i = 0;i<ds.Count;i++)
            {
                tongtien += Convert.ToDecimal( ds[i].gia.ToString());
                soluong += Convert.ToInt32(ds[i].gia);
            }

            lbtongtien.Text =""+ Convert.ToString( tongtien)+" vnđ";
            lbsoluong.Text =  Convert.ToString(soluong);
        }


        private void FRMBaocao_Load(object sender, EventArgs e)
        {
            baoCaoBS bs = new baoCaoBS();

            dataGridView1.DataSource = bs.baocao();
            tinhtongtien();
        }
    }
}
