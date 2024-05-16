using AngularDotNet.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AngularDotNet.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AngularDotNetController : AbpControllerBase
{
    protected AngularDotNetController()
    {
        LocalizationResource = typeof(AngularDotNetResource);
    }
}
