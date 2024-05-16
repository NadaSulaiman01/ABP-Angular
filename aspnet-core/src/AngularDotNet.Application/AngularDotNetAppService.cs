using System;
using System.Collections.Generic;
using System.Text;
using AngularDotNet.Localization;
using Volo.Abp.Application.Services;

namespace AngularDotNet;

/* Inherit your application services from this class.
 */
public abstract class AngularDotNetAppService : ApplicationService
{
    protected AngularDotNetAppService()
    {
        LocalizationResource = typeof(AngularDotNetResource);
    }
}
