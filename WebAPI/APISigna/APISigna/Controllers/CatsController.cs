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
    [Route("api/signa/cats")]
    public class CatsController : BaseController
    {
        private readonly CatsHandler _catsHandler;

        public CatsController(CatsHandler handler) : base(handler) => _catsHandler = handler;

        [HttpGet("getCats")]
        public IActionResult GetCats()
        {
            var result = _catsHandler.GetCats();

            return Response(result);
        }

        [HttpPost("insertCats")]
        public IActionResult InsertCats([FromBody] List<CatsCommand> catsCommand)
        {
            var result = _catsHandler.InsertCats(catsCommand);

            return Response(result);
        }

        [HttpPut("updateCats")]
        public IActionResult UpdateCats([FromBody] List<CatsCommand> catsCommand)
        {
            var result = _catsHandler.UpdateCats(catsCommand);

            return Response(result);
        }

        [HttpDelete("deleteCats")]
        public IActionResult DeleteCats([FromBody] List<CatsCommand> catsCommand)
        {
            var result = _catsHandler.DeleteCats(catsCommand);

            return Response(result);
        }
    }
}
