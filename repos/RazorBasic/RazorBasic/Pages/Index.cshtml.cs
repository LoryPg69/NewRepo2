using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorBasic.NewFolder.NewFolder;
using System.Text.Json;

namespace RazorBasic.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public List<SurveyItem> SurveyResult { get; set; }  

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var rawJson = System.IO.File.ReadAllText("wwwroot/sampledata/survey.json");

            SurveyResult = JsonSerializer.Deserialize<List<SurveyItem>>(rawJson);
        }
    }
}