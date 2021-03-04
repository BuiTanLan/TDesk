using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace TDesk
{
    [Dependency(ReplaceServices = true)]
    public class TDeskBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "TDesk";
    }
}
