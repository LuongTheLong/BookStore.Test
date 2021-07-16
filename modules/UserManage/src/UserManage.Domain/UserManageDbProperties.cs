namespace UserManage
{
    public static class UserManageDbProperties
    {
        public static string DbTablePrefix { get; set; } = "UserManage";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "UserManage";
    }
}
