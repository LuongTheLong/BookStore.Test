using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace BookManage.MongoDB
{
    [ConnectionStringName(BookManageDbProperties.ConnectionStringName)]
    public interface IBookManageMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
