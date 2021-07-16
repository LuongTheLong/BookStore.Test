using UserManage.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace UserManage.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class UserManagePageModel : AbpPageModel
    {
        protected UserManagePageModel()
        {
            LocalizationResourceType = typeof(UserManageResource);
            ObjectMapperContext = typeof(UserManageWebModule);
        }
    }
}