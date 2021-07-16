using BookManage.MongoDB;
using Volo.Abp.Modularity;

namespace BookManage
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(BookManageMongoDbTestModule)
        )]
    public class BookManageDomainTestModule : AbpModule
    {
        
    }
}
