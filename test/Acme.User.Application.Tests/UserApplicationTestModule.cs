using Volo.Abp.Modularity;

namespace Acme.User
{
    [DependsOn(
        typeof(UserApplicationModule),
        typeof(UserDomainTestModule)
        )]
    public class UserApplicationTestModule : AbpModule
    {

    }
}