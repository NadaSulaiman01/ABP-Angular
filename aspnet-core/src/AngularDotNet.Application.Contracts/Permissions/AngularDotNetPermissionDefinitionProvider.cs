using AngularDotNet.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AngularDotNet.Permissions;

public class AngularDotNetPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        //var myGroup = context.AddGroup(AngularDotNetPermissions.GroupName);
        var bookStoreGroup = context.AddGroup(AngularDotNetPermissions.GroupName, L("Permission:AngularDotNet"));

        var booksPermission = bookStoreGroup.AddPermission(AngularDotNetPermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(AngularDotNetPermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(AngularDotNetPermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(AngularDotNetPermissions.Books.Delete, L("Permission:Books.Delete"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AngularDotNetPermissions.MyPermission1, L("Permission:MyPermission1"));


        var authorsPermission = bookStoreGroup.AddPermission(
    AngularDotNetPermissions.Authors.Default, L("Permission:Authors"));
        authorsPermission.AddChild(
            AngularDotNetPermissions.Authors.Create, L("Permission:Authors.Create"));
        authorsPermission.AddChild(
            AngularDotNetPermissions.Authors.Edit, L("Permission:Authors.Edit"));
        authorsPermission.AddChild(
            AngularDotNetPermissions.Authors.Delete, L("Permission:Authors.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AngularDotNetResource>(name);
    }
}
