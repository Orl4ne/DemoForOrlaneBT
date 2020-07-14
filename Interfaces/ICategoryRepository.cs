using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Interfaces
{
    public interface ICategoryRepository<TCategory> : IDbContext
        where TCategory : class
    {
        DbSet<TCategory> Categories { get; }        
    }
}
