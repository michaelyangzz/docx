using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EFMigrationWithFactory;

public class DbDemoContextFactory : IDesignTimeDbContextFactory<DbDemoContext>
{
    public DbDemoContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<DbDemoContext>();
        optionsBuilder.UseSqlServer("Data Source=localhost,31017;Database=DbDemoFactory-Local;User Id=sa;Password=HJ@81234_JBBdAKiqt;");

        return new DbDemoContext(optionsBuilder.Options);
    }
}
