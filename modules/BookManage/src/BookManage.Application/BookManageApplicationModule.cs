using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;

namespace BookManage
{
    [DependsOn(
        typeof(BookManageDomainModule),
        typeof(BookManageApplicationContractsModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpAutoMapperModule)
        )]
    public class BookManageApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<BookManageApplicationModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<BookManageApplicationModule>(validate: true);
            });
        }
    }
}
