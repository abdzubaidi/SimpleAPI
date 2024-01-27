using Microsoft.Extensions.Logging;

namespace SimpleAPI.Test;

public class UnitTest1
{
    WeatherForecastController controller = new WeatherForecastController();


    [Fact]
    public void GetReturnsMyName() 
    {
        var returnValue = controller.Get();
        Assert.Equal(5, returnValue.Count());
    }

    [Fact]
    public void Test1()
    {

    }
}