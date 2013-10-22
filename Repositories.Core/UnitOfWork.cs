using Autofac;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Core
{
    public class UnitOfWork : IUnitOfWork
    {
        private static IContainer _container;
        Hashtable _repositories = new Hashtable();
        public static Module CurrentRepositoriesModule { get; set; }
        public object _session;

        public UnitOfWork()
        {
            var builder = new ContainerBuilder();
            if (CurrentRepositoriesModule != null)
                builder.RegisterModule(CurrentRepositoriesModule);
            _container = builder.Build();
            _session = new object();
        }

        public T GetRepository<T>() where T : class
        {
            var targetType = typeof(T);
            if (!_repositories.ContainsKey(targetType))
            {
                _repositories.Add(targetType, _container.Resolve<T>());
            }
            return (T)_repositories[targetType];
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
