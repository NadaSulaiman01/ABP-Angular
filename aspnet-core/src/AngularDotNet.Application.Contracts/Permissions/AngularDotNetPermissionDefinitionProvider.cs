using AngularDotNet.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AngularDotNet.Permissions;

public class AngularDotNetPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AngularDotNetPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AngularDotNetPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AngularDotNetResource>(name);
    }
}
