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
    public class ProductRepositoryHS : RepositoryBase<HOSOXINVIEC>, IProductRepository
    {
        public ProductRepositoryHS(IDbfactory dbfactory) : base(dbfactory)
        {
             
        }
    }
}
