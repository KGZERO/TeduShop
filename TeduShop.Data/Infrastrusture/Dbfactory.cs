using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Data.Infrastrusture
{
    public class Dbfactory : Disposable, IDbfactory
    {
        private TeduShopDbContext dbContext;
        public TeduShopDbContext Init()
        {
            return dbContext ?? (dbContext = new TeduShopDbContext());

        }
        protected override void DisposeCore()
        {
            if (dbContext != null) dbContext.Dispose();
        }
    }
}
