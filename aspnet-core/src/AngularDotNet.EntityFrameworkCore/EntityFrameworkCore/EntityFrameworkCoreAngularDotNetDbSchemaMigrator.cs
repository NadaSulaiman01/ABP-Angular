using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AngularDotNet.Data;
using Volo.Abp.DependencyInjection;

namespace AngularDotNet.EntityFrameworkCore;

public class EntityFrameworkCoreAngularDotNetDbSchemaMigrator
    : IAngularDotNetDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAngularDotNetDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the AngularDotNetDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AngularDotNetDbContext>()
            .Database
            .MigrateAsync();
    }
}
