using TDesk.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace TDesk.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class TDeskController : AbpController
    {
        protected TDeskController()
        {
            LocalizationResource = typeof(TDeskResource);
        }
    }
}