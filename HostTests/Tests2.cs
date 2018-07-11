using Host;
using System.Threading.Tasks;
using Xunit;

namespace HostTests
{
    public class Tests2 : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        private readonly CustomWebApplicationFactory<Startup> _factory;

        public Tests2(CustomWebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task Test_A2()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync("Home/Map");

            // Assert
            response.EnsureSuccessStatusCode();  // Status Code 200-299

        }

        [Fact]
        public async Task Test_B2()
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
