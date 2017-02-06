using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Xunit;
using Calc;

public class CalculatorControllerTests
{
    private readonly TestServer _server;
    private readonly HttpClient _client;
    public CalculatorControllerTests()
    {
        // Arrange
        _server = new TestServer(new WebHostBuilder()
            .UseStartup<Startup>());
        _client = _server.CreateClient();
    }

    private async Task<string> GetAddResult(
        int a, int b)
    {
        var request = "/calc/add/"+a+"/"+b;
        var response = await _client.GetAsync(request);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    [Fact]
    public async Task TestRestCalc()
    {
        // Act
        var responseString = await GetAddResult(8,4);

        // Assert
        Assert.Equal("12", responseString);
    }
}