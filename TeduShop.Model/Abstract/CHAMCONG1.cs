using System.ComponentModel.DataAnnotations;

namespace TeduShop.Model.Abstract
{
    public abstract class CHAMCONG1 : ICHAMCONG1
    {
        [Required]
        public string HoTenNV { get; set; }

        [MaxLength(256)]
        public string TenBoPhan { get; set; }

        [MaxLength(256)]
        public string TenPhong { get; set; }

        public int? LuongTViec { get; set; }
    }
}