namespace BookManage
{
    public static class BookManageDbProperties
    {
        public static string DbTablePrefix { get; set; } = "BookManage";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "BookManage";
    }
}
