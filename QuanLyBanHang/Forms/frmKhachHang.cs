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
    public partial class frmKhachHang : Form
    {
        QLBHDbContext context = new QLBHDbContext();
        int id;
        bool xulyThem = false;
        public frmKhachHang()
        {
            InitializeComponent();
        }
        public void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;
            txtHoVaTen.Enabled = giaTri;
            txtDienThoai.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }


        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            List<KhachHang> kh = new List<KhachHang>();
            kh = context.KhachHang.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = kh;

            txtHoVaTen.DataBindings.Clear();
            txtHoVaTen.DataBindings.Add(
                "Text",
                bindingSource,
                "HoVaTen",
                false,
                DataSourceUpdateMode.Never);

            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add(
                "Text",
                bindingSource,
                "DienThoai",
                false,
                DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add(
                "Text",
                bindingSource,
                "DiaChi",
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
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xulyThem = true;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoVaTen.Text))
                MessageBox.Show("Vui lòng nhập họ và tên khách hàng?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xulyThem)
                {
                    KhachHang kh = new KhachHang();
                    kh.HoVaTen = txtHoVaTen.Text;
                    kh.DienThoai = txtDienThoai.Text;
                    kh.DiaChi = txtDiaChi.Text;
                    context.KhachHang.Add(kh);

                    context.SaveChanges();
                }
                else
                {
                    KhachHang kh = context.KhachHang.Find(id);
                    if (kh != null)
                    {
                        kh.HoVaTen = txtHoVaTen.Text;
                        kh.DienThoai = txtDienThoai.Text;
                        kh.DiaChi = txtDiaChi.Text;

                        context.KhachHang.Update(kh);

                        context.SaveChanges();
                    }
                }
                frmKhachHang_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult trloi = MessageBox.Show("Xác nhận xoá khách hàng " + txtHoVaTen.Text + "?", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (trloi == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                KhachHang kh = context.KhachHang.Find(id);
                if (kh != null)
                {
                    context.KhachHang.Remove(kh);
                }
                context.SaveChanges();

                frmKhachHang_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmKhachHang_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult trloi = MessageBox.Show("Xác nhận thoát khỏi Form Khách Hàng" , "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (trloi == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
