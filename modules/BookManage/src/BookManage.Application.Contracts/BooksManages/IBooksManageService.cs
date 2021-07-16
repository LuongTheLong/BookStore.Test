using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace BookManage.BooksManages
{
    public interface IBooksManageService : ICrudAppService< //Defines CRUD methods
            BooksManageDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            ImportExportBooksManageDto> //Used to create/update a book
    {
        //Task<ListResultDto<AuthorLookupDto>> GetAuthorLookupAsync();

        //Task<List<BooksManageDto>> GetAllBook();

        //public Task<object> ExportDB();
    }
}
