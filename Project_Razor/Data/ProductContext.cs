﻿using Microsoft.EntityFrameworkCore;
using Project_Razor.Models;

namespace Project_Razor.Data
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Client> Clients { get; set; }
        public ProductContext (DbContextOptions<ProductContext> options)
            : base(options)
        {

        }
    }
}
