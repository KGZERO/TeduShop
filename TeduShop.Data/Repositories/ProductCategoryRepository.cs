using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; 
using TeduShop.Data.Infrastrusture;
using TeduShop.Model.Model;


namespace TeduShop.Data.Repositories
{
    public interface IProductCategoryRepository
    {
        IEnumerable<NHANVIEN> GetByAlias(string alias);
    }
    public class ProductCategoryRepository : RepositoryBase<NHANVIEN>,IProductCategoryRepository
    {
        public ProductCategoryRepository(IDbfactory dbfactory) : base(dbfactory)
        {

        }

        public IEnumerable<NHANVIEN> GetByAlias(string HoTenNV)
        {
            return this.DbContext.NHANVIEN.Where(x => x.HoTenNV == HoTenNV);
        }
    }
}
