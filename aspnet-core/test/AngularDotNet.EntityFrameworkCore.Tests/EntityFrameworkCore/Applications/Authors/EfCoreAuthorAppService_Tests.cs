using AngularDotNet.Authors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AngularDotNet.EntityFrameworkCore.Applications.Authors
{
    [Collection(AngularDotNetTestConsts.CollectionDefinitionName)]
    public class EfCoreAuthorAppService_Tests : AuthorAppService_Tests<AngularDotNetEntityFrameworkCoreTestModule>
    {

    }
}
