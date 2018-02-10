using aspdotnetblog.Models;
using Microsoft.EntityFrameworkCore;

namespace aspdotnetblog.Persistence
{
    public class VegaDbContext: DbContext
    {
        public VegaDbContext(DbContextOptions<VegaDbContext> options):base(options){
           
            
        }
         public DbSet<Make> Makes { get; set; }
    }
}