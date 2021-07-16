using Xunit;

namespace Acme.User.MongoDB
{
    [CollectionDefinition(UserTestConsts.CollectionDefinitionName)]
    public class UserMongoCollection : UserMongoDbCollectionFixtureBase
    {

    }
}
