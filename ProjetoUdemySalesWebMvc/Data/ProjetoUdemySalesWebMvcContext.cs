using Microsoft.EntityFrameworkCore;
using ProjetoUdemySalesWebMvc.Models;

namespace ProjetoUdemySalesWebMvc.Data
{
    public class ProjetoUdemySalesWebMvcContext : DbContext
    {
        public ProjetoUdemySalesWebMvcContext (DbContextOptions<ProjetoUdemySalesWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
