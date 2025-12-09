using Volo.Abp;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.BackgroundWorkers;
using Volo.Abp.Modularity;
using Volo.Abp.OpenIddict.Tokens;
using Volo.Abp.Uow;
using FAFS.EntityFrameworkCore; // 👈 o el namespace donde esté tu módulo EFCore de tests

namespace FAFS;

[DependsOn(
    typeof(FAFSApplicationModule),
    typeof(FAFSEntityFrameworkCoreTestModule) //  ESTE es el punto clave
)]
public class FAFSApplicationTestModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        // Los tests no necesitan transacciones reales
        Configure<AbpUnitOfWorkDefaultOptions>(options =>
        {
            options.TransactionBehavior = UnitOfWorkTransactionBehavior.Disabled;
        });

        // Deshabilitar ejecución de background jobs
        Configure<AbpBackgroundJobOptions>(options =>
        {
            options.IsJobExecutionEnabled = false;
        });

        // Deshabilitar background workers (incluidos los de OpenIddict)
        Configure<AbpBackgroundWorkerOptions>(options =>
        {
            options.IsEnabled = false;
        });

        // Deshabilitar el cleanup de tokens de OpenIddict en tests
        Configure<TokenCleanupOptions>(options =>
        {
            options.IsCleanupEnabled = false;
        });
    }
}
