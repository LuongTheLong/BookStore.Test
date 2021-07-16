using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace UserManage.MongoDB
{
    [ConnectionStringName(UserManageDbProperties.ConnectionStringName)]
    public interface IUserManageMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
