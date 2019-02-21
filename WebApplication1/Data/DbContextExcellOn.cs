using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class DbContextExcellOn: DbContext
    {
        public DbContextExcellOn()
        {
        }

        public DbContextExcellOn(DbContextOptions<DbContextExcellOn> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<Company> Company { get; set; }             
        public virtual DbSet<Employee> Employee { get; set; }     
        public virtual DbSet<OrderOfService> OrderOfService { get; set; }
        public virtual DbSet<OrderOfServiceDetail> OrderOfServiceDetail { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<ServiceType> ServiceType { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<OrderOfServiceDetail>().HasKey(od => new {od.ServiceId, od.OrderOfServiceId,});
            

        }
    }
}
