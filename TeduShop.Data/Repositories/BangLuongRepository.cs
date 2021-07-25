using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastrusture;
using TeduShop.Model.Model;

namespace TeduShop.Data.Repositories
{

    public interface IBangLuongRepository
    {

    }
    public  class BangLuongRepository : RepositoryBase<BANGLUONGCT>, IBangLuongRepository
    {
        public BangLuongRepository(IDbfactory dbfactory) : base(dbfactory)
        {

        }
    }
}
