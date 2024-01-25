using MediatR;

namespace mediatr.no.net._6._0
{
    public class ProductSavedNotification : INotification
    {
        public long Id { get; set; }
    }
}
