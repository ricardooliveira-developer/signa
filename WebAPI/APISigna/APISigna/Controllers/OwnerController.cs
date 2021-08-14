using APISigna.domain.Handles;
using Microsoft.AspNetCore.Mvc;

namespace APISigna.Controllers
{
    [Consumes("application/json")]
    [Produces("application/json")]
    [Route("api/signa/owner")]
    public class OwnerController : BaseController
    {
        private readonly OwnerHandler _ownerHandler;
        public OwnerController(OwnerHandler handler) : base(handler) => _ownerHandler = handler;

        [HttpGet("getOwner")]
        public IActionResult GetOwner()
        {
            var result = _ownerHandler.GetOwner();

            return Response(result);
        }
    }
}
