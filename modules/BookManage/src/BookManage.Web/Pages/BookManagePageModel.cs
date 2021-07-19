using BookManage.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace BookManage.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class BookManagePageModel : AbpPageModel
    {
        protected BookManagePageModel()
        {
            LocalizationResourceType = typeof(BookManageResource);
            ObjectMapperContext = typeof(BookManageWebModule);
        }
    }
}