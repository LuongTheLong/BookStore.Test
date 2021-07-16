using System;
using System.Collections.Generic;
using System.Linq.Dynamic.Core;
using System.Linq;
using System.Threading.Tasks;
using Acme.BookStore.Authors;
using Acme.BookStore.Permissions;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using GemBox.Spreadsheet;

namespace Acme.BookStore.Books
{

    [Authorize(BookStorePermissions.Books.Default)]
    public class BookAppService :
        CrudAppService<
            Book, //The Book entity
            BookDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateBookDto>, //Used to create/update a book
        IBookAppService //implement the IBookAppService
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IRepository<Authors.Author, Guid> _authors1;


        public BookAppService(
            IRepository<Book, Guid> repository,
            IAuthorRepository authorRepository,
            IRepository<Authors.Author, Guid> authors1)
            : base(repository)
        {
            _authorRepository = authorRepository;
            _authors1 = authors1;
            GetPolicyName = BookStorePermissions.Books.Default;
            GetListPolicyName = BookStorePermissions.Books.Default;
            CreatePolicyName = BookStorePermissions.Books.Create;
            UpdatePolicyName = BookStorePermissions.Books.Edit;
            DeletePolicyName = BookStorePermissions.Books.Create;
        }

        public async override Task<BookDto> GetAsync(Guid id)
        {
            var book = await Repository.GetAsync(id);
            var bookDto = ObjectMapper.Map<Book, BookDto>(book);

            var author = await _authorRepository.GetAsync(book.AuthorId);
            bookDto.AuthorName = author.Name;

            return bookDto;
        }

        public async override Task<PagedResultDto<BookDto>>
            GetListAsync(PagedAndSortedResultRequestDto input)
        {
            //Set a default sorting, if not provided
            if (input.Sorting.IsNullOrWhiteSpace())
            {
                input.Sorting = nameof(Book.Name);
            }

            //Get the IQueryable<Book> from the repository
            var queryable = await Repository.GetQueryableAsync();

            //Get the books
            var books = await AsyncExecuter.ToListAsync(
                queryable
                    .OrderBy(input.Sorting)
                    .Skip(input.SkipCount)
                    .Take(input.MaxResultCount)
            );

            //Convert to DTOs
            var bookDtos = ObjectMapper.Map<List<Book>, List<BookDto>>(books);

            //Get a lookup dictionary for the related authors
            var authorDictionary = await GetAuthorDictionaryAsync(books);

            //Set AuthorName for the DTOs
            bookDtos.ForEach(bookDto => bookDto.AuthorName =
                             authorDictionary[bookDto.AuthorId].Name);

            //Get the total count with another query (required for the paging)
            var totalCount = await Repository.GetCountAsync();

            return new PagedResultDto<BookDto>(
                totalCount,
                bookDtos
            );
        }

        public async Task<ListResultDto<AuthorLookupDto>> GetAuthorLookupAsync()
        {
            var authors = await _authorRepository.GetListAsync();

            return new ListResultDto<AuthorLookupDto>(
                ObjectMapper.Map<List<Authors.Author>, List<AuthorLookupDto>>(authors)
            );
        }

        private async Task<Dictionary<Guid, Authors.Author>>
            GetAuthorDictionaryAsync(List<Book> books)
        {
            var authorIds = books
                .Select(b => b.AuthorId)
                .Distinct()
                .ToArray();

            var queryable = await _authorRepository.GetQueryableAsync();

            var authors = await AsyncExecuter.ToListAsync(
                queryable.Where(a => authorIds.Contains(a.Id))
            );

            return authors.ToDictionary(x => x.Id, x => x);
        }

        public async Task<List<BookDto>> GetAllBook()
        {
            var books = await Repository.GetListAsync();

            return ObjectMapper.Map<List<Book>, List<BookDto>>(books);
        }

        public async Task<object> ExportDB()
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            try
            {
                List<Book> getlist = await Repository.GetListAsync();
                var list = ObjectMapper.Map<List<Book>, List<BookDto>>(getlist);



                //File.WriteAllText(@"D:\ExportDatabaseBooks.json", json);
                ExcelFile workbook = new ExcelFile();
                ExcelWorksheet worksheet = workbook.Worksheets.Add("Books");

                // Define header values
                worksheet.Cells[0, 0].Value = "Author Name";
                worksheet.Cells[0, 1].Value = "Book Name";
                worksheet.Cells[0, 2].Value = "Type";
                worksheet.Cells[0, 3].Value = "PublishDate";
                worksheet.Cells[0, 4].Value = "Price";
                worksheet.Cells[0, 5].Value = "Amount";


                // Write deserialized values to a sheet
                int row = 0;
                var lstauthr = await _authors1.GetListAsync();
                //Authors.Author author;
                foreach (BookDto book in list)
                {
                    //var author =  _authorRepository.Where(x=>x.Id == book.AuthorId).FirstOrDefault();
                    var author = lstauthr.FirstOrDefault(x=>x.Id == book.AuthorId);
                    worksheet.Cells[++row, 0].Value = author!=null ? author.Name : null;
                    worksheet.Cells[row, 1].Value = book.Name;
                    worksheet.Cells[row, 2].Value = book.Type;
                    worksheet.Cells[row, 3].Value = book.PublishDate;
                    worksheet.Cells[row, 4].Value = book.Price;
                    worksheet.Cells[row, 5].Value = book.Amount;
                }

                // Save excel file
                workbook.Save(@"D:\ExportDatabaseBooks.xlsx");

            }
            catch (Exception e)
            {

                throw e;
            }
           
            return null;
        }
    }
}
