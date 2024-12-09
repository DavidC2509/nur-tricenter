using Core.Cqrs.Domain;
using Core.Cqrs.Domain.Domain;

namespace Template.Domain.RequestChangeAggregate
{
    public class RequestChangeHistory : BaseEntity, IAggregateRoot
    {
        public Guid IdAppointment { get; set; }
        public Guid IdClient { get; set; }

        public DateTime PreviusDate { get; set; }
        public DateTime NewDate { get; set; }
        public bool Status { get; set; }
        public DateTime RegisterDate { get; set; }

    }
}
