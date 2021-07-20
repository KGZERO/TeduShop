using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Model
{
    [Table("HOSOXINVIEC")]
  public  class HOSOXINVIEC
    {
        [Key]
       public string MaHoSoNV { set; get; }
        [Required]
        public string MaNV { set; get; }
        [ForeignKey("MaNV")]
        public virtual NHANVIEN NHANVIEN { set; get; }
        [Required]
        public string MaPhong { set; get; }
        [ForeignKey("MaPhong")]
        public virtual PHONGBAN PHONGBAN { set; get; }
        [Required]
        public string HoTenNV { set; get; }
        [Required]
        public DateTime NgaySinh { set; get; }
        [Required]
        public string GioiTinh { set; get; }
        [Required]
        public string DiaChi { set; get; }
        [Required]
        public string TDHocVan { set; get; }
        [Required]
        public string ViTriThuViec { set; get; }
        [Required]
        public DateTime NgayLamviec { set; get; }
        [MaxLength(500)]
        public string GhiChu { set; get; }
    }
}
