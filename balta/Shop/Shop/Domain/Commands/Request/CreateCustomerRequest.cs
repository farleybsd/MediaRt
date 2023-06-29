using MediatR;
using Microsoft.AspNetCore.Http.Features;
using Shop.Domain.Commands.Response;

namespace Shop.Domain.Commands.Request
{
    public class CreateCustomerRequest : IRequest<CreateCustomerResponse> // retorno
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
