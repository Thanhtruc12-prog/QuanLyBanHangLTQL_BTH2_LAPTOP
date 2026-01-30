namespace QuanLyBanHang.Forms
{
    partial class frmKhachHang
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
            btnThem = new Button();
            grbKH = new GroupBox();
            btnTimKiem = new Button();
            btnXuat = new Button();
            btnXoa = new Button();
            btnNhap = new Button();
            txtDienThoai = new TextBox();
            lblDienthoai = new Label();
            txtDiaChi = new TextBox();
            lblDiaChi = new Label();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            txtHoVaTen = new TextBox();
            lblTenKH = new Label();
            grbDsHSX = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            HoVaTen = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            grbKH.SuspendLayout();
            grbDsHSX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // btnThem
            // 
            btnThem.FlatStyle = FlatStyle.Popup;
            btnThem.Location = new Point(723, 29);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(101, 30);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // grbKH
            // 
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
            grbKH.Location = new Point(13, 7);
            grbKH.Margin = new Padding(4, 3, 4, 3);
            grbKH.Name = "grbKH";
            grbKH.Padding = new Padding(4, 3, 4, 3);
            grbKH.Size = new Size(1108, 171);
            grbKH.TabIndex = 4;
            grbKH.TabStop = false;
            grbKH.Text = "Thông tin khách hàng";
            // 
            // btnTimKiem
            // 
            btnTimKiem.FlatStyle = FlatStyle.Popup;
            btnTimKiem.ForeColor = Color.Black;
            btnTimKiem.Location = new Point(968, 29);
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
            btnXuat.Location = new Point(968, 115);
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
            btnXoa.Location = new Point(723, 115);
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
            btnNhap.Location = new Point(968, 71);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(101, 30);
            btnNhap.TabIndex = 11;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(511, 51);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(139, 30);
            txtDienThoai.TabIndex = 10;
            // 
            // lblDienthoai
            // 
            lblDienthoai.AutoSize = true;
            lblDienthoai.Location = new Point(408, 54);
            lblDienthoai.Margin = new Padding(4, 0, 4, 0);
            lblDienthoai.Name = "lblDienthoai";
            lblDienthoai.Size = new Size(98, 22);
            lblDienthoai.TabIndex = 9;
            lblDienthoai.Text = "Điện thoại:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(139, 104);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(511, 30);
            txtDiaChi.TabIndex = 8;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Location = new Point(10, 112);
            lblDiaChi.Margin = new Padding(4, 0, 4, 0);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(79, 22);
            lblDiaChi.TabIndex = 7;
            lblDiaChi.Text = "Địa chỉ: ";
            // 
            // btnThoat
            // 
            btnThoat.FlatStyle = FlatStyle.Popup;
            btnThoat.Location = new Point(838, 115);
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
            btnHuyBo.Location = new Point(838, 71);
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
            btnLuu.Location = new Point(838, 29);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(101, 30);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.FlatStyle = FlatStyle.Popup;
            btnSua.Location = new Point(723, 71);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(101, 30);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(139, 51);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(239, 30);
            txtHoVaTen.TabIndex = 1;
            // 
            // lblTenKH
            // 
            lblTenKH.AutoSize = true;
            lblTenKH.Location = new Point(10, 54);
            lblTenKH.Margin = new Padding(4, 0, 4, 0);
            lblTenKH.Name = "lblTenKH";
            lblTenKH.Size = new Size(120, 22);
            lblTenKH.TabIndex = 0;
            lblTenKH.Text = "Họ và tên (*):";
            // 
            // grbDsHSX
            // 
            grbDsHSX.Controls.Add(dataGridView);
            grbDsHSX.Location = new Point(5, 192);
            grbDsHSX.Margin = new Padding(4, 3, 4, 3);
            grbDsHSX.Name = "grbDsHSX";
            grbDsHSX.Padding = new Padding(4, 3, 4, 3);
            grbDsHSX.Size = new Size(1116, 424);
            grbDsHSX.TabIndex = 5;
            grbDsHSX.TabStop = false;
            grbDsHSX.Text = "Danh sách khách hàng";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToOrderColumns = true;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, HoVaTen, DienThoai, DiaChi });
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
            HoVaTen.FillWeight = 284.163116F;
            HoVaTen.HeaderText = "Họ và tên";
            HoVaTen.MinimumWidth = 6;
            HoVaTen.Name = "HoVaTen";
            // 
            // DienThoai
            // 
            DienThoai.DataPropertyName = "DienThoai";
            DienThoai.FillWeight = 180F;
            DienThoai.HeaderText = "Điện thoại";
            DienThoai.MinimumWidth = 6;
            DienThoai.Name = "DienThoai";
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.FillWeight = 180F;
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 628);
            Controls.Add(grbKH);
            Controls.Add(grbDsHSX);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Khách hàng";
            Load += frmKhachHang_Load;
            grbKH.ResumeLayout(false);
            grbKH.PerformLayout();
            grbDsHSX.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnThem;
        private GroupBox grbKH;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private TextBox txtHoVaTen;
        private Label lblTenKH;
        private GroupBox grbDsHSX;
        private DataGridView dataGridView;
        private Label lblDiaChi;
        private TextBox txtDienThoai;
        private Label lblDienthoai;
        private TextBox txtDiaChi;
        private Button btnTimKiem;
        private Button btnXuat;
        private Button btnNhap;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn DiaChi;
    }
}