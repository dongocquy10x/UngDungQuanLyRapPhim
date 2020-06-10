using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QlyRapPhim.BL
{
    public class Ghe
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SoGhe { get; set; }
        public char Hang { get; set; }
        public int Cot { get; set; }
        public LoaiGhe LoaiGhe { get; set; }
        public bool IsValid { get; set; }
    }
    public enum LoaiGhe
    {
        GheThuong = 1,
        GheDoi = 2,
        GheVip = 3
    };
}