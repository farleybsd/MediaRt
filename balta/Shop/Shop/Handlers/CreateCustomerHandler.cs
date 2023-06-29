using MediatR;
using Shop.Domain.Commands.Request;
using Shop.Domain.Commands.Response;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Shop.Handlers
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest,CreateCustomerResponse>
    {
        Task<CreateCustomerResponse> IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>.Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            // Verifica se o cliente esta cadastrado
            // Valida os dados
            // Insere o Cliente
            // Envia o E-mail de Boas Vindas

            var result = new CreateCustomerResponse { 
                id = Guid.NewGuid(),
                Name= "Farley Rufino",
                Email ="Rufino Dev",
                Date= DateTime.Now
            };

            return Task.FromResult(result);
        }
    }
}
