using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public string[] GetDishes()
        {
            string[] Dishes = { "kadhai paneer", "gulab jamun", "rabdi" };
            return Dishes;
        }

        [HttpGet]
        [Route("GetSummoner")]
        public string[] GetData()
        {
            string[] Data = { "abhishek", "singh" };
            return Data;
        }

        [HttpPost]
        public ActionResult CreateNewRecipe(string newRecipe)
        {
            bool BadThingsHappened = false;
            if (BadThingsHappened)
                return BadRequest();
            return Created("", newRecipe);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteReciepie(string id)
        {
            bool BadThingsHappened = false;

            if(BadThingsHappened)
            
               return BadRequest();
            return NoContent();

        }
        
    }
}
