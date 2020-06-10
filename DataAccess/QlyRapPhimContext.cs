using QlyRapPhim.BL;
using System;
using System.Data.Entity;

namespace DataAccess
{
    public class QlyRapPhimContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Stored Procedure Mapping
            modelBuilder.Entity<User>().MapToStoredProcedures();
            modelBuilder.Entity<Phim>().MapToStoredProcedures();

            modelBuilder.Configurations.Add(new UserConfig());
            modelBuilder.Configurations.Add(new NguoiConfig());
            modelBuilder.Configurations.Add(new NhanVienConfig());
        }

        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<Phim> Phims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<DonHang> DonHangs { get; set; }
        public DbSet<Ghe> Ghes { get; set; }
        public DbSet<ChuongTrinhGiamGia> Coupons { get; set; }
        public DbSet<TheLoai> TheLoai { get; set; }
    }
}
