using ProyectoDesarrollo2025.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace ProyectoDesarrollo2025.Permissions;

public class ProyectoDesarrollo2025PermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ProyectoDesarrollo2025Permissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(ProyectoDesarrollo2025Permissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ProyectoDesarrollo2025Resource>(name);
    }
}
