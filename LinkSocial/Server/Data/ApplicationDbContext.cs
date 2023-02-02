using IdentityServer4.EntityFramework.Options;
using LinkSocial.Server.Models;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinkSocial.Shared.Models;

namespace LinkSocial.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Link> Links { get; set; }
        public DbSet<Settings> PageSettings { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>()
                .Property(e => e.PageName)
                .HasMaxLength(250);

            builder.Entity<ApplicationUser>()
                .HasIndex(e => e.PageName)
                .IsUnique();

            builder.Entity<Link>()
                .HasIndex(e => e.PageName);

            builder.Entity<Settings>()
                .HasIndex(e => e.PageName);
        }
    }
}
