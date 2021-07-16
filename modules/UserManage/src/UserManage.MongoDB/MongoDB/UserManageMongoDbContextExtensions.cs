using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace UserManage.MongoDB
{
    public static class UserManageMongoDbContextExtensions
    {
        public static void ConfigureUserManage(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new UserManageMongoModelBuilderConfigurationOptions(
                UserManageDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}