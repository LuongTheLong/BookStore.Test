using System;
using System.Threading.Tasks;
using Acme.BookStore.Authors;
using Acme.BookStore.Books;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using BookManage.BookManage;



namespace Acme.BookStore
{
    public class BookStoreDataSeederContributor
        : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Book, Guid> _bookRepository;
        private readonly IAuthorRepository _authorRepository;
        private readonly AuthorManager _authorManager;
        private readonly IRepository<BookManages, Guid> _bookManagesRepository;


        public BookStoreDataSeederContributor(
            IRepository<Book, Guid> bookRepository,
            IAuthorRepository authorRepository,
            AuthorManager authorManager,
            IRepository<BookManages, Guid> bookManagesRepository
            )
        {
            _bookRepository = bookRepository;
            _authorRepository = authorRepository;
            _authorManager = authorManager;
            _bookManagesRepository = bookManagesRepository;

        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _bookRepository.GetCountAsync() > 0)
            {
                return;
            }

            if (await _bookManagesRepository.GetCountAsync() > 0)
            {
                return;
            }

            var orwell = await _authorRepository.InsertAsync(
                await _authorManager.CreateAsync(
                    "George Orwell",
                    new DateTime(1903, 06, 25),
                    "Orwell produced literary criticism and poetry, fiction and polemical journalism; and is best known for the allegorical novella Animal Farm (1945) and the dystopian novel Nineteen Eighty-Four (1949)."
                )
            );

            var douglas = await _authorRepository.InsertAsync(
                await _authorManager.CreateAsync(
                    "Douglas Adams",
                    new DateTime(1952, 03, 11),
                    "Douglas Adams was an English author, screenwriter, essayist, humorist, satirist and dramatist. Adams was an advocate for environmentalism and conservation, a lover of fast cars, technological innovation and the Apple Macintosh, and a self-proclaimed 'radical atheist'."
                )
            );



            var b1 = await _bookRepository.InsertAsync(
                new Book
                {
                    AuthorId = orwell.Id, // SET THE AUTHOR
                    Name = "1984",
                    Type = BookType.Dystopia,
                    PublishDate = new DateTime(1949, 6, 8),
                    Price = 19.84f,
                    Amount = 50
                },
                autoSave: true
            );

            var b2 = await _bookRepository.InsertAsync(
                new Book
                {
                    AuthorId = douglas.Id, // SET THE AUTHOR
                    Name = "The Hitchhiker's Guide to the Galaxy",
                    Type = BookType.ScienceFiction,
                    PublishDate = new DateTime(1995, 9, 27),
                    Price = 42.0f,
                    Amount = 30
                },
                autoSave: true
            );

            await _bookManagesRepository.InsertAsync(
                new BookManages
                {
                    AuthorId = orwell.Id, // SET THE AUTHOR
                    Name = b1.Name,
                    Type = BookManagesType.Dystopia,
                    PublishDate = new DateTime(b1.PublishDate.Year, b1.PublishDate.Month, b1.PublishDate.Day),
                    Price = b1.Price,
                    Amount = 0
                },
                autoSave: true
                );
            await _bookManagesRepository.InsertAsync(
                new BookManages
                {
                    AuthorId = douglas.Id, // SET THE AUTHOR
                    Name = b2.Name,
                    Type = BookManagesType.ScienceFiction,
                    PublishDate = new DateTime(b2.PublishDate.Year, b2.PublishDate.Month, b2.PublishDate.Day),
                    Price = b2.Price,
                    Amount = 0
                },
                autoSave: true
                );
        }
    }
}
