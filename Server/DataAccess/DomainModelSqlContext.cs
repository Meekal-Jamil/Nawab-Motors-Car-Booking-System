using prroject.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace prroject.Server.DataAccess
{
    public class DomainModelSqlContext : DbContext
    {
        public DomainModelSqlContext(DbContextOptions<DomainModelSqlContext> options) : base(options)
        {
        }
        public DbSet<carrental> rentaltable { get; set; }
		public DbSet<authentication> Authentication { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder); 
		}

		public override int SaveChanges()
		{
			return base.SaveChanges();
		}
	}
}
