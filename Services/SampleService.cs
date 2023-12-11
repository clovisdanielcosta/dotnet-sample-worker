using DotNet.Sample.Worker.Api.Interfaces;

namespace DotNet.Sample.Worker.Api.Services;

public class SampleService : ISampleService
{
    public Task DoWork(CancellationToken stoppingToken)
    {
        // Do Something
        return null;
    }
}
