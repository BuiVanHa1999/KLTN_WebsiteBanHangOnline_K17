using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Model
{
    public class SanPham_Appliance
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaAppliance { get; set; }
        public int MaCT { get; set; }
        public string Loai { get; set; }
        public string DungTich { get; set; }
        public string CongSuat { get; set; }
        public string TienIch { get; set; }
        public string Dai { get; set; }
        public string Rong { get; set; }
        public string NoiSanXuat { get; set; }
        public int DanhGia { get; set; }
    }
}
