using WorkerHost.Controllers;

namespace WorkerHost
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IHost host = Host.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    services.AddHostedService<Worker>();
                    services.AddHttpClient("RemoteWeatherHttp",
                        c => c.BaseAddress = new System.Uri("https://api.open-meteo.com/v1"));

                    services.AddTransient<RemoteWeatherController>();
                    
                })
                .Build();
            
                host.RunAsync();
        }
    }
}