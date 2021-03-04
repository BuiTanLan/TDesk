using System;
using System.Collections.Generic;
using System.Text;
using TDesk.Localization;
using Volo.Abp.Application.Services;

namespace TDesk
{
    /* Inherit your application services from this class.
     */
    public abstract class TDeskAppService : ApplicationService
    {
        protected TDeskAppService()
        {
            LocalizationResource = typeof(TDeskResource);
        }
    }
}
