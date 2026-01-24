using Microsoft.EntityFrameworkCore;
using QuanLyBanHang.Data;
using System.Configuration;
public class QLBHDbContext : DbContext
{
    public DbSet<LoaiSanPham> LoaiSanPham { get; set; }
    public DbSet<HangSanXuat> HangSanXuat { get; set; }
    public DbSet<SanPham> SanPham { get; set; }
    public DbSet<NhanVien> NhanVien { get; set; }
    public DbSet<KhachHang> KhachHang { get; set; }
    public DbSet<HoaDon> HoaDon { get; set; }
    public DbSet<HoaDon_ChiTiet> HoaDon_ChiTiet { get; set; }

    // Constructor không tham số
    public QLBHDbContext()
    {
    }

    // Constructor với options (cho Factory)
    public QLBHDbContext(DbContextOptions<QLBHDbContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["QLBHConnection"]?.ConnectionString;

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("Không tìm thấy connection string 'QLBHConnection'");
            }

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}