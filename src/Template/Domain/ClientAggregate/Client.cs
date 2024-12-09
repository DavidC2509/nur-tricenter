using Core.Cqrs.Domain;
using Core.Cqrs.Domain.Domain;

namespace Template.Domain.ClientAggregate
{
    public class Client : BaseEntity, IAggregateRoot
    {
        public string Name { get; set; }
        public string? Phone { get; set; }
        public string Email { get; set; }
        public string EmailAddres { get; set; }

        private Client()
        {
            Name = string.Empty;
            Email = string.Empty;
            EmailAddres = string.Empty;
        }
    }
}
