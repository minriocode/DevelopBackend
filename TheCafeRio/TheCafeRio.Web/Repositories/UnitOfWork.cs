using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace TheCafeRio.Web.Repositories
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : DbContext
    {
        protected readonly T _dbContext;

        public UnitOfWork(string connectionString)
            => _dbContext = (T)Activator.CreateInstance(typeof(T), connectionString);

        public void Dispose() => _dbContext?.Dispose();

        public void Save() => _dbContext?.SaveChanges();
    }
}
