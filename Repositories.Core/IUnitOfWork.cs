using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Core
{
    public interface IUnitOfWork : IDisposable
    {
        T GetRepository<T>() where T : class;
        void SaveChanges();
    }
}
