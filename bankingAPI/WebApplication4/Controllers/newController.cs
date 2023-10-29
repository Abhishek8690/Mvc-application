using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class newController : ControllerBase
    {
        [HttpGet]
        public int get()
        {
            return 2;
        }
    }
}
