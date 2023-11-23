using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace VariciDanismanlikMVC.Data
{
   
    public class IletisimContext: DbContext
    {
        public IletisimContext(DbContextOptions<IletisimContext> options): base(options)
        {
            
        }
     public DbSet<Iletisim> Iletisimler => Set<Iletisim>();
     
    }
}