﻿using Core.Cqrs.Domain;
using Core.Cqrs.Domain.Domain;

namespace Template.Domain.MedicalConsultationAggregate
{
    public class HistoryConsultation : BaseEntity, IAggregateChild<Consultation>
    {
        public string Value { get; set; }
        public string Field { get; set; }

        private HistoryConsultation()
        {
            Value = string.Empty;
            Field = string.Empty;
        }
    }
}
