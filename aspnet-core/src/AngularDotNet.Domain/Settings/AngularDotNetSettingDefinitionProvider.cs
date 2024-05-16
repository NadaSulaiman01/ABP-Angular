using Volo.Abp.Settings;

namespace AngularDotNet.Settings;

public class AngularDotNetSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AngularDotNetSettings.MySetting1));
    }
}
