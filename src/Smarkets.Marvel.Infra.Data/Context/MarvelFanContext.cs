using Microsoft.EntityFrameworkCore;
using Smarkets.Marvel.Infra.Data.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smarkets.Marvel.Infra.Data.Context
{
    public class MarvelFanContext : DbContext
    {
        public MarvelFanContext(DbContextOptions<MarvelFanContext> options) : base(options)
        {
                
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MarvelFanMapping());
        }
    }
}
