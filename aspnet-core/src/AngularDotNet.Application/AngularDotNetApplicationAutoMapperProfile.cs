using AngularDotNet.Authors;
using AngularDotNet.Books;
using AutoMapper;

namespace AngularDotNet;

public class AngularDotNetApplicationAutoMapperProfile : Profile
{
    public AngularDotNetApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        CreateMap<Author, AuthorDto>();
        CreateMap<Author, AuthorLookupDto>();
    }
}
