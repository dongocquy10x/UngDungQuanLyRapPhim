using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QlyRapPhim.BL
{
    public class Nguoi
    {
        public Nguoi()
        {

        }
        public Nguoi(int soCmnd, string ho, string ten, int namSinh)
        {
            SoCmnd = soCmnd;
            Ho = ho;
            Ten = ten;
            NamSinh = namSinh;
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SoCmnd { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public string HoTen => $"{Ho} {Ten}".Trim();
        public int NamSinh { get; set; }
    }
}
