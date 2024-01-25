// Já o command segue a linha de ser uma ação de manutenção na base, que na sua essência não retorna alguma informações. Nesse caso utilizamos o notification para gerar eventos, como por exemplo, ao final das ações de gravação no banco de dados é necessário notificar que um produto foi cadastrado, e também é necessário enviar um e-mail para o cliente responsável, conforme o código abaixo:

using MediatR;

namespace mediatr.no.net._6._0.Commands
{
    // Passo 1
    public class ProductSaveCommand : IRequest<string>
    {
        public long Id { get; set; }
        public string Description { get; set; }
    }

    // Passso 2
    public class ProductSaveCommandHandler : IRequestHandler<ProductSaveCommand,string>
    {
        private readonly IMediator _mediator;
        public ProductSaveCommandHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<string> Handle(ProductSaveCommand request, CancellationToken cancellationToken)
        {
            //insert product in database
            Serilog.Log.Information($"Product saved successfully. Id: {request.Id}");
            await _mediator.Publish(new ProductSavedNotification { Id = request.Id }, cancellationToken);
            await _mediator.Publish(new SendEmailNotification { Email = "test@mail.com" }, cancellationToken);
            return await Task.FromResult("Ok");
        }
    }
}
