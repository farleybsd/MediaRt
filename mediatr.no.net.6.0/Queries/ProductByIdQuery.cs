//No exemplo abaixo, temos uma query que recebe um objeto de entrada (ProductByIdQuery)
//que é implementado com a interface IRequest, onde é informado o tipo de objeto de saí(ProductByIdQueryResult).


//O Handler(ProductByIdQueryHandler) é implementado utilizando a interface IRequestHandler onde é informado o objeto de entrada e saída IRequestHandler<ProductByIdQuery, ProductByIdQueryResult>: 

using MediatR;

namespace mediatr.no.net._6._0.Queries
{
    // Request Input
    // Passso 1
    public class ProductByIdQuery : IRequest<ProductByIdQueryResult> // Inormamos a entrada e a saida de objetos
    {
        public long Id { get; set; }
    }

    // Response OutPut
    // Passso 2
    public class ProductByIdQueryResult
    {
        public long Id { get; set; }
        public string Description { get; set; }
    }

    // Implementacao
    // Passso 3
    public class ProductByIdQueryHandler : IRequestHandler<ProductByIdQuery, ProductByIdQueryResult>
    {
        public async Task<ProductByIdQueryResult> Handle(ProductByIdQuery request, CancellationToken cancellationToken)
        {
            //query in database

            return await Task.FromResult(new ProductByIdQueryResult
            { Id = request.Id,
              Description = $"Description {request.Id}" 
            });
        }
    }
}
