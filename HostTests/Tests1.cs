using Host;
using Xunit;
using System.Threading.Tasks;

namespace HostTests
{
    public class Tests1 : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        private readonly CustomWebApplicationFactory<Startup> _factory;

        public Tests1(CustomWebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task Test_A1()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync("Home/Map");

            // Assert
            response.EnsureSuccessStatusCode();  // Status Code 200-299

        }
    }
}
