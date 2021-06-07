using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Model
{
    public class SanPham_Audio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaAudio { get; set; }
        public int MaCT { get; set; }
        public string TuongThich { get; set; }
        public string CongSac { get; set; }
        public string CongNghe { get; set; }
        public double ThoiGianSuDung { get; set; }
        public string TienIch { get; set; }
        public string NoiSanXuat { get; set; }
        public int DanhGia { get; set; }
    }
}
