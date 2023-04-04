using MediatR;

namespace AspNet_MediatR1.Domain.Command
{
    public class ProdutoCreateCommand : IRequest<string>
    {
        public string Nome { get;  set; }
        public decimal Preco { get;  set; }
    }
}
