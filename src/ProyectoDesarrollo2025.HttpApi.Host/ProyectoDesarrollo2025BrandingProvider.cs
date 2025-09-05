using Microsoft.Extensions.Localization;
using ProyectoDesarrollo2025.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ProyectoDesarrollo2025;

[Dependency(ReplaceServices = true)]
public class ProyectoDesarrollo2025BrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<ProyectoDesarrollo2025Resource> _localizer;

    public ProyectoDesarrollo2025BrandingProvider(IStringLocalizer<ProyectoDesarrollo2025Resource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
