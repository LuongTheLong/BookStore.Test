using Acme.BookStore.Books;
using Acme.BookStore.Localization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.BookStore.Controllers
{
    /* Inherit your controllers from this class.
     */

    public abstract class BookStoreController : AbpController
    {
        protected BookStoreController(IBookAppService bookAppService)
        {
            LocalizationResource = typeof(BookStoreResource);
           
        }
    }
}