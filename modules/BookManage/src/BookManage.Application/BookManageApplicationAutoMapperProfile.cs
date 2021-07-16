using AutoMapper;
using BookManage.BooksManages;

namespace BookManage
{
    public class BookManageApplicationAutoMapperProfile : Profile
    {
        public BookManageApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<BooksManage, BooksManageDto>();
            CreateMap<ImportExportBooksManageDto, BooksManage>();
        }
    }
}