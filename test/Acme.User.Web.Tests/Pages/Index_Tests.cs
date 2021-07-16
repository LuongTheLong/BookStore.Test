using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Acme.User.Pages
{
    [Collection(UserTestConsts.CollectionDefinitionName)]
    public class Index_Tests : UserWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
