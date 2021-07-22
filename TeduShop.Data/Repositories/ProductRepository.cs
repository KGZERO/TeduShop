using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastrusture;
using TeduShop.Model.Model;

namespace TeduShop.Data.Repositories
{
    public interface IProductRepository
    {

    }
    public class ProductRepository : RepositoryBase<NHANVIEN>, IProductRepository
    {
        public ProductRepository(IDbfactory dbfactory) : base(dbfactory)
        {
             
        }
    }
}
