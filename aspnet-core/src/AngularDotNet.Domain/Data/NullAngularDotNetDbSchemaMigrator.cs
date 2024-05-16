using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AngularDotNet.Data;

/* This is used if database provider does't define
 * IAngularDotNetDbSchemaMigrator implementation.
 */
public class NullAngularDotNetDbSchemaMigrator : IAngularDotNetDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
