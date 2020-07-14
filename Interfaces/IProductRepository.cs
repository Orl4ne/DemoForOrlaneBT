using Microsoft.EntityFrameworkCore;

namespace Interfaces
{
    public interface IProductRepository<TProduct> : IDbContext
        where TProduct : class
    {
        DbSet<TProduct> Products { get; }
    }
}
