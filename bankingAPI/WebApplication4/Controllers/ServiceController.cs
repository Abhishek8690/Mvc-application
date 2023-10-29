using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Container;
using WebApplication4.Services;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private IServiceInterface serv;

        public ServiceController(IServiceInterface serv)
        {
            this.serv = serv;
        }
        ImplementClass implement = new ImplementClass();

      
    }
}
