
using DotNet.Sample.Worker.Api.Interfaces;

namespace DotNet.Sample.Worker.Api.Worker;

public class WorkerSample : BackgroundService
{
    private readonly ISampleService _sampleService;

    public WorkerSample(ISampleService sampleService)
    {
        _sampleService = sampleService;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        new Thread(async () => await _sampleService.DoWork(stoppingToken)).Start();
    }
}
