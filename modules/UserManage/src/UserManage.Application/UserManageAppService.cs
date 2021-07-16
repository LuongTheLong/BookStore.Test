using UserManage.Localization;
using Volo.Abp.Application.Services;

namespace UserManage
{
    public abstract class UserManageAppService : ApplicationService
    {
        protected UserManageAppService()
        {
            LocalizationResource = typeof(UserManageResource);
            ObjectMapperContext = typeof(UserManageApplicationModule);
        }
    }
}
