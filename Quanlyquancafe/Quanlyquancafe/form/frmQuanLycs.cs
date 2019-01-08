using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quanlyquancafe.form
{
    public partial class frmQuanLycs : Form
    {
        public frmQuanLycs()
        {
            InitializeComponent();
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanlysp newForm = new frmQuanlysp();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void loạiĐồĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoaiDoAn newForm = new frmLoaiDoAn();
            newForm.MdiParent = this;

            newForm.Show();
        }

        private void sửaSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLtaikhoannguoidung newForm = new frmQLtaikhoannguoidung();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void tầngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTang newForm = new frmTang();
            newForm.MdiParent = this;

            newForm.Show();
        }

        private void bànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBan newForm = new frmBan();
            newForm.MdiParent = this;

            newForm.Show();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBanQuyen n = new frmBanQuyen();
            n.ShowDialog();
        }

        private void giupsĐỡToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongtin n = new frmThongtin();
            n.ShowDialog();
        }

        private void xemBáoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMBaocao n = new FRMBaocao();
            n.ShowDialog();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongke n = new frmThongke();
            n.ShowDialog();
        }
    }
}
