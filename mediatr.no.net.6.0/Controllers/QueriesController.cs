using mediatr.no.net._6._0.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

//Para consumir a query, basta injetar a interface IMediator no controller e enviar o objeto de entrada como parâmetro no método Send():
//Para consumir a query, basta injetar a interface IMediator no controller e enviar o objeto de entrada como parâmetro no método Send():

namespace mediatr.no.net._6._0.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QueriesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public QueriesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetProductByIdAsync([FromQuery] ProductByIdQuery product)
        {
            var queryProduct = await _mediator.Send(product);
            return Ok(queryProduct);
        }
    }
}