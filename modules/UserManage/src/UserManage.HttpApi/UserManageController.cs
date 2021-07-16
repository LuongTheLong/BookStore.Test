using UserManage.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace UserManage
{
    public abstract class UserManageController : AbpController
    {
        protected UserManageController()
        {
            LocalizationResource = typeof(UserManageResource);
        }
    }
}
