using Microsoft.AspNetCore.Mvc;

namespace API_dotnet8_docker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VariableController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get() =>
            Ok(Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT"));
       
    }
}
