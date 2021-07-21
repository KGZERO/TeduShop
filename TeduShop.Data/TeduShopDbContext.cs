using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Model.Model;

namespace TeduShop.Data
{
    public  class TeduShopDbContext :DbContext
    {
        public TeduShopDbContext() : base("TeduShopConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;//when loading table father else table child
        }
        public DbSet<BANGLUONGCT> BANGLUONGCT { set; get; }
        public DbSet<BOPHAN> BOPHAN { set; get; }
        public DbSet<CHAMCONG> CHAMCONG { set; get; }
        public DbSet<HOSOXINVIEC> HOSOXINVIEC { set; get; }
        public DbSet<NHANVIEN> NHANVIEN { set; get; }
        public DbSet<PHONGBAN> PHONGBAN { set; get; }
        
        protected override void OnModelCreating(DbModelBuilder builder)
        {

        }
    }
}
