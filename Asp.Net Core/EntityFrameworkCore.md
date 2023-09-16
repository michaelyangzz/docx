# How to use EF Core EntityFramework Core
1. dotnet tool install --global dotnet-ef
1. dotnet add package Microsoft.EntityFrameworkCore.Design
1. dotnet ef migrations add InitialCreate
1. dotnet ef database update

# Design time dbcontext create
1. dotnet ef migrations has to know how to create a dbcontext instance, which contains db schemes. 
1. if you run the ef commands on the WebHost app/GenericHost app path, the command will access the service provider of the app to create dbcontext. 
1. if ef can't get dbcontext from service provider, ef will look for derived DbContext type, create an instance using a constructor with no parameters. [FYI Codes](../src/EFCore/EFMigrationWIthClass/DbDemoContext.cs)
1. you can also explicitly tell ef how to create dbcontext by implementing the interface Microsoft.EntityFrameworkCore.Design.IDesignTimeDbContextFactory<TDbContext>, if so, ef will bypass the other two ways, and use design-time factory instead.  [FYI Codes](../src/EFCore/EFMigrationWithFactory/DbDemoContextFactory.cs). 
1. args in the factory, [FYI](https://learn.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args)
    ```
    dotnet ef database update -- --environment Production
    ```

# Data Feed 
- [useful links](https://learn.microsoft.com/en-us/ef/core/modeling/data-seeding) 