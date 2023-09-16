# How to use EF Core EntityFramework Core
1. dotnet tool install --global dotnet-ef
1. dotnet add package Microsoft.EntityFrameworkCore.Design
1. dotnet ef migrations add InitialCreate
1. dotnet ef database update

# Design time dbcontext create
1. dotnet ef migrations has to know how to create a dbcontext instance, which contains db schemes. 
1. if you run the ef commands on the WebHost app/GenericHost app path, the command will access the service provider of the app to create dbcontext. 
1. if you run on the normal class library project. 