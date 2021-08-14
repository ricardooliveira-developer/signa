using APISigna.domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISigna.Controllers
{
    public class BaseController : Controller
    {
        private readonly IHandler _handler;

        protected BaseController(IHandler handler)
        {
            _handler = handler;
        }

        protected new IActionResult Response(object result)
        {
            var notifications = _handler?.Notifications();

            if (notifications?.Count == 0)
            {
                return Ok(result);
            }

            return BadRequest(notifications);
        }
    }
}
