using AngularDotNet.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AngularDotNet.EntityFrameworkCore.Applications.Books
{
    [Collection(AngularDotNetTestConsts.CollectionDefinitionName)]
    public class EfCoreBookAppService_Tests : BookAppService_Tests<AngularDotNetEntityFrameworkCoreTestModule>
    {

    }
}
