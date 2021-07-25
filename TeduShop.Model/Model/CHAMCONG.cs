using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Model
{
    [Table("ChamCong")]
    public class CHAMCONG : CHAMCONG1
    {
        [Key]
        public string MaCC { set; get; }
        [Required]
        public DateTime NgayChamCong { set; get; }
        [Required]
        public int SoNgayCong { set; get; }
        [Required]
        public int SoNgayNghi { set; get; }
        [Required]
        public int SoGioLamThem { set; get; }
       [Required]
        public string MaLuong { set; get; }
        [ForeignKey("MaLuong")]
        public virtual BANGLUONGCT BANGLUONGCT { set; get; }
        [MaxLength(500)]
       public string GhiChu { set; get; }

        public virtual IEnumerable<NHANVIEN> NHANVIEN { set; get; }
        
    }
}