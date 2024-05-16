using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AngularDotNet.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class AngularDotNetDbContextFactory : IDesignTimeDbContextFactory<AngularDotNetDbContext>
{
    public AngularDotNetDbContext CreateDbContext(string[] args)
    {
        AngularDotNetEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<AngularDotNetDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new AngularDotNetDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../AngularDotNet.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
