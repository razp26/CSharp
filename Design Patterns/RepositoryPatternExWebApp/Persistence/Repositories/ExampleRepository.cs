using RepositoryPatternExWebApp.Core.Domain;
using RepositoryPatternExWebApp.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPatternExWebApp.Persistence.Repositories
{
    public class ExampleRepository : Repository<Example>, IExampleRepository
    {
        public ExampleRepository(AppContext context) : base(context)
        {

        }

        public IEnumerable<Example> GetTopExamples(int count)
        {
            return AppContext.Examples.OrderBy(x => x.Id).Take(count).ToList();
        }

        public IEnumerable<Example> GetExamplesByName(int pageIndex, int pageSize)
        {
            return AppContext.Examples.OrderBy(x => x.Name).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
        }

        public AppContext AppContext
        {
            get { return context as AppContext; }
        }
    }
}
