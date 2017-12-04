﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Team
{
    public class SinhVien
    {
        [Key]
        public int MaSinhVien { get; set; }
        [Required]
        public string MaLop { get; set; }
        [Required]
        public string TenSinhVien { get; set; }
        //[Required]
        //public string QueQuan { get; set; }
        //[Required]
        //public DateTime NgaySinh { get; set; }
        //[Required]
        //public bool GioiTinh { get; set; }
        //public double DiemTrungBinh { get; set; }
        //public int DiemRenLuyen { get; set; }
        //public string Image { get; set; }
        [ForeignKey("MaLop")]
        public virtual Lop lops { get; set; }



        public SinhVien()
        {
            
        }


    }
}
