using BookManage.Localization;
using Volo.Abp.Application.Services;

namespace BookManage
{
    public abstract class BookManageAppService : ApplicationService
    {
        protected BookManageAppService()
        {
            LocalizationResource = typeof(BookManageResource);
            ObjectMapperContext = typeof(BookManageApplicationModule);
        }
    }
}
