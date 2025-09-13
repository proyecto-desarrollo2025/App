using ProyectoDesarrollo2025.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ProyectoDesarrollo2025.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ProyectoDesarrollo2025Controller : AbpControllerBase
{
    protected ProyectoDesarrollo2025Controller()
    {
        LocalizationResource = typeof(ProyectoDesarrollo2025Resource);
    }
}
