using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace MDM_API.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<TaiKhoan> TaiKhoan { get; set; }
        public DbSet<ChuyenXe> ChuyenXe { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }

        public AppDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Futabus;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaiKhoan>()
                .HasData(
                new TaiKhoan
                {
                    HoTen = "",
                    GioiTinh = 1,
                    NgaySinh = "1/1/2024",
                    DiaChi = "HCM",
                    NgheNghiep = "",
                    SDT = "123456789",
                    Email = "admin@gmail.com",
                    MatKhau = "123"
                }
            );

            modelBuilder.Entity<ChuyenXe>()
                .HasData(
                new ChuyenXe
                {
                    MaChuyenXe = 1,
                    TenChuyenXe = "Chuyen Xe 1"
                },
                new ChuyenXe
                {
                    MaChuyenXe = 2,
                    TenChuyenXe = "Chuyen Xe 2"
                },
                new ChuyenXe
                {
                    MaChuyenXe = 3,
                    TenChuyenXe = "Chuyen Xe 3"
                },
                new ChuyenXe
                {
                    MaChuyenXe = 4,
                    TenChuyenXe = "Chuyen Xe 4"
                },
                new ChuyenXe
                {
                    MaChuyenXe = 5,
                    TenChuyenXe = "Chuyen Xe 5"
                }
            );
        }
    }
}
