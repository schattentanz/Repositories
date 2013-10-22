using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Core
{
    public class Repository<T> : IRepository<T>
    {
        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
