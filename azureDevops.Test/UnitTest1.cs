using System;
using Xunit;
using azureDevops.Controllers;
using Microsoft.Extensions.Logging;
using Moq;


namespace azureDevops.Test
{
    public class UnitTest1
    {
        [Fact]
        public void GetReturns5Weathercasts()
        {
            var mock = new Mock<ILogger<WeatherForecastController>>();
            WeatherForecastController weatherForecastController = new WeatherForecastController(mock.Object);

            var returnValue = weatherForecastController.Get();

            Assert.Equal(5, returnValue.Count);
        }


        [Fact]
        public void Test1()
        {

        }
    }
}
