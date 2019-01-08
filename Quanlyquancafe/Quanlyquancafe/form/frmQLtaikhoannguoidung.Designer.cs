namespace Quanlyquancafe.form
{
    partial class frmQLtaikhoannguoidung
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLtaikhoannguoidung));
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.cmbTim = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtTentk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDoimk = new System.Windows.Forms.Button();
            this.btnPhanquyen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtmkmoi2 = new System.Windows.Forms.TextBox();
            this.lb3 = new System.Windows.Forms.Label();
            this.txtmkmoi = new System.Windows.Forms.TextBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.txtmkcu = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.cmbChucvu = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBr = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(583, 219);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimkiem.TabIndex = 0;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // cmbTim
            // 
            this.cmbTim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTim.FormattingEnabled = true;
            this.cmbTim.Items.AddRange(new object[] {
            "Mã tài khoản",
            "Tên đăng nhập",
            "Họ và tên"});
            this.cmbTim.Location = new System.Drawing.Point(446, 219);
            this.cmbTim.Name = "cmbTim";
            this.cmbTim.Size = new System.Drawing.Size(121, 21);
            this.cmbTim.TabIndex = 1;
            this.cmbTim.SelectedIndexChanged += new System.EventHandler(this.cmbTim_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(18, 19);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(616, 156);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã tài khoản";
            this.columnHeader1.Width = 79;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên đăng nhập";
            this.columnHeader2.Width = 97;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Chức vụ";
            this.columnHeader3.Width = 54;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Họ và tên";
            this.columnHeader4.Width = 96;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Địa chỉ";
            this.columnHeader5.Width = 104;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "SĐT";
            this.columnHeader6.Width = 89;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Email";
            this.columnHeader7.Width = 81;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "";
            this.columnHeader8.Width = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã tài khoản:";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(108, 21);
            this.txtMa.MaxLength = 5;
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(118, 20);
            this.txtMa.TabIndex = 4;
            this.txtMa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMa_KeyPress);
            // 
            // txtTentk
            // 
            this.txtTentk.Location = new System.Drawing.Point(108, 55);
            this.txtTentk.Name = "txtTentk";
            this.txtTentk.Size = new System.Drawing.Size(118, 20);
            this.txtTentk.TabIndex = 6;
            this.txtTentk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTentk_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Chức vụ:";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(74, 24);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(146, 20);
            this.txtTen.TabIndex = 10;
            this.txtTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTen_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Họ và tên:";
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(74, 60);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(146, 20);
            this.txtDiachi.TabIndex = 12;
            this.txtDiachi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiachi_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Địa chỉ:";
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(74, 100);
            this.txtsdt.MaxLength = 11;
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(146, 20);
            this.txtsdt.TabIndex = 14;
            this.txtsdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsdt_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "SĐT:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(10, 440);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 23);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm người dùng";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(113, 440);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 23);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa người dùng";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(209, 440);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 23);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Sửa thông tin";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(305, 440);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 18;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(401, 440);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(75, 23);
            this.btnBoqua.TabIndex = 19;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(323, 220);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(110, 20);
            this.txtTimkiem.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::Quanlyquancafe.Properties.Resources.no;
            this.pictureBox1.Image = global::Quanlyquancafe.Properties.Resources.no;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(255, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 97);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(74, 135);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(146, 20);
            this.txtEmail.TabIndex = 23;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Email:";
            // 
            // btnDoimk
            // 
            this.btnDoimk.Location = new System.Drawing.Point(492, 440);
            this.btnDoimk.Name = "btnDoimk";
            this.btnDoimk.Size = new System.Drawing.Size(90, 23);
            this.btnDoimk.TabIndex = 24;
            this.btnDoimk.Text = "Đổi mật khẩu";
            this.btnDoimk.UseVisualStyleBackColor = true;
            this.btnDoimk.Click += new System.EventHandler(this.btnDoimk_Click);
            // 
            // btnPhanquyen
            // 
            this.btnPhanquyen.Location = new System.Drawing.Point(597, 440);
            this.btnPhanquyen.Name = "btnPhanquyen";
            this.btnPhanquyen.Size = new System.Drawing.Size(90, 23);
            this.btnPhanquyen.TabIndex = 25;
            this.btnPhanquyen.Text = "Phân quyền";
            this.btnPhanquyen.UseVisualStyleBackColor = true;
            this.btnPhanquyen.Click += new System.EventHandler(this.btnPhanquyen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtmkmoi2);
            this.groupBox1.Controls.Add(this.lb3);
            this.groupBox1.Controls.Add(this.txtmkmoi);
            this.groupBox1.Controls.Add(this.lb2);
            this.groupBox1.Controls.Add(this.txtmkcu);
            this.groupBox1.Controls.Add(this.lb1);
            this.groupBox1.Controls.Add(this.cmbChucvu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTentk);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 216);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tài khoản";
            // 
            // txtmkmoi2
            // 
            this.txtmkmoi2.Location = new System.Drawing.Point(108, 184);
            this.txtmkmoi2.Name = "txtmkmoi2";
            this.txtmkmoi2.Size = new System.Drawing.Size(118, 20);
            this.txtmkmoi2.TabIndex = 35;
            this.txtmkmoi2.UseSystemPasswordChar = true;
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(10, 187);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(96, 13);
            this.lb3.TabIndex = 34;
            this.lb3.Text = "Nhập lại mật khẩu:";
            // 
            // txtmkmoi
            // 
            this.txtmkmoi.Location = new System.Drawing.Point(108, 153);
            this.txtmkmoi.Name = "txtmkmoi";
            this.txtmkmoi.Size = new System.Drawing.Size(118, 20);
            this.txtmkmoi.TabIndex = 33;
            this.txtmkmoi.UseSystemPasswordChar = true;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(10, 156);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(74, 13);
            this.lb2.TabIndex = 32;
            this.lb2.Text = "Mật khẩu mới:";
            // 
            // txtmkcu
            // 
            this.txtmkcu.Location = new System.Drawing.Point(108, 120);
            this.txtmkcu.Name = "txtmkcu";
            this.txtmkcu.Size = new System.Drawing.Size(118, 20);
            this.txtmkcu.TabIndex = 31;
            this.txtmkcu.UseSystemPasswordChar = true;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(10, 123);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(70, 13);
            this.lb1.TabIndex = 30;
            this.lb1.Text = "Mật khẩu cũ:";
            // 
            // cmbChucvu
            // 
            this.cmbChucvu.FormattingEnabled = true;
            this.cmbChucvu.Items.AddRange(new object[] {
            "Thu ngân",
            "Admin"});
            this.cmbChucvu.Location = new System.Drawing.Point(108, 86);
            this.cmbChucvu.Name = "cmbChucvu";
            this.cmbChucvu.Size = new System.Drawing.Size(118, 21);
            this.cmbChucvu.TabIndex = 29;
            this.cmbChucvu.SelectedIndexChanged += new System.EventHandler(this.cmbChucvu_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBr);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtsdt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.txtDiachi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTen);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(305, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 173);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin người dùng";
            // 
            // btnBr
            // 
            this.btnBr.Location = new System.Drawing.Point(264, 134);
            this.btnBr.Name = "btnBr";
            this.btnBr.Size = new System.Drawing.Size(75, 23);
            this.btnBr.TabIndex = 29;
            this.btnBr.Text = "Browse...";
            this.btnBr.UseVisualStyleBackColor = true;
            this.btnBr.Click += new System.EventHandler(this.btnBr_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listView1);
            this.groupBox3.Location = new System.Drawing.Point(13, 246);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(664, 188);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách người dùng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(269, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Tìm kiếm:";
            // 
            // frmQLtaikhoannguoidung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(687, 478);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPhanquyen);
            this.Controls.Add(this.btnDoimk);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cmbTim);
            this.Controls.Add(this.btnTimkiem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQLtaikhoannguoidung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tài khoản người dùng";
            this.Load += new System.EventHandler(this.frmQLtaikhoannguoidung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.ComboBox cmbTim;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtTentk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDoimk;
        private System.Windows.Forms.Button btnPhanquyen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbChucvu;
        private System.Windows.Forms.Button btnBr;
        private System.Windows.Forms.TextBox txtmkmoi;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.TextBox txtmkcu;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox txtmkmoi2;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label label8;
    }
}