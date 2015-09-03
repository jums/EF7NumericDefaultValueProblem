using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;

namespace EF7BooleanDefaultValue.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Thing> Things { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            builder.Entity<Thing>().Property(t => t.Name).HasDefaultValue("n/a").Required();
            builder.Entity<Thing>().Property(t => t.IsDeleted).HasDefaultValue(false);
            builder.Entity<Thing>().Property(t => t.FavouriteNumber).HasDefaultValue(42);
        }
    }
}
