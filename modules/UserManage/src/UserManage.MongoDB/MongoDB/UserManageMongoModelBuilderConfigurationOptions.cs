using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace UserManage.MongoDB
{
    public class UserManageMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public UserManageMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}