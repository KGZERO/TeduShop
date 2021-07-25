using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastrusture;
using TeduShop.Model.Model;

namespace TeduShop.Data.Repositories
{

   public interface IPhongbangReponsitory
    {

    }
    public class PhongbangRepository : RepositoryBase<PHONGBAN>, IPhongbangReponsitory
    {
        public PhongbangRepository(IDbfactory dbfactory) : base(dbfactory)
        {

        }
    }
}
