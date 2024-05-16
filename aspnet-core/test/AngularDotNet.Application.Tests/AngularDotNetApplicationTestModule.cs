using Volo.Abp.Modularity;

namespace AngularDotNet;

[DependsOn(
    typeof(AngularDotNetApplicationModule),
    typeof(AngularDotNetDomainTestModule)
)]
public class AngularDotNetApplicationTestModule : AbpModule
{

}
