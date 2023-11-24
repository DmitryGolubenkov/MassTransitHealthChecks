using Confluent.Kafka;
using Confluent.Kafka.Admin;
using MassTransit;
using Microsoft.Extensions.Diagnostics.HealthChecks;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMassTransit(bus =>
{
    bus.ConfigureHealthCheckOptions(options =>
    {
        options.FailureStatus = HealthStatus.Healthy;
    });

    bus.AddHealthChecks();

    bus.AddConsumer<WeatherForecastConsumer>();

    // 1. Add rabbitMQ consumer
    bus.UsingRabbitMq((context, cfg) =>
    {
        cfg.Host("localhost", 9999, "/", h =>
        {
            h.Username("guest");
            h.Password("guest");
        });

        cfg.ReceiveEndpoint("weather-forecast", e =>
        {
            e.ConfigureConsumer<WeatherForecastConsumer>(context);
        });
    });

    // 2. Add Kafka consumer using rider.
   bus.AddRider(rider =>
    {
        rider.AddConsumer<WeatherForecastConsumer>();

        rider.UsingKafka((context, k) =>
        {
            k.Host("localhost:9094");

            k.TopicEndpoint<WeatherForecast>("weather-forecast", "weather-forecast", e =>
            {
                e.ConfigureConsumer<WeatherForecastConsumer>(context);
            });
        });

    });


    // For Kafka
    //bus.UsingInMemory((context, cfg) =>
    //{
    //    cfg.ConfigureEndpoints(context);
    //});
});

// Add health checks
builder.Services.AddHealthChecks();

var app = builder.Build();

#region Create Kafka Topic

// So that kafkaconsumer doesn't report unhealthy because of topic
using var adminClient = new AdminClientBuilder(new AdminClientConfig { BootstrapServers = "localhost:9094" }).Build();
try
{
    await adminClient.CreateTopicsAsync(new TopicSpecification[]
    {
    new TopicSpecification { Name = "weather-forecast", ReplicationFactor = 1, NumPartitions = 1 }
    });
}
catch (CreateTopicsException e)
{
    Console.WriteLine($"An error occured creating topic {e.Results[0].Topic}: {e.Results[0].Error.Reason}");
}

#endregion

app.UseHealthChecks("/health");


app.Run();
