using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace UserManage
{
    [DependsOn(
        typeof(UserManageDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class UserManageApplicationContractsModule : AbpModule
    {

    }
}
