using System.Threading.Tasks;

namespace AngularDotNet.Data;

public interface IAngularDotNetDbSchemaMigrator
{
    Task MigrateAsync();
}
