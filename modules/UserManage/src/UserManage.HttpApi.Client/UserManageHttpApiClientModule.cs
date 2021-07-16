using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace UserManage
{
    [DependsOn(
        typeof(UserManageApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class UserManageHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "UserManage";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(UserManageApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
