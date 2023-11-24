using MassTransit;

/// <summary>
/// Consumer for demo purposes
/// </summary>
internal class WeatherForecastConsumer : IConsumer<WeatherForecast>
{
    public Task Consume(ConsumeContext<WeatherForecast> context)
    {
        var weatherForecast = context.Message;
        Console.WriteLine($"Received weather forecast: {weatherForecast.Date} - {weatherForecast.Summary}");
        return Task.CompletedTask;
    }
}