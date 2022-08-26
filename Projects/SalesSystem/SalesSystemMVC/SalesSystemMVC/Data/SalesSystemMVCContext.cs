using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesSystemMVC.Models;

namespace SalesSystemMVC.Data
{
    public class SalesSystemMVCContext : DbContext
    {
        public SalesSystemMVCContext (DbContextOptions<SalesSystemMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }

		public DbSet<Seller> Seller { get; set; }
		public DbSet<SalesRecord> SalesRecord { get; set; }


	}
}
