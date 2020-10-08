using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Grpc.Core;
using HotChocolate;

namespace EMS.Event_Services.API.Context.Model
{
    public class Event : IValidatableObject
    {
        public Guid EventId { get; set; }

        public Guid ClubId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public EventStatus Status { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public List<ClubSubscriptionEventPrice> SubscriptionEventPrices { get; set; }

        public List<RoomEvent> Locations { get; set; }

        public List<InstructorForEvent> InstructorForEvents { get; set; }

        public Event()
        {
            Status = EventStatus.Pending;
        }
        public IEnumerable<ValidationResult> Validate([Service] ValidationContext validationContext)
        {
            yield break;
        }
    }

    public enum EventStatus
    {
        Pending,
        Confirmed,
        Failed
    }
}
