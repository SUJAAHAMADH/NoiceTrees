using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoiceTreeApi.Model
{
    public class NoiceTreeDbContext: DbContext
    {
        public NoiceTreeDbContext(DbContextOptions<NoiceTreeDbContext> options)
                : base(options)
        {
        }

        
        public DbSet<NoiceTree> NoiceTrees { get; set; }
    }
}
