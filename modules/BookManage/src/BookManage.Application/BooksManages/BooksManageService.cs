using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace BookManage.BooksManages
{
    class BooksManageService :
        CrudAppService<
            BooksManage, //The Book entity
            BooksManageDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            ImportExportBooksManageDto>, //Used to create/update a book
        IBooksManageService //implement the IBookAppService
    {
        public BooksManageService(IRepository<BooksManage, Guid> repository)
            : base(repository)
        {

        }
    }
}
