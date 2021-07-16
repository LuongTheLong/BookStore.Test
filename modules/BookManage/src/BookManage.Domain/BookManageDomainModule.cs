using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace BookManage
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(BookManageDomainSharedModule)
    )]
    public class BookManageDomainModule : AbpModule
    {

    }
}
