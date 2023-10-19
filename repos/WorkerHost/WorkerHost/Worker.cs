using Microsoft.Extensions.Hosting;
using Microsoft.VisualBasic;
using WorkerHost.Controllers;

namespace WorkerHost
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly RemoteWeatherController _controller;

        public Worker(ILogger<Worker> logger, RemoteWeatherController controller)
        {
            _logger = logger;
            _controller = controller;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Write Sometimes");
                string info = Console.ReadLine();
                _logger.LogInformation(info);
                await Task.Delay(1000, stoppingToken);

                if (info == "pippo")
                {
                    string test = await _controller.GetData();
                }
                else
                {
                    Console.WriteLine("male");
                }

                _logger.LogInformation("Worker running at {time}", DateAndTime.Now);
                await Task.Delay(1000, stoppingToken);  

            }
        }
    }
}