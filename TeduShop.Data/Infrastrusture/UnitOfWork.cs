using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Data.Infrastrusture
{
    public class UnitOfWork : IUnitofwork
    {
        private readonly IDbfactory dbfactory;
        private TeduShopDbContext dbContext;
        public  UnitOfWork(IDbfactory dbfactory)
        {
            this.dbfactory = dbfactory;
        }
        public TeduShopDbContext DbContext
        {
            get { return dbContext ?? (dbContext = dbfactory.Init()); }
        }
        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}
