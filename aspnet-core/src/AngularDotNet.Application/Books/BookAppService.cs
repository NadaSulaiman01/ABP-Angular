using AngularDotNet.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AngularDotNet.Books
{
    public class BookAppService :
        CrudAppService<
            Book, //The Book entity
            BookDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateBookDto>, //Used to create/update a book
        IBookAppService //implement the IBookAppService
    {
        public BookAppService(IRepository<Book, Guid> repository)
            : base(repository)
        {
            GetPolicyName = AngularDotNetPermissions.Books.Default;
            GetListPolicyName = AngularDotNetPermissions.Books.Default;
            CreatePolicyName = AngularDotNetPermissions.Books.Create;
            UpdatePolicyName = AngularDotNetPermissions.Books.Edit;
            DeletePolicyName = AngularDotNetPermissions.Books.Delete;
        }
    }
}
