using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public DbSet<ProjetoUdemySalesWebMvc.Models.Department> Department { get; set; }
    }
}
