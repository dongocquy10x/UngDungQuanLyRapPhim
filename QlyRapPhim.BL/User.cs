using System;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks.Dataflow;

namespace QlyRapPhim.BL
{
    public class User
    {
        public int UserId { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string Email { get; set; }

        public static Tuple<bool, string> KiemTraInput(User user)
        {
            var success = true;
            var mess = "Dang ky thanh vien thanh cong";

            if (string.IsNullOrWhiteSpace(user.TenDangNhap)) 
                return Tuple.Create(false, "Ten dang nhap khong duoc de trong");
            if (user.TenDangNhap.Length <= 6) 
                return Tuple.Create(false, "Ten dang nhap phai tu 6 ki tu tro len");
            if (!user.TenDangNhap.All(Char.IsLetterOrDigit)) 
                return Tuple.Create(false, "Ten dang nhap chi duoc su dung chu va so");
            if (char.IsDigit(user.TenDangNhap[0])) 
                return Tuple.Create(false, "Ten dang nhap khong duoc bat dau bang ki tu so");

            if (string.IsNullOrWhiteSpace(user.MatKhau))
                return Tuple.Create(false, "Mat khong duoc de trong");
            if (user.MatKhau.Length < 8) {mess = "Mat khau phai nhieu hon 8 ki tu"; success = false; }

            return Tuple.Create(success, mess);
        }
    }
}