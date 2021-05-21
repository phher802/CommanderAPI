using System.Collections.Generic;
using Commander.Data;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{

    [Route("api/commands")]
    [ApiController]
    public class CommandController : ControllerBase
    {
        private readonly MockCommanderRepo _repository = new MockCommanderRepo();

        //GET api/commands
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAppCommands();
            return Ok(commandItems);
            //use ok to return ok 200 
        }

        //GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult<CommandController> GetCommandbyId(int id)
        {
            var commandItem = _repository.GetCommandById(id);
            return Ok(commandItem);

        }
    }
}