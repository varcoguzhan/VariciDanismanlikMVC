using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace VariciDanismanlikMVC.Models
{
    public class IdentityContext: IdentityDbContext<IdentityUser>
    {
         public IdentityContext(DbContextOptions<IdentityContext>options):base(options)
         {
            
         }
    }
}