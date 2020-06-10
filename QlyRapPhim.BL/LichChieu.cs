using System;
using System.Collections.Generic;
using System.Text;

namespace QlyRapPhim.BL
{
    public class LichChieu
    {
        public LichChieu()
        {

        }
        public LichChieu(int lichChieuId)
        {
            LichChieuId = lichChieuId;
        }
        public int LichChieuId { get; set; }
        public Phim phim { get; set; }
        public DateTime ThoiGianBatDauChieu { get; set; }
        public DateTime ThoiGianKetThucChieu { get; set; }
        public PhongChieu PhongChieu { get; set; }
        
        public bool ThemLichChieu(LichChieu lichChieu)
        {
            var success = true;

            if (lichChieu.ThoiGianBatDauChieu.Hour < DateTime.Now.Hour) success = false;

            return success;
        }
    }
}
