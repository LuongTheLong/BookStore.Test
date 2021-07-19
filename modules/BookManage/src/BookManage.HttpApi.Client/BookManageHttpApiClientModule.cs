using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace BookManage
{
    [DependsOn(
        typeof(BookManageApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class BookManageHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "BookManage";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(BookManageApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
