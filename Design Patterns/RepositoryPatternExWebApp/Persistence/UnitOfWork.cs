using RepositoryPatternExWebApp.Core;
using RepositoryPatternExWebApp.Core.Repositories;
using RepositoryPatternExWebApp.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPatternExWebApp.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppContext context;
        public IExampleRepository Examples { get; private set; }

        public UnitOfWork(AppContext context)
        {
            this.context = context;
            Examples = new ExampleRepository(context);
        }

        public int Complete()
        {
            return context.SaveChanges();
        }

        public void Dispose()
        {
            return context.Dispose();
        }
    }
}
