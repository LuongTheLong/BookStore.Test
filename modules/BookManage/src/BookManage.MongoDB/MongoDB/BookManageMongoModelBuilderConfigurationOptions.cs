using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace BookManage.MongoDB
{
    public class BookManageMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public BookManageMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}