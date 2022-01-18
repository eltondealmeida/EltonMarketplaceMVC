using EltonMarketplaceMVC.Data;
using EltonMarketplaceMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EltonMarketplaceMVC.Services
{
    public class SellerService
    {
        private readonly EltonMarketplaceMVCContext _context;

        public SellerService(EltonMarketplaceMVCContext context)
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
