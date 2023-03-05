using Microsoft.AspNetCore.Mvc;

namespace CICD.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GoController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public int Get()
        {
            return 0;
        }
    }
}