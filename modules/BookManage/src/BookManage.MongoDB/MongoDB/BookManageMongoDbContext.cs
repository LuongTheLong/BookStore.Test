using BookManage.BooksManages;
using MongoDB.Driver;
using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace BookManage.MongoDB
{
    [ConnectionStringName(BookManageDbProperties.ConnectionStringName)]
    public class BookManageMongoDbContext : AbpMongoDbContext, IBookManageMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */
        //public IMongoCollection<BooksManage> BookManages => Collection<BooksManage>();
        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureBookManage();
        }
    }
}