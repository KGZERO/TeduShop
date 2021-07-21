using System;

namespace TeduShop.Data.Infrastrusture
{
    public interface IDbfactory : IDisposable
    {
        TeduShopDbContext Init();
    }
}