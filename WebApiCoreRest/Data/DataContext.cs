using Microsoft.EntityFrameworkCore;
using WebApiCoreRest.Model;

namespace WebApiCoreRest.Data
{
    /*
     * nuget Microsoft.EntityFrameworkCore.Design
     * nuget Microsoft.EntityFrameworkCore.SqlServer
     * nuget Microsoft.EntityFrameworkCore
     * dotnet tool install --globlal dotnet-ef
     * go Progrma.cs add string connection
     * go nuget to migration db
     * dotnet ef migrations add CreateInitial
     * dotnet ef database update
     * 
     */
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { } 
        public DbSet<Fruta> Frutas { get; set; }
    }
}
