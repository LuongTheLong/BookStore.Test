using UserManage.MongoDB;
using Volo.Abp.Modularity;

namespace UserManage
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(UserManageMongoDbTestModule)
        )]
    public class UserManageDomainTestModule : AbpModule
    {
        
    }
}
