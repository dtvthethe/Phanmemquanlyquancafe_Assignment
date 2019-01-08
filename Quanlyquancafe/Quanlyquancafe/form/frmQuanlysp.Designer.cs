namespace Quanlyquancafe.form
{
    partial class frmQuanlysp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanlysp));
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.cmbtim = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdLoaiDoAn = new System.Windows.Forms.ComboBox();
            this.btnBr = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(61, 399);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 23);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm sản phẩm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã sản phẩm:";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(100, 35);
            this.txtMaSP.MaxLength = 5;
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(127, 20);
            this.txtMaSP.TabIndex = 3;
            this.txtMaSP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaSP_KeyPress);
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(100, 82);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(127, 20);
            this.txtTenSP.TabIndex = 5;
            this.txtTenSP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenSP_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên sản phẩm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Loại đồ ăn:";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(322, 85);
            this.txtGia.MaxLength = 5;
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(127, 20);
            this.txtGia.TabIndex = 11;
            this.txtGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGia_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gía sản phẩm:";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(284, 19);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(111, 20);
            this.txtTim.TabIndex = 13;
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tìm kiếm:";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(176, 399);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 23);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa sản phẩm";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(294, 399);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 23);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa sản phẩm";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.cmbtim);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.txtTim);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(14, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 215);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(492, 19);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 15;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // cmbtim
            // 
            this.cmbtim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtim.FormattingEnabled = true;
            this.cmbtim.Items.AddRange(new object[] {
            "Mã sản phẩm",
            "Tên sản phẩm",
            "Gía",
            "Mã loại"});
            this.cmbtim.Location = new System.Drawing.Point(401, 19);
            this.cmbtim.Name = "cmbtim";
            this.cmbtim.Size = new System.Drawing.Size(87, 21);
            this.cmbtim.TabIndex = 14;
            this.cmbtim.SelectedIndexChanged += new System.EventHandler(this.cmbtim_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(20, 56);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(547, 147);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã sản phẩm";
            this.columnHeader1.Width = 106;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên sản phẩm";
            this.columnHeader2.Width = 179;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Gía(vnđ)";
            this.columnHeader3.Width = 113;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mã loại";
            this.columnHeader4.Width = 135;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = " ";
            this.columnHeader5.Width = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdLoaiDoAn);
            this.groupBox2.Controls.Add(this.btnBr);
            this.groupBox2.Controls.Add(this.txtMaSP);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtTenSP);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtGia);
            this.groupBox2.Location = new System.Drawing.Point(14, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(593, 150);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sản phẩm";
            // 
            // cmdLoaiDoAn
            // 
            this.cmdLoaiDoAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdLoaiDoAn.FormattingEnabled = true;
            this.cmdLoaiDoAn.Location = new System.Drawing.Point(322, 35);
            this.cmdLoaiDoAn.Name = "cmdLoaiDoAn";
            this.cmdLoaiDoAn.Size = new System.Drawing.Size(127, 21);
            this.cmdLoaiDoAn.TabIndex = 23;
            this.cmdLoaiDoAn.SelectedIndexChanged += new System.EventHandler(this.cmdLoaiDoAn_SelectedIndexChanged);
            // 
            // btnBr
            // 
            this.btnBr.Location = new System.Drawing.Point(492, 122);
            this.btnBr.Name = "btnBr";
            this.btnBr.Size = new System.Drawing.Size(75, 23);
            this.btnBr.TabIndex = 22;
            this.btnBr.Text = "Browse...";
            this.btnBr.UseVisualStyleBackColor = true;
            this.btnBr.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::Quanlyquancafe.Properties.Resources.no;
            this.pictureBox1.Image = global::Quanlyquancafe.Properties.Resources.no;
            this.pictureBox1.Location = new System.Drawing.Point(476, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 97);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(483, 399);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(58, 23);
            this.btnDong.TabIndex = 21;
            this.btnDong.Text = "Bỏ qua";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(409, 399);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(58, 23);
            this.btnLuu.TabIndex = 20;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmQuanlysp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(621, 435);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQuanlysp";
            this.Text = "Quản lý sản phẩm";
            this.Load += new System.EventHandler(this.frmQuanlysp_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnBr;
        private System.Windows.Forms.ComboBox cmdLoaiDoAn;
        private System.Windows.Forms.ComboBox cmbtim;
        private System.Windows.Forms.Button btnTim;
    }
}