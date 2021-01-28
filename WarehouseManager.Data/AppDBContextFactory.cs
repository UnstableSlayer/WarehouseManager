using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace WarehouseManager.Data
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<WarehouseManagerDBContext>
    {
        public WarehouseManagerDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<WarehouseManagerDBContext>();
            optionsBuilder.UseSqlServer(@"data source=Allmight;initial catalog=WarehouseDB;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");

            return new WarehouseManagerDBContext(optionsBuilder.Options);
        }
    }
}
