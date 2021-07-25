using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastrusture;
using TeduShop.Model.Model;

namespace TeduShop.Data.Repositories
{
    public interface IChamCongRepository
    {

    }
    public class ChamCongRepository : RepositoryBase<CHAMCONG>, IChamCongRepository
    {
        public ChamCongRepository(IDbfactory dbfactory) : base(dbfactory)
        {

        }
    }
}
