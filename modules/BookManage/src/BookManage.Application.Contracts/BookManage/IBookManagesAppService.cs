using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace BookManage.BookManage
{
    public interface IBookManagesAppService :
        ICrudAppService< //Defines CRUD methods
            BookManagesDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateBookManagesDto> //Used to create/update a book
    {
        Task<ListResultDto<AuthorLookupDto>> GetAuthorLookupAsync();

        Task<List<BookManagesDto>> GetAllBook();

        public Task<object> ExportDB();
    }

}
