using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wms.Entities;

namespace wms.DataAccess
{
    public class AlanContext:DbContext
    {
        public AlanContext(DbContextOptions<AlanContext> options)
           : base(options)
        { }

        public DbSet<Classify> Classify { get; set; }
    }
}
