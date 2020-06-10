using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;
using QlyRapPhim.BL;

namespace DataAccess
{
    public class UserConfig : EntityTypeConfiguration<User>
    {
        public UserConfig()
        {
            Property(u => u.TenDangNhap).HasMaxLength(10);
            Property(u => u.MatKhau).HasMaxLength(50);    
        }
    }

    public class NguoiConfig : EntityTypeConfiguration<Nguoi>
    {
        public NguoiConfig()
        {
            Property(n => n.SoCmnd).IsRequired();
            Property(n => n.Ten).IsRequired();
            Property(n => n.NamSinh).IsRequired();
        }
    }

    public class NhanVienConfig : EntityTypeConfiguration<NhanVien>
    {
        public NhanVienConfig()
        {
            Property(n => n.ChucVu).IsRequired();
            Property(n => n.NgayVaoLam).IsRequired();
        }
    }
}
