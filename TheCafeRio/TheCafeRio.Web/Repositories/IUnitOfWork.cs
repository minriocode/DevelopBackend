using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace TheCafeRio.Web.Repositories
{
    public interface IUnitOfWork<T> : IDisposable where T : DbContext
    {
        void Save();
    }
}
