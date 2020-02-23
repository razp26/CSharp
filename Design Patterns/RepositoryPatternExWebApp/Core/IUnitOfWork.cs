using RepositoryPatternExWebApp.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPatternExWebApp.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IExampleRepository Examples { get; }
        int Complete();
    }
}
