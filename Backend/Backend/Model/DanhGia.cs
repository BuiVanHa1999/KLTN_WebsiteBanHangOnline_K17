using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Model
{
    public class DanhGia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaDanhGia { get; set; }
        public double MotSao { get; set; }
        public double HaiSao { get; set; }
        public double BaSao { get; set; }
        public double BonSao { get; set; }
        public double NamSao { get; set; }
    }
}
