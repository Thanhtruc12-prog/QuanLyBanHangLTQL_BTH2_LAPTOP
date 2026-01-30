namespace QuanLyBanHang.Forms
{
    partial class frmNhanVien
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
            btnTimKiem = new Button();
            btnXuat = new Button();
            btnXoa = new Button();
            btnNhap = new Button();
            txtDienThoai = new TextBox();
            lblDienthoai = new Label();
            txtDiaChi = new TextBox();
            lblDiaChi = new Label();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            HoVaTen = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            TenDangNhap = new DataGridViewTextBoxColumn();
            QuyenHan = new DataGridViewTextBoxColumn();
            grbDsHSX = new GroupBox();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            txtHoVaTen = new TextBox();
            lblTenKH = new Label();
            grbKH = new GroupBox();
            cboQuyenHan = new ComboBox();
            txtMatKhau = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtTenDangNhap = new TextBox();
            label3 = new Label();
            btnSua = new Button();
            btnThem = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            grbDsHSX.SuspendLayout();
            grbKH.SuspendLayout();
            SuspendLayout();
            // 
            // btnTimKiem
            // 
            btnTimKiem.FlatStyle = FlatStyle.Popup;
            btnTimKiem.ForeColor = Color.Black;
            btnTimKiem.Location = new Point(1000, 35);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(101, 30);
            btnTimKiem.TabIndex = 13;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnXuat
            // 
            btnXuat.FlatStyle = FlatStyle.Popup;
            btnXuat.ForeColor = Color.Black;
            btnXuat.Location = new Point(1000, 121);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(101, 30);
            btnXuat.TabIndex = 12;
            btnXuat.Text = "Xuất...";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.FlatStyle = FlatStyle.Popup;
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(750, 121);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(101, 30);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnNhap
            // 
            btnNhap.FlatStyle = FlatStyle.Popup;
            btnNhap.ForeColor = Color.Black;
            btnNhap.Location = new Point(1000, 77);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(101, 30);
            btnNhap.TabIndex = 11;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(139, 79);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(226, 30);
            txtDienThoai.TabIndex = 10;
            // 
            // lblDienthoai
            // 
            lblDienthoai.AutoSize = true;
            lblDienthoai.Location = new Point(11, 82);
            lblDienthoai.Margin = new Padding(4, 0, 4, 0);
            lblDienthoai.Name = "lblDienthoai";
            lblDienthoai.Size = new Size(98, 22);
            lblDienthoai.TabIndex = 9;
            lblDienthoai.Text = "Điện thoại:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(139, 124);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(226, 30);
            txtDiaChi.TabIndex = 8;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Location = new Point(11, 132);
            lblDiaChi.Margin = new Padding(4, 0, 4, 0);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(79, 22);
            lblDiaChi.TabIndex = 7;
            lblDiaChi.Text = "Địa chỉ: ";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToOrderColumns = true;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, HoVaTen, DienThoai, DiaChi, TenDangNhap, QuyenHan });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(4, 26);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(1108, 395);
            dataGridView.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.FillWeight = 50F;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // HoVaTen
            // 
            HoVaTen.DataPropertyName = "HoVaTen";
            HoVaTen.FillWeight = 170F;
            HoVaTen.HeaderText = "Họ và tên";
            HoVaTen.MinimumWidth = 6;
            HoVaTen.Name = "HoVaTen";
            // 
            // DienThoai
            // 
            DienThoai.DataPropertyName = "DienThoai";
            DienThoai.FillWeight = 170F;
            DienThoai.HeaderText = "Điện thoại";
            DienThoai.MinimumWidth = 6;
            DienThoai.Name = "DienThoai";
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.FillWeight = 170F;
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            // 
            // TenDangNhap
            // 
            TenDangNhap.DataPropertyName = "TenDangNhap";
            TenDangNhap.FillWeight = 170F;
            TenDangNhap.HeaderText = "Tên đang nhập";
            TenDangNhap.MinimumWidth = 6;
            TenDangNhap.Name = "TenDangNhap";
            // 
            // QuyenHan
            // 
            QuyenHan.DataPropertyName = "QuyenHan";
            QuyenHan.FillWeight = 170F;
            QuyenHan.HeaderText = "Quyền hạn";
            QuyenHan.MinimumWidth = 6;
            QuyenHan.Name = "QuyenHan";
            // 
            // grbDsHSX
            // 
            grbDsHSX.Controls.Add(dataGridView);
            grbDsHSX.Location = new Point(9, 195);
            grbDsHSX.Margin = new Padding(4, 3, 4, 3);
            grbDsHSX.Name = "grbDsHSX";
            grbDsHSX.Padding = new Padding(4, 3, 4, 3);
            grbDsHSX.Size = new Size(1116, 424);
            grbDsHSX.TabIndex = 7;
            grbDsHSX.TabStop = false;
            grbDsHSX.Text = "Danh sách nhân viên";
            // 
            // btnThoat
            // 
            btnThoat.FlatStyle = FlatStyle.Popup;
            btnThoat.Location = new Point(865, 121);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(101, 30);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.FlatStyle = FlatStyle.Popup;
            btnHuyBo.Location = new Point(865, 77);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(101, 30);
            btnHuyBo.TabIndex = 6;
            btnHuyBo.Text = "Huỷ Bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.FlatStyle = FlatStyle.Popup;
            btnLuu.ForeColor = Color.Blue;
            btnLuu.Location = new Point(865, 35);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(101, 30);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(139, 30);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(226, 30);
            txtHoVaTen.TabIndex = 1;
            // 
            // lblTenKH
            // 
            lblTenKH.AutoSize = true;
            lblTenKH.Location = new Point(11, 33);
            lblTenKH.Margin = new Padding(4, 0, 4, 0);
            lblTenKH.Name = "lblTenKH";
            lblTenKH.Size = new Size(120, 22);
            lblTenKH.TabIndex = 0;
            lblTenKH.Text = "Họ và tên (*):";
            // 
            // grbKH
            // 
            grbKH.Controls.Add(cboQuyenHan);
            grbKH.Controls.Add(txtMatKhau);
            grbKH.Controls.Add(label1);
            grbKH.Controls.Add(label2);
            grbKH.Controls.Add(txtTenDangNhap);
            grbKH.Controls.Add(label3);
            grbKH.Controls.Add(btnTimKiem);
            grbKH.Controls.Add(btnXuat);
            grbKH.Controls.Add(btnXoa);
            grbKH.Controls.Add(btnNhap);
            grbKH.Controls.Add(txtDienThoai);
            grbKH.Controls.Add(lblDienthoai);
            grbKH.Controls.Add(txtDiaChi);
            grbKH.Controls.Add(lblDiaChi);
            grbKH.Controls.Add(btnThoat);
            grbKH.Controls.Add(btnHuyBo);
            grbKH.Controls.Add(btnLuu);
            grbKH.Controls.Add(btnSua);
            grbKH.Controls.Add(btnThem);
            grbKH.Controls.Add(txtHoVaTen);
            grbKH.Controls.Add(lblTenKH);
            grbKH.Location = new Point(17, 10);
            grbKH.Margin = new Padding(4, 3, 4, 3);
            grbKH.Name = "grbKH";
            grbKH.Padding = new Padding(4, 3, 4, 3);
            grbKH.Size = new Size(1108, 171);
            grbKH.TabIndex = 6;
            grbKH.TabStop = false;
            grbKH.Text = "Thông tin nhân viên";
            // 
            // cboQuyenHan
            // 
            cboQuyenHan.FormattingEnabled = true;
            cboQuyenHan.Items.AddRange(new object[] { "Quản lý", "Nhân viên" });
            cboQuyenHan.Location = new Point(553, 124);
            cboQuyenHan.Name = "cboQuyenHan";
            cboQuyenHan.Size = new Size(165, 30);
            cboQuyenHan.TabIndex = 20;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(553, 79);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(165, 30);
            txtMatKhau.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(388, 82);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 22);
            label1.TabIndex = 18;
            label1.Text = "Mật khẩu (*):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(388, 132);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(126, 22);
            label2.TabIndex = 16;
            label2.Text = "Quyền hạn (*):";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(553, 33);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(165, 30);
            txtTenDangNhap.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(388, 37);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(158, 22);
            label3.TabIndex = 14;
            label3.Text = "Tên đăng nhập (*):";
            // 
            // btnSua
            // 
            btnSua.FlatStyle = FlatStyle.Popup;
            btnSua.Location = new Point(750, 77);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(101, 30);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.FlatStyle = FlatStyle.Popup;
            btnThem.Location = new Point(750, 35);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(101, 30);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 628);
            Controls.Add(grbDsHSX);
            Controls.Add(grbKH);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhân viên";
            Load += frmNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            grbDsHSX.ResumeLayout(false);
            grbKH.ResumeLayout(false);
            grbKH.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnTimKiem;
        private Button btnXuat;
        private Button btnXoa;
        private Button btnNhap;
        private TextBox txtDienThoai;
        private Label lblDienthoai;
        private TextBox txtDiaChi;
        private Label lblDiaChi;
        private DataGridView dataGridView;
        private GroupBox grbDsHSX;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private TextBox txtHoVaTen;
        private Label lblTenKH;
        private GroupBox grbKH;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtMatKhau;
        private Label label1;
        private Label label2;
        private TextBox txtTenDangNhap;
        private Label label3;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn TenDangNhap;
        private DataGridViewTextBoxColumn QuyenHan;
        private ComboBox cboQuyenHan;
    }
}