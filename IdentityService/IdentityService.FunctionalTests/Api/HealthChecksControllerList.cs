//using System.Net.Http;
//using System.Threading.Tasks;
//using IdentityService.UnitTests;
//using IdentityService.WebApi;
//using Xunit;

//namespace IdentityService.FunctionalTests.Api
//{
//    public class HealthChecksControllerList : IClassFixture<CustomWebApplicationFactory<Startup>>
//    {
//        private readonly HttpClient _client;

//        public HealthChecksControllerList(CustomWebApplicationFactory<Startup> factory)
//        {
//            _client = factory.CreateClient();
//        }

//        [Fact]
//        public async Task EnsureSuccessOk()
//        {
//            var response = await _client.GetAsync("/api/HealthChecks");
//            Assert.True(response.EnsureSuccessStatusCode().IsSuccessStatusCode);
//        }

//        [Fact]
//        public void ReturnsSameObject()
//        {
//            //Assert.IsType<List<DecisionTree>>(SeedData.decisionTree);
//        }
//    }
//}
