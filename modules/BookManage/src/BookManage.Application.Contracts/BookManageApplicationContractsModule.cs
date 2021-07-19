using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace BookManage
{
    [DependsOn(
        typeof(BookManageDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class BookManageApplicationContractsModule : AbpModule
    {

    }
}
