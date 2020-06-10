using System;
using System.Collections.Generic;
using System.Text;

namespace QlyRapPhim.BL
{
    public class ChuongTrinhGiamGia
    {
        public int Id { get; set; }
        public int TenChuongTrinhGiamGia { get; set; }
        public DateTime ThoiGianBatDau { get; set; }
        public DateTime ThoiGianKetThuc { get; set; }
        
        public ChuongTrinhGiamGia(int couponName, DateTime start, DateTime end)
        {
            TenChuongTrinhGiamGia = couponName;
            ThoiGianBatDau = start;
            ThoiGianKetThuc = end;
        }
        public ChuongTrinhGiamGia()
        {

        }


    }
}
