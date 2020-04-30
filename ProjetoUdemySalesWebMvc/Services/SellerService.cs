using ProjetoUdemySalesWebMvc.Data;
using ProjetoUdemySalesWebMvc.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoUdemySalesWebMvc.Services
{
    public class SellerService
    {
        private readonly ProjetoUdemySalesWebMvcContext _context;

        public SellerService(ProjetoUdemySalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
