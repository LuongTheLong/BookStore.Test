using Localization.Resources.AbpUi;
using UserManage.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace UserManage
{
    [DependsOn(
        typeof(UserManageApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class UserManageHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(UserManageHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<UserManageResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
