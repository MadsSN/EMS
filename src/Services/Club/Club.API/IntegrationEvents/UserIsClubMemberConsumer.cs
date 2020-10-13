using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EMS.Club_Service.API.Context;
using EMS.Events;
using MassTransit;
using Microsoft.EntityFrameworkCore;
using EMS.TemplateWebHost.Customization.EventService;

namespace EMS.Club_Service.API.Events
{
    public class UserIsClubMemberConsumer :
            IConsumer<UserIsClubMemberEvent>
        {
        private readonly ClubContext _context;
        private readonly IEventService _eventService;

        public UserIsClubMemberConsumer(ClubContext context, IEventService eventService)
        {
            _context = context;
            _eventService = eventService;
        }

        public async Task Consume(ConsumeContext<UserIsClubMemberEvent> context)
            {
            var club = await _context.Clubs.SingleOrDefaultAsync(ci => ci.ClubId == context.Message.ClubId);
            if(club == null)
            {
                return;
            }
            if (club.InstructorIds == null)
            {
                club.InstructorIds = new HashSet<Guid>();
            }

            if (club.InstructorIds.Contains(context.Message.UserId))
            {
                return; 
            }
            club.InstructorIds.Add(context.Message.UserId);
            _context.Clubs.Update(club);
            var @event = new InstructorAddedEvent()
            {
                ClubId = context.Message.ClubId,
                UserId = context.Message.UserId
            };
            await _eventService.SaveEventAndDbContextChangesAsync(@event);
            await _eventService.PublishEventAsync(@event);
        }
        }
    }