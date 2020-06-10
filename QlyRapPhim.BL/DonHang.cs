using System;
using System.Collections.Generic;
using System.Text;

namespace QlyRapPhim.BL
{
    public class DonHang
    {
        public DonHang()
        {

        }

        public DonHang(int donHangId)
        {
            DonHangId = donHangId;
        }
        public int DonHangId { get; set; }
        public DateTime NgayMua { get; set; }
        public int SoTienThanhToan { get; set; }
        public Phim Phim { get; set; }
        public List<Ghe> Ghe { get; set; }
        public PhongChieu PhongChieu { get; set; }
    }
}
