using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Model
{
    [Table("BOPHAN")]
    public class BOPHAN
    {
        [Key]
        public string MaBoPhan { get; set; }

        [Required]
        public string TenBoPhan { get; set; }

        [Required]
        public DateTime NgayThanhLap { get; set; }
        [MaxLength(500)]
        public string GhiChu { get; set; }
        public virtual IEnumerable<PHONGBAN> PHONGBAN { set; get; }
        public virtual IEnumerable<NHANVIEN> NHANVIEN { set; get; }
    }
}