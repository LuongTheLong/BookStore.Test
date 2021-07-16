using Acme.User.MongoDB;
using Xunit;

namespace Acme.User
{
    [CollectionDefinition(UserTestConsts.CollectionDefinitionName)]
    public class UserApplicationCollection : UserMongoDbCollectionFixtureBase
    {

    }
}
