using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Model
{
    public class SanPham_DienThoai
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaDT { get; set; }
        public int MaCT { get; set; }
        public string MangHinh { get; set; }
        public string HeDieuHanh { get; set; }
        public string CameraTruoc { get; set; }
        public string CameraSau { get; set; }
        public string Chip { get; set; }
        public string Ram { get; set; }
        public string BoNhoTrong { get; set; }
        public string NoiSanXuat { get; set; }
        public string Sim { get; set; }
        public int DanhGia { get; set; }
    }
}
