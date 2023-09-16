

using Microsoft.EntityFrameworkCore;

namespace EFMigrationWIthClass;

public class DbDemoContext : DbContext
{
    public DbDemoContext()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer("Data Source=localhost,31017;Database=DbDemoContext-Local;User Id=sa;Password=xxxx;");
    }
}

