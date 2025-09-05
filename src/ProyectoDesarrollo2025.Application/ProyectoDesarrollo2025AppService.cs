using ProyectoDesarrollo2025.Localization;
using Volo.Abp.Application.Services;

namespace ProyectoDesarrollo2025;

/* Inherit your application services from this class.
 */
public abstract class ProyectoDesarrollo2025AppService : ApplicationService
{
    protected ProyectoDesarrollo2025AppService()
    {
        LocalizationResource = typeof(ProyectoDesarrollo2025Resource);
    }
}
