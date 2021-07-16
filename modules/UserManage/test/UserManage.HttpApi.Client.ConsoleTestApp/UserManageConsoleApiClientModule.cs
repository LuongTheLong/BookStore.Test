using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace UserManage
{
    [DependsOn(
        typeof(UserManageHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class UserManageConsoleApiClientModule : AbpModule
    {
        
    }
}
