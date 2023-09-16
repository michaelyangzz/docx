using Microsoft.EntityFrameworkCore;

namespace EFMigrationWithFactory;

public class DbDemoContext : DbContext
{
    public DbDemoContext(DbContextOptions options) : base(options)
    {
    }
}

