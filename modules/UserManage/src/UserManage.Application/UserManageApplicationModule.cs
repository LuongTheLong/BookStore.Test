using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;

namespace UserManage
{
    [DependsOn(
        typeof(UserManageDomainModule),
        typeof(UserManageApplicationContractsModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpAutoMapperModule)
        )]
    public class UserManageApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<UserManageApplicationModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<UserManageApplicationModule>(validate: true);
            });
        }
    }
}
