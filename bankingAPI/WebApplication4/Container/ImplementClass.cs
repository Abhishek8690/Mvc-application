
using WebApplication4.Services;

namespace WebApplication4.Container
{
    public class ImplementClass : IServiceInterface
    {
        public string display_details()
        {
            return "hello implemented";
        }
    }
}
