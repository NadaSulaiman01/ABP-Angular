using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AngularDotNet;

[Dependency(ReplaceServices = true)]
public class AngularDotNetBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AngularDotNet";
}
