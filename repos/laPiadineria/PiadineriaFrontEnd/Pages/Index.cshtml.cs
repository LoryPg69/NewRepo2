using laPiadineria.Data.Model;
using laPiadineria.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace PiadineriaFrontEnd.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public List<ProductModel> Product { get; set; }

        public List<PiadinaModel> Piadina { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var rawJson = System.IO.File.ReadAllText("wwwroot/sampledata/survey.json");
            Product = JsonSerializer.Deserialize<List<ProductModel>>(rawJson);

            var rawJson1 = System.IO.File.ReadAllText("wwwroot/sampledata/piadine.json");
            Piadina = JsonSerializer.Deserialize<List<PiadinaModel>>(rawJson1);
        }
    }
}