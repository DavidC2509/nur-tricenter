using Core.Cqrs.Domain;
using Core.Cqrs.Domain.Domain;

namespace Template.Domain.MedicalConsultationAggregate
{
    public class Consultation : BaseEntity, IAggregateRoot
    {
        public string Descripcion { get; set; }
        public bool? Status { get; set; }
        public Guid ClientId { get; set; }
        public Guid IdConsult { get; set; }

        private Consultation()
        {
            Descripcion = string.Empty;
        }

    }
}
