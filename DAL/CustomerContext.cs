using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class CustomerContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
        {
        }

    }
}
