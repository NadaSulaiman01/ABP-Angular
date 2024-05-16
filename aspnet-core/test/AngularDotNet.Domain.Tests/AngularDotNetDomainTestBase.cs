using Volo.Abp.Modularity;

namespace AngularDotNet;

/* Inherit from this class for your domain layer tests. */
public abstract class AngularDotNetDomainTestBase<TStartupModule> : AngularDotNetTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
