//Ao chamar o método Publish() passando o objeto de entrada do evento, um handler com a implementação de um ou vários INotificationHandler, recebe e processa a mensagem:

using MediatR;
using Serilog;

namespace mediatr.no.net._6._0.Notifications
{
    public class ProductSavedNotificationHandler : INotificationHandler<ProductSavedNotification>,
                                                   INotificationHandler<SendEmailNotification>
    {
        public Task Handle(ProductSavedNotification notification, CancellationToken cancellationToken)
        {
            return Task.Run(() => Log.Information($"Successful product event. Id: {notification.Id}"));
        }

        public Task Handle(SendEmailNotification notification, CancellationToken cancellationToken)
        {
            return Task.Run(() => Log.Information($"Successful email event. To: {notification.Email}"));
        }
    }
}
