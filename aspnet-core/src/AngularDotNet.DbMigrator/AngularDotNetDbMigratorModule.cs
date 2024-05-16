using AngularDotNet.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace AngularDotNet.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AngularDotNetEntityFrameworkCoreModule),
    typeof(AngularDotNetApplicationContractsModule)
    )]
public class AngularDotNetDbMigratorModule : AbpModule
{
}
