using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace BookManage
{
    [DependsOn(
        typeof(BookManageHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class BookManageConsoleApiClientModule : AbpModule
    {
        
    }
}
