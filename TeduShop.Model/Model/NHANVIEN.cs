using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Model
{
    [Table("NHANVIEN")]
   public  class NHANVIEN
    {
        [Key]
        public string MaNV { set; get; }
        [Required]
        public string MaBoPhan { set; get; }
        [ForeignKey("MaBoPhan")]
        public virtual BOPHAN BOPHAN { set; get; }
        [Required]
        public string MaCC { set; get; }
        [ForeignKey("MaCC")]
        public virtual CHAMCONG CHAMCONG { set; get; }
        [Required]
        public string MaPhong { set; get; }
        [ForeignKey("MaPhong")]
        public virtual PHONGBAN PHONGBAN { set; get; }
        [Required]
        public string MaLuong { set; get; }
        [ForeignKey("MaLuong")]
        public virtual BANGLUONGCT BANGLUONGCT { set; get; }
        [Required]
        public string HoTenNV { set; get; }
        [Required]
        public DateTime NgaySinh { set; get; }
        [Required]
        public string GioiTinh{ set; get; }
        [Required]
        public string TTHonNhan { set; get; }
        public string CMTND { set; get; }
        [Required]
        public string NoiCap { set; get; }
        [Required]
        public string ChucVu { set; get; }
        [Required]
        public string LoaiHD { set; get; }
        [Required]
        public DateTime NgayKy { set; get; }
        [Required]
        public DateTime NgayHetHan { set; get; }
      [MaxLength(500)]
        public string GhiChu { set; get; }
        public virtual IEnumerable<HOSOXINVIEC>HOSOXINVIEC { set; get; }

     
    }
}
