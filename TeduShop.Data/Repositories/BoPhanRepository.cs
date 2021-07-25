using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastrusture;
using TeduShop.Model.Model;

namespace TeduShop.Data.Repositories
{
    
    public interface IBoPhanRepository
    {

    }
    public class BoPhanRepository : RepositoryBase<PHONGBAN>, IBoPhanRepository
    {
        public BoPhanRepository(IDbfactory dbfactory) : base(dbfactory)
        {

        }
    }
}
