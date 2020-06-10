using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;


namespace QlyRapPhim.BL
{
    public class Phim
    {
        public Phim()
        {

        }
        public Phim(int phimId)
        {
            PhimId = phimId;
        }
        // -------------------------------------------------------------------------------------
        public int PhimId { get; set; }
        public string Ten { get; set; }
        public List<string> DaoDien { get; set; }
        public List<string> DienVien { get; set; }
        public TheLoai theloai { get; set; }
        public DateTime NgayKhoiChieu { get; set; }
        public int ThoiLuong { get; set; }
        public string NgonNgu { get; set; }
        public float Rated { get; set; }
        public string ChiTiet { get; set; }
        // --------------------------------------------------------------------------------------
        public static Tuple<bool, string> KiemTraInputHopLe(Phim phim)
        {
            if (string.IsNullOrWhiteSpace(phim.Ten))
                return Tuple.Create(false, "Ten phim khong hop le");
            if (phim.ThoiLuong <= 0)
                return Tuple.Create(false, "Thoi luong phim khong hop le");
            if (phim.NgayKhoiChieu.CompareTo(DateTime.Now) < 0)
                return Tuple.Create(false, "Ngay khoi chieu khong hop le");
            if (phim.Rated < 0 || phim.Rated > 5)
                return Tuple.Create(false, "Rated khong hop le");
            return Tuple.Create(true, "Them phim thanh cong");
        }

        //public bool ThemPhimMoi(Phim phim)
        //{
        //    var success = false;
        //    ThemPhimMoi wdThemPhimMoi = new ThemPhimMoi();
        //    KiemTraInputHopLe(phim);
        //    if (KiemTraPhimCoTonTai(phim))
        //    {
        //        Console.WriteLine("Phim da co san trong database.");
        //    }
        //    else
        //    {

        //    }
        //    return success;
        //}

        private bool KiemTraPhimCoTonTai(Phim phim)
        {
            throw new NotImplementedException();
        }

        private bool LayThongTinPhim()
        {
            return true;
        }
    }
}
