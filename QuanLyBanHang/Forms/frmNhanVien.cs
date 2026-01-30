using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLyBanHang.Data;

namespace QuanLyBanHang.Forms
{
    public partial class frmNhanVien : Form
    {
        QLBHDbContext context = new QLBHDbContext();
        int id;
        bool xulyThem = false;
        public frmNhanVien()
        {
            InitializeComponent();
        }
        public void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtHoVaTen.Enabled = giaTri;
            txtDienThoai.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;
            txtMatKhau.Enabled = giaTri;
            cboQuyenHan.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            dataGridView.AutoGenerateColumns = false;

            List<NhanVien> nv = new List<NhanVien>();
            nv = context.NhanVien.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = nv;

            txtHoVaTen.DataBindings.Clear();
            txtHoVaTen.DataBindings.Add(
                "Text",
                bindingSource,
                "HoVaTen",
                false,
                DataSourceUpdateMode.Never);


            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add(
                "Text",
                bindingSource,
                "DiaChi",
                false,
                DataSourceUpdateMode.Never);


            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add(
                "Text",
                bindingSource,
                "DienThoai",
                false,
                DataSourceUpdateMode.Never);

            txtTenDangNhap.DataBindings.Clear();
            txtTenDangNhap.DataBindings.Add(
                "Text",
                bindingSource,
                "TenDangNhap",
                false,
                DataSourceUpdateMode.Never);

            cboQuyenHan.DataBindings.Clear();
            cboQuyenHan.DataBindings.Add(
                "SelectedIndex",
                bindingSource,
                "QuyenHan",
                false,
                DataSourceUpdateMode.Never);

            dataGridView.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulyThem = true;
            BatTatChucNang(true);
            txtHoVaTen.Clear();
            txtDienThoai.Clear();
            txtDiaChi.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            cboQuyenHan.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xulyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoVaTen.Text))
                MessageBox.Show("Vui lòng nhập họ và tên nhân viên?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
                MessageBox.Show("Vui lòng nhập tên đăng nhập?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cboQuyenHan.Text))
                MessageBox.Show("Vui lòng chọn quyền hạn cho nhân viên?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xulyThem)
                {
                    if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
                        MessageBox.Show("Vui nhập mật khẩu?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        NhanVien nv = new NhanVien();
                        nv.HoVaTen = txtHoVaTen.Text;
                        nv.DienThoai = txtDienThoai.Text;
                        nv.DiaChi = txtDiaChi.Text;
                        nv.TenDangNhap = txtTenDangNhap.Text;
                        nv.MatKhau = txtMatKhau.Text;
                        nv.QuyenHan = cboQuyenHan.SelectedIndex == 0 ? true : false;
                        context.NhanVien.Add(nv);

                        context.SaveChanges();
                    }
                }
                else
                {
                    NhanVien nv = context.NhanVien.Find(id);
                    if (nv != null)
                    {
                        nv.HoVaTen = txtHoVaTen.Text;
                        nv.DienThoai = txtDienThoai.Text;
                        nv.DiaChi = txtDiaChi.Text;
                        nv.TenDangNhap = txtTenDangNhap.Text;
                        nv.MatKhau = txtMatKhau.Text;
                        nv.QuyenHan = cboQuyenHan.SelectedIndex == 0 ? true : false;
                        context.NhanVien.Update(nv);

                        if (string.IsNullOrEmpty(txtMatKhau.Text))
                            context.Entry(nv).Property(x => x.MatKhau).IsModified = false; //Giữ nguyên mật khẩu cũ
                        else
                            nv.MatKhau = BCrypt.Net.BCrypt.HashPassword(txtMatKhau.Text);

                        context.SaveChanges();
                    }
                }
                frmNhanVien_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult trloi = MessageBox.Show("Xác nhận xoá nhân viên " + txtHoVaTen.Text + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (trloi == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                NhanVien nv = context.NhanVien.Find(id);
                if (nv != null)
                {
                    context.NhanVien.Remove(nv);
                }
                context.SaveChanges();

                frmNhanVien_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult trloi = MessageBox.Show("Xác nhận thoát khỏi Form Nhân Viên ", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (trloi == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
