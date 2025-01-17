﻿using Datab.Entity;
using Infrastructure.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class WMasterDbContext :IdentityDbContext<ApplicationUser>
    {
        public WMasterDbContext(DbContextOptions<WMasterDbContext> options) : base (options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //builder.Entity<IdentityUser>().ToTable("Users,Identity");
            //builder.Entity<IdentityRole>().ToTable("Roles","Identity");
            //builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles,Identity");
            //builder.Entity<IdentityUserClaim<string>>().ToTable("UsersClaim,Identity");
            //builder.Entity<IdentityUserLogin<string>>().ToTable("UsersLogin,Identity");
            //builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaim,Identity");
            //builder.Entity<IdentityUserToken<string>>().ToTable("UserToken,Identity");

            builder.Entity<Category>().Property(x => x.Id).HasDefaultValueSql("(newid())");
            builder.Entity<LogCategory>().Property(x => x.Id).HasDefaultValueSql("(newid())");
            builder.Entity<SubCategory>().Property(x => x.Id).HasDefaultValueSql("(newid())");
            builder.Entity<LogSubCategory>().Property(x => x.Id).HasDefaultValueSql("(newid())");
            builder.Entity<Cars>().Property(x => x.Id).HasDefaultValueSql("(newid())");
            builder.Entity<LogCars>().Property(x => x.Id).HasDefaultValueSql("(newid())");

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<LogCategory> LogCategories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<LogSubCategory> LogSubCategories { get; set; }
        public DbSet<Cars> Car { get; set; }
        public DbSet<LogCars> LogCar { get; set; }
    }
}
