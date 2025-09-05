using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Account;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.VirtualFileSystem;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;

namespace ProyectoDesarrollo2025;

[DependsOn(
    typeof(ProyectoDesarrollo2025ApplicationContractsModule),
    typeof(AbpPermissionManagementHttpApiClientModule),
    typeof(AbpFeatureManagementHttpApiClientModule),
    typeof(AbpAccountHttpApiClientModule),
    typeof(AbpIdentityHttpApiClientModule),
    typeof(AbpSettingManagementHttpApiClientModule)
)]
public class ProyectoDesarrollo2025HttpApiClientModule : AbpModule
{
    public const string RemoteServiceName = "Default";

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(ProyectoDesarrollo2025ApplicationContractsModule).Assembly,
            RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<ProyectoDesarrollo2025HttpApiClientModule>();
        });
    }
}
