using Volo.Abp.Modularity;

namespace AngularDotNet;

[DependsOn(
    typeof(AngularDotNetDomainModule),
    typeof(AngularDotNetTestBaseModule)
)]
public class AngularDotNetDomainTestModule : AbpModule
{

}
