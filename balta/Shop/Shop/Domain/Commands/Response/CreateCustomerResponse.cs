using System;

namespace Shop.Domain.Commands.Response
{
    public class CreateCustomerResponse
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
    }
}
