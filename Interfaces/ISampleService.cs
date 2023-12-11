namespace DotNet.Sample.Worker.Api.Interfaces;

public interface ISampleService
{
    Task DoWork(CancellationToken stoppingToken);
}
