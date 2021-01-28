using Microsoft.EntityFrameworkCore;
using WarehouseManager.Data.Entities;

namespace WarehouseManager.Data
{
    public class WarehouseManagerDBContext : DbContext
    {
        public WarehouseManagerDBContext(DbContextOptions<WarehouseManagerDBContext> options) : base(options) { }

        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<JobPosition> JobPositions { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<OrganizationType> OrganizationTypes { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<AccountentTree> AccountentTrees { get; set; }
        public DbSet<AccountentTreeType> AccountentTreeTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

        }
    }
}
