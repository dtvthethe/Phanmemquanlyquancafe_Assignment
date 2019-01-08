using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Quanlyquancafe.Business_Layer;
using Quanlyquancafe.Data_Layer;
using Quanlyquancafe.Connect;

namespace Quanlyquancafe.form
{
    public partial class frmThongke : Form
    {
        public frmThongke()
        {
            InitializeComponent();
        }

        private void frmThongke_Load(object sender, EventArgs e)
        {
            ThongkeBS tk = new ThongkeBS();
            dataGridView1.DataSource = tk.thongke();
        }
    }
}
