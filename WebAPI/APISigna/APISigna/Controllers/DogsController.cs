using APISigna.domain.Commands;
using APISigna.domain.Handles;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISigna.Controllers
{
    [Consumes("application/json")]
    [Produces("application/json")]
    [Route("api/signa/dogs")]
    public class DogsController : BaseController
    {
        private readonly DogsHandler _dogsHandler;

        public DogsController(DogsHandler handler) : base(handler) => _dogsHandler = handler;

        [HttpGet("getDogs")]
        public IActionResult GetDogs()
        {
            var result = _dogsHandler.GetDogs();

            return Response(result);
        }

        [HttpPost("insertDogs")]
        public IActionResult InsertDogs([FromBody] List<DogsCommand> dogsCommand)
        {
            var result = _dogsHandler.InsertDogs(dogsCommand);

            return Response(result);
        }

        [HttpPut("updateDogs")]
        public IActionResult UpdateDogs([FromBody] List<DogsCommand> dogsCommand)
        {
            var result = _dogsHandler.UpdateDogs(dogsCommand);

            return Response(result);
        }

        [HttpDelete("deleteDogs")]
        public IActionResult DeleteDogs([FromBody] List<DogsCommand> dogsCommand)
        {
            var result = _dogsHandler.DeleteDogs(dogsCommand);

            return Response(result);
        }
    }
}
