using Xunit;
using HelloWorldRSOI;
using Microsoft.AspNetCore.Hosting;
using System.Threading.Tasks;
using Microsoft.AspNetCore.TestHost;

namespace XUnitTest
{
    public class RequestUnitTests
    {
        [Fact]
        public async Task GetRequestTest()
        {
            var hostBuilder = new WebHostBuilder().UseStartup<Startup>();

            using (var server = new TestServer(hostBuilder))
            {
                var response = await server.CreateRequest("/")
                     .SendAsync("GET");

                Assert.Equal(System.Net.HttpStatusCode.OK.ToString(), response.StatusCode.ToString());
            }
        }
    }

}
