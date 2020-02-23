using RepositoryPatternExWebApp.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPatternExWebApp.Core.Repositories
{
    public interface IExampleRepository : IRepository<Example>
    {
        IEnumerable<Example> GetTopExamples(int count);
        IEnumerable<Example> GetExamplesByName(int pageIndex, int pageSize);
    }
}
