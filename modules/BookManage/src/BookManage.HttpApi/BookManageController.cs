using BookManage.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace BookManage
{
    public abstract class BookManageController : AbpController
    {
        protected BookManageController()
        {
            LocalizationResource = typeof(BookManageResource);
        }
    }
}
