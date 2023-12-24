using Microsoft.AspNetCore.Mvc;

namespace GenericController.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Health : ControllerBase
    {
        [HttpGet]
        public async Task<string> Get()
        {
            return "ok";
        }
    }
}