using Acme.User.MongoDB;
using Volo.Abp.Modularity;

namespace Acme.User
{
    [DependsOn(
        typeof(UserMongoDbTestModule)
        )]
    public class UserDomainTestModule : AbpModule
    {

    }
}