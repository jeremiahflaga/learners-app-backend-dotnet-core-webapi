using LearnersApp.WebApi;
using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace LearnersApp.FunctionalTests
{
	// Test ASP.NET Core MVC apps: https://docs.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/test-asp-net-core-mvc-apps
	public class WeatherForecastController : IClassFixture<WebApplicationFactory<Startup>>
	{
		protected readonly HttpClient httpClient;

		public WeatherForecastController(WebApplicationFactory<Startup> factory)
		{
			httpClient = factory.CreateClient();
		}

		[Fact]
		public async Task returns_weather_forecast()
		{
			// Arrange & Act
			var response = await httpClient.GetAsync("/WeatherForecast/");
			response.EnsureSuccessStatusCode();
			var stringResponse = await response.Content.ReadAsStringAsync();

			// Assert
			Assert.True(stringResponse.Length> 0);
		}
	}
}
