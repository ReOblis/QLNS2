﻿using System;
using System.ComponentModel.DataAnnotations;

namespace QLNS.Models
{
    public class HopDongLaoDong
    {
        [Key]
        public string MaHDLD { get; set; }
        public string MaNV { get; set; }
        public string LoaiHDLD { get; set; }
        public double ThoiHan { get; set; }
        public string DiaDiemLamViec { get; set; }  
        public string MaLuong { get; set; }
        public double PhuCap { get; set; }  
        public string ChucVu { get; set; }
    }
}
