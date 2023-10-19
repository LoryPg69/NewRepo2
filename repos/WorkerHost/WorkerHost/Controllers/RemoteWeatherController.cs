using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerHost.Controllers
{
    public class RemoteWeatherController
    {
        private readonly ILogger<RemoteWeatherController> _logger;
        private readonly HttpClient _rw;

        public RemoteWeatherController(ILogger<RemoteWeatherController> logger, IHttpClientFactory factory)
        {
            _logger = logger;
            _rw = factory.CreateClient("RemoteWeatherHttp");
        }

        public async Task<string> GetData()
        {
            if (_rw.BaseAddress == null)
            {
                return "not address to connect";
            }

            Uri url = new Uri(_rw.BaseAddress, "forecast?latitude=52.52&longitude=13.41&current=temperature_2m,windspeed_10m&hourly=temperature_2m,relativehumidity_2m,windspeed_10m");
            HttpResponseMessage res = await _rw.GetAsync(url);

            if (res.IsSuccessStatusCode)
            {
                return $"{Convert.ToInt32(res.StatusCode)}, we gwt some problem";
            }

            var weather = await res.Content.ReadAsStringAsync();
            

            return weather;

        }

    }
}
