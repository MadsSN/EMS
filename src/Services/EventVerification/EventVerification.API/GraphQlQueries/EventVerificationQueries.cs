using System;
using System.Linq;
using System.Threading.Tasks;
using EMS.Club_Service_Services.API;
using EMS.EventVerification_Services.API.Context;
using EMS.EventVerification_Services.API.Context.Model;

namespace EMS.EventVerification_Services.API.GraphQlQueries
{
    public class EventVerificationQueries
    {
        private readonly EventVerificationContext _context;
        public EventVerificationQueries(EventVerificationContext context)
        {
            _context = context;
        }

        public IQueryable<EventVerification> EventVerifications => _context.EventVerifications.AsQueryable();

        public IQueryable<EventVerification> EventsForUser(Guid userId) => _context.EventVerifications.Where(eventVerification => eventVerification.UserId == userId).AsQueryable();


        public IQueryable<EventVerification> Participants(Guid eventId) => _context.EventVerifications.Where(eventVerification => eventVerification.EventId == eventId).AsQueryable();

        public IQueryable<EventVerification> VerifiedParticipants(Guid eventId) => _context.EventVerifications.Where(
            eventVerification => eventVerification.EventId == eventId
        && eventVerification.Status == PresenceStatusEnum.Attend).AsQueryable();

    }
}
