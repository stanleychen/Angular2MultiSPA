﻿using Microsoft.EntityFrameworkCore;
using OpenIddict;

namespace Angular2MultiSPA.Models
{
    public class ApplicationDbContext : OpenIddictDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
