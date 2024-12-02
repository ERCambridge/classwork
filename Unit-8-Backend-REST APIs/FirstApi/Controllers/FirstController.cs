using FirstApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstApi.Controllers
{
    [Route("api")]
    [ApiController]

    public class FirstController : ControllerBase
    {
        [HttpGet("/")]
        public IActionResult actionResult()
        {
            return Ok("Welecome to Ethan's Controller");
        }

        [HttpGet("/gambler")]
        public IActionResult getGamblers() 
        {
            GamblerDao newData = new GamblerDao();
            return Ok(newData.getGamblers());
        }

        [HttpGet("/gambler/{id}")]
        public IActionResult getGamblerByID(int id)
        {
            GamblerDao newData = new GamblerDao();
            return Ok(newData.getGamblerByID(id));
        }

        [HttpGet("/findgambler")]
        public IActionResult getGamblerByName(string name)
        {
            GamblerDao newData = new GamblerDao();
            return Ok(newData.getGamblerByName(name));
        }

        [HttpPost("/gambler")]
         
        public IActionResult addGambler(Gambler newGambler)
        {
            GamblerDao newData = new GamblerDao();
            return Ok(newData.addGambler(newGambler));
        }
    }
}
