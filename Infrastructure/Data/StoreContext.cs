using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class StoreContext : DbContext

    {
        public StoreContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Betekrstian> Betekrstians{get;set;}
        public DbSet<HagereSibket> HagereSibkets{get;set;}
        public DbSet<Region> Regions{get;set;}

    }
}