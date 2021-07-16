using Localization.Resources.AbpUi;
using BookManage.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace BookManage
{
    [DependsOn(
        typeof(BookManageApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class BookManageHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(BookManageHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<BookManageResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
