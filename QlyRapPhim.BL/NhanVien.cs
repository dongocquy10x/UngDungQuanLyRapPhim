using System;
using System.Collections.Generic;
using System.Text;

namespace QlyRapPhim.BL
{
    public class NhanVien : Nguoi
    {
        public NhanVien()
        {
            
        }
        public NhanVien(int soCmnd, string ho, string ten,int namSinh, DateTime ngayVaoLam, string chucVu) : base(soCmnd, ho, ten, namSinh)
        {
            NgayVaoLam = ngayVaoLam;
            ChucVu = chucVu;
        }

        public byte[] Photo { get; set; }
        public DateTime NgayVaoLam { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string ChucVu { get; set; }

        public bool KiemTraInput(NhanVien nv)
        {
            var validate = true;

            if (string.IsNullOrWhiteSpace(nv.Ho) || string.IsNullOrWhiteSpace(nv.Ten)) validate = false;
            if (nv.NamSinh <= 1900) validate = false;
            if (nv.NgayVaoLam <= DateTime.Now) validate = false;

            return validate;
        }
    }
}
