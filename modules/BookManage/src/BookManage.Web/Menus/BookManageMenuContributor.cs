using BookManage.Localization;
using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace BookManage.Web.Menus
{
    public class BookManageMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            var l = context.GetLocalizer<BookManageResource>();
            //Add main menu items.
            context.Menu.AddItem(
                new ApplicationMenuItem(BookManageMenus.Prefix, displayName: "BookManage", "~/BookManage", icon: "fa fa-archive").AddItem(
        new ApplicationMenuItem(
            "BookManage.BooksManages",
            l["Menu:BooksManages"],
            url: "/BooksManages"
        )
    ));


            return Task.CompletedTask;
        }
    }
}