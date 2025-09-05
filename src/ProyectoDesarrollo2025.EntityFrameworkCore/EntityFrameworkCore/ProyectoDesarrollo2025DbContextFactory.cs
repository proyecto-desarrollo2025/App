using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ProyectoDesarrollo2025.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class ProyectoDesarrollo2025DbContextFactory : IDesignTimeDbContextFactory<ProyectoDesarrollo2025DbContext>
{
    public ProyectoDesarrollo2025DbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        ProyectoDesarrollo2025EfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<ProyectoDesarrollo2025DbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new ProyectoDesarrollo2025DbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../ProyectoDesarrollo2025.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
