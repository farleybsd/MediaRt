using mediatr.no.net._6._0.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace mediatr.no.net._6._0.Controllers
{
    [Route("api/[controller]")]
    public class CommandsController : Controller
    {
        private readonly IMediator _mediator;
        public CommandsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("product")]
        public async Task<IActionResult> PostProductAsync([FromBody] ProductSaveCommand product)
        {
            var command = await _mediator.Send(product);

            return Json(command);
        }
    }
}
