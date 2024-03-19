using AbcCompany.Models.DBEntities;
using Microsoft.EntityFrameworkCore;

namespace AbcCompany.DAL
{
    public class ResellerDbContext :DbContext
    {
        public ResellerDbContext(DbContextOptions options): base(options)
        {
            
        }

        public DbSet <Reseller> Resellers { get; set; }
    }
}
