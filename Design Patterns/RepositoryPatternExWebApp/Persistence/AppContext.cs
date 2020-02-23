using Microsoft.EntityFrameworkCore;
using RepositoryPatternExWebApp.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPatternExWebApp.Persistence
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {

        }

        public virtual DbSet<Example> Examples { get; set; }
    }
}
