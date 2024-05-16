using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace AngularDotNet.Authors
{
    public class AuthorAlreadyExistsException : BusinessException
    {
        public AuthorAlreadyExistsException(string name)
            : base(AngularDotNetDomainErrorCodes.AuthorAlreadyExists)
        {
            WithData("name", name);
        }
    }
}
