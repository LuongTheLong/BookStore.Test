using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace BookManage.MongoDB
{
    public static class BookManageMongoDbContextExtensions
    {
        public static void ConfigureBookManage(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new BookManageMongoModelBuilderConfigurationOptions(
                BookManageDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}