using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Model
{
    [Table("BANGLUONGCT")]
   public class BANGLUONGCT
    {
        [Key]
        public string MaLuong { get; set; }
        [Required]
        public int LuongCB { get; set; }
        [Required]
        public string ChucVu { get; set; }
        [Required]
        public DateTime NgayNhap { get; set; }
       
        public int? LuongThuong { get; set; }
        [Required]
        public DateTime NgaySua { get; set; }
        [MaxLength(200)]
        public string LyDo { get; set; }
        [MaxLength(500)]
        public string GhiChu { get; set; }

        public virtual IEnumerable<CHAMCONG> CHAMCONG { set; get; }//ForeignKey
        public virtual IEnumerable<NHANVIEN> NHANVIEN { set; get; }
    }
}
