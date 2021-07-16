using Volo.Abp.Reflection;

namespace UserManage.Permissions
{
    public class UserManagePermissions
    {
        public const string GroupName = "UserManage";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(UserManagePermissions));
        }
    }
}