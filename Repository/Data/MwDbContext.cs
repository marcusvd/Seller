using System;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Repository
{

    public class MwDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        
        public MwDbContext(DbContextOptions<MwDbContext> opt):base(opt)
        {

        }


    }
}
