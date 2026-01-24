using QuanLyBanHang.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyBanHang.Forms
{
    public partial class frmHangSanXuat : Form
    {
        QLBHDbContext context = new QLBHDbContext();
        bool xulyThem = false;
        int id;
        public frmHangSanXuat()
        {
            InitializeComponent();
        }
        public void BatTatChucNang(bool giatri)
        {
            btnLuu.Enabled = giatri;
            btnHuyBo.Enabled = giatri;
            txtTenHangSanXuat.Enabled = giatri;

            btnThem.Enabled = !giatri;
            btnSua.Enabled = !giatri;
            btnXoa.Enabled = !giatri;
        }
        private void frmHangSanXuat_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            List<HangSanXuat> hangsx = new List<HangSanXuat>();
            hangsx = context.HangSanXuat.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = hangsx;

            txtTenHangSanXuat.DataBindings.Clear();
            txtTenHangSanXuat.DataBindings.Add(
                "Text",
                bindingSource,
                "TenHangSanXuat",
                false,
                DataSourceUpdateMode.Never
            );

            dataGridView.DataSource = hangsx;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulyThem = true;
            BatTatChucNang(true);
            txtTenHangSanXuat.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xulyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenHangSanXuat.Text))
            {
                MessageBox.Show("Vui lòng nhập tên hãng sản xuất?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (xulyThem)
                {
                    HangSanXuat hangsx = new HangSanXuat();
                    hangsx.TenHangSanXuat = txtTenHangSanXuat.Text;
                    context.HangSanXuat.Add(hangsx);

                    context.SaveChanges();
                }
                else
                {
                    HangSanXuat hangsx = context.HangSanXuat.Find(id);
                    if (hangsx != null)
                    {
                        hangsx.TenHangSanXuat = txtTenHangSanXuat.Text;
                        context.HangSanXuat.Update(hangsx);

                        context.SaveChanges();
                    }
                }
                frmHangSanXuat_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult trloi = MessageBox.Show("Xác nhận xoá hãng sản xuất", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (trloi == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                HangSanXuat hangsx = context.HangSanXuat.Find(id);
                if (hangsx != null)
                {
                    context.HangSanXuat.Remove(hangsx);
                }
                frmHangSanXuat_Load(sender, e);
            }

        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmHangSanXuat_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult trloi = MessageBox.Show("Xác nhận thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (trloi == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
