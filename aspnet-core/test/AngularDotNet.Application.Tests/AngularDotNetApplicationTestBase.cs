using Volo.Abp.Modularity;

namespace AngularDotNet;

public abstract class AngularDotNetApplicationTestBase<TStartupModule> : AngularDotNetTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
