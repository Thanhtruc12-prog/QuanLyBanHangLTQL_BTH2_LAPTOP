namespace QuanLyBanHang.Forms
{
    partial class frmHangSanXuat
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
            grbHSX = new GroupBox();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtTenHangSanXuat = new TextBox();
            lblTenHSX = new Label();
            grbDsHSX = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenHangSanXuat = new DataGridViewTextBoxColumn();
            grbHSX.SuspendLayout();
            grbDsHSX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // grbHSX
            // 
            grbHSX.Controls.Add(btnThoat);
            grbHSX.Controls.Add(btnHuyBo);
            grbHSX.Controls.Add(btnLuu);
            grbHSX.Controls.Add(btnXoa);
            grbHSX.Controls.Add(btnSua);
            grbHSX.Controls.Add(btnThem);
            grbHSX.Controls.Add(txtTenHangSanXuat);
            grbHSX.Controls.Add(lblTenHSX);
            grbHSX.Location = new Point(13, 12);
            grbHSX.Margin = new Padding(4, 3, 4, 3);
            grbHSX.Name = "grbHSX";
            grbHSX.Padding = new Padding(4, 3, 4, 3);
            grbHSX.Size = new Size(937, 138);
            grbHSX.TabIndex = 2;
            grbHSX.TabStop = false;
            grbHSX.Text = "Thông tin hãng sản xuất";
            // 
            // btnThoat
            // 
            btnThoat.FlatStyle = FlatStyle.Popup;
            btnThoat.Location = new Point(814, 91);
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
            btnHuyBo.Location = new Point(693, 91);
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
            btnLuu.Location = new Point(571, 91);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(101, 30);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.FlatStyle = FlatStyle.Popup;
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(449, 91);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(101, 30);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.FlatStyle = FlatStyle.Popup;
            btnSua.Location = new Point(332, 91);
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
            btnThem.Location = new Point(214, 91);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(101, 30);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtTenHangSanXuat
            // 
            txtTenHangSanXuat.Location = new Point(214, 44);
            txtTenHangSanXuat.Name = "txtTenHangSanXuat";
            txtTenHangSanXuat.Size = new Size(701, 30);
            txtTenHangSanXuat.TabIndex = 1;
            // 
            // lblTenHSX
            // 
            lblTenHSX.AutoSize = true;
            lblTenHSX.Location = new Point(20, 47);
            lblTenHSX.Margin = new Padding(4, 0, 4, 0);
            lblTenHSX.Name = "lblTenHSX";
            lblTenHSX.Size = new Size(178, 22);
            lblTenHSX.TabIndex = 0;
            lblTenHSX.Text = "Tên hãng sản xuất(*):";
            // 
            // grbDsHSX
            // 
            grbDsHSX.Controls.Add(dataGridView);
            grbDsHSX.Location = new Point(13, 173);
            grbDsHSX.Margin = new Padding(4, 3, 4, 3);
            grbDsHSX.Name = "grbDsHSX";
            grbDsHSX.Padding = new Padding(4, 3, 4, 3);
            grbDsHSX.Size = new Size(940, 407);
            grbDsHSX.TabIndex = 3;
            grbDsHSX.TabStop = false;
            grbDsHSX.Text = "Danh sách hãng sản xuất";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToOrderColumns = true;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, TenHangSanXuat });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(4, 26);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(932, 378);
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
            // TenHangSanXuat
            // 
            TenHangSanXuat.DataPropertyName = "TenHangSanXuat";
            TenHangSanXuat.FillWeight = 284.163116F;
            TenHangSanXuat.HeaderText = "Tên hãng sản xuất";
            TenHangSanXuat.MinimumWidth = 6;
            TenHangSanXuat.Name = "TenHangSanXuat";
            // 
            // frmHangSanXuat
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 585);
            Controls.Add(grbDsHSX);
            Controls.Add(grbHSX);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmHangSanXuat";
            Text = "frmHangSanXuat";
            Load += frmHangSanXuat_Load;
            grbHSX.ResumeLayout(false);
            grbHSX.PerformLayout();
            grbDsHSX.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbHSX;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtTenHangSanXuat;
        private Label lblTenHSX;
        private GroupBox grbDsHSX;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenHangSanXuat;
    }
}