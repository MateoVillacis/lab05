using Microsoft.AspNetCore.Mvc;

namespace Lab01.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LabController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<LabController> _logger;

        public LabController(ILogger<LabController> logger)
        {
            _logger = logger;
        }
        [HttpGet()]
                [Route("Version")]
                public String Version(){
                return "V14";
                 }


        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
       
        [Route("AppHistory")]
        public string AddHistory()
        {
            _logger.LogInformation("AppHistory");
            try
            {
                var path = "/var/logs";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);    
                }
                var file = $"{path}/{DateTime.Now.ToString("ddMyyyy _MM_mm")}.log";
                System.IO.File.WriteAllText(file,"Log de pruebas"); 
                return "OK";
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error en AddHistory");
                return "Error";
            }
        }
    }
}
