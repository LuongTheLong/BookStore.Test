using UserManage.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace UserManage.Permissions
{
    public class UserManagePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(UserManagePermissions.GroupName, L("Permission:UserManage"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<UserManageResource>(name);
        }
    }
}