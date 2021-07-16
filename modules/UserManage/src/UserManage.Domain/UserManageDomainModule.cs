using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace UserManage
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(UserManageDomainSharedModule)
    )]
    public class UserManageDomainModule : AbpModule
    {

    }
}
