using Volo.Abp.Reflection;

namespace BookManage.Permissions
{
    public class BookManagePermissions
    {
        public const string GroupName = "BookManage";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(BookManagePermissions));
        }
    }
}