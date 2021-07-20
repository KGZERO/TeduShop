using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Model
{[Table("PHONGBAN")]
   public  class PHONGBAN
    {
        [Key]
        public string MaPhong { set; get; }
        [Required]
        public string MaBoPhan { set; get; }
        [ForeignKey("MaBoPhan")]
        public virtual BOPHAN BOPHAN { set; get; }
        [Required]
        public string TenPhong { set; get; }
        [Required]
        public DateTime NgayThanhLap { set; get; }
        [MaxLength(500)]
        public string GhiChu { set; get; }
        public virtual IEnumerable<NHANVIEN> NHANVIEN { set; get; }
        public virtual IEnumerable<HOSOXINVIEC> HOSOXINVIEC { set; get; }
    }
}
