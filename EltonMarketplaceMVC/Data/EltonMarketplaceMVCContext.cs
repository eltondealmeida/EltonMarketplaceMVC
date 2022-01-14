using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EltonMarketplaceMVC.Models;

namespace EltonMarketplaceMVC.Data
{
    public class EltonMarketplaceMVCContext : DbContext
    {
        public EltonMarketplaceMVCContext (DbContextOptions<EltonMarketplaceMVCContext> options)
            : base(options)
        {
        }

        public DbSet<EltonMarketplaceMVC.Models.Department> Department { get; set; }
    }
}
