using FastShopApp.Entities;
using FastShopApp.Entities.Configurations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastShopApp.DAL
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        public Context(DbContextOptions<Context> opt) : base(opt)
        {

        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BrandConfig());
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new CommentConfig());
            modelBuilder.ApplyConfiguration(new OrderConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());

            modelBuilder.Entity<Brand>().HasData(
                    new Brand
                    {
                        Id=1,
                        BrandName = "Konuşarak Öğren",
                        CreatedDate = DateTime.Now,
                        ModifiedDate = null,
                        BrandAbout ="ingilizce öğrenme platformu"
                    }
                ) ;
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    CategoryName ="Mobilya",
                    CategoryDescription ="Ev Eşyaları"
                });

            
            modelBuilder.Entity<AppRole>().HasData(
                new AppRole
                {
                    Id=1,
                    Name = "SysAdmin"
                },
                new AppRole
                {
                    Id = 2,
                    Name = "Admin"
                },
                new AppRole
                {
                    Id = 3,
                    Name = "Customer"
                }
                );


            //SysAdmin
            var appUser = new AppUser
            {
                Id = 1,
                Name = "Yalın",
                UserName = "yukselyal",
                BrandId = 1,
                Email = "yukselyal@gmail.com",
                NormalizedUserName = "YUKSELYAL",
                Surname = "Sonat",
                PhoneNumber = "5555555555",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                LockoutEnabled = true,
                SecurityStamp = Guid.NewGuid().ToString("D"),

            };
            PasswordHasher<AppUser> ph = new PasswordHasher<AppUser>();
            appUser.PasswordHash = ph.HashPassword(appUser, "123456");
            modelBuilder.Entity<AppUser>().HasData(appUser);
            modelBuilder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int>
            {
                RoleId = 1,
                UserId = 1
            });

            //Admin
            var appUser2 = new AppUser
            {
                Id=2,
                Name = "Baran",
                BrandId = 1,
                Email = "baran@gmail.com",
                UserName = "baran66",
                NormalizedUserName = "BARAN66",
                Surname = "kaya",
                PhoneNumber = "6666666666",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                LockoutEnabled = true,
                SecurityStamp = Guid.NewGuid().ToString("D"),

            };
            PasswordHasher<AppUser> ph2 = new PasswordHasher<AppUser>();
            appUser2.PasswordHash = ph2.HashPassword(appUser2, "123456");
            modelBuilder.Entity<AppUser>().HasData(appUser2);
            modelBuilder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int>
            {
                RoleId = 2,
                UserId = 2
            });


            //Customer
            var appUser3 = new AppUser
            {
                Id = 3,
                Name = "Müşteri",
                UserName = "musteri77",
                NormalizedUserName = "MUSTERI77",
                BrandId = 1,
                Email = "musteri@gmail.com",
                Surname = "halk",
                PhoneNumber = "7777777777",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                LockoutEnabled = true,
                SecurityStamp = Guid.NewGuid().ToString("D"),

            };
            PasswordHasher<AppUser> ph3 = new PasswordHasher<AppUser>();
            appUser3.PasswordHash = ph3.HashPassword(appUser3, "123456");
            modelBuilder.Entity<AppUser>().HasData(appUser3);
            modelBuilder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int>
            {
                RoleId = 3,
                UserId = 3
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
