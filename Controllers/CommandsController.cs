using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{

    [Route("api/commands")]
    [ApiController]
    public class CommandController : ControllerBase
    {

        //GET api/commands
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {

        }

        //GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult<CommandController> GetCommandbyId(int id)
        {


        }
    }
}