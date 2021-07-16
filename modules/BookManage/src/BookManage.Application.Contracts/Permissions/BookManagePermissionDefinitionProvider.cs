using BookManage.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace BookManage.Permissions
{
    public class BookManagePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(BookManagePermissions.GroupName, L("Permission:BookManage"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<BookManageResource>(name);
        }
    }
}