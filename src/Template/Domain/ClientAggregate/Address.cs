using Core.Cqrs.Domain;
using Core.Cqrs.Domain.Domain;

namespace Template.Domain.ClientAggregate
{
    public class Address : BaseEntity, IAggregateChild<Client>, IAggregateRoot
    {
        public string Street { get; set; }
        public string City { get; set; }
        public decimal Latituded { get; set; }
        public decimal Longitud { get; set; }
        public bool Status { get; set; }
        private Address()
        {
            Street = string.Empty;
            City = string.Empty;
        }
    }
}
