using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shop.Domain.Commands.Request;
using Shop.Domain.Commands.Response;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    [ApiController]
    [Route("v1/customers")]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public Task<CreateCustomerResponse> Create(
            [FromServices] IMediator mediator,
            [FromBody] CreateCustomerRequest command)
        {
            return mediator.Send(command);
        }
    }
}
