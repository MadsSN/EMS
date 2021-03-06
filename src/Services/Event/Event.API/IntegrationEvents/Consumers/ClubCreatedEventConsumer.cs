using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AutoMapper;
using EMS.Event_Services.API.Context;
using EMS.Event_Services.API.Context.Model;
using EMS.Events;
using MassTransit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TemplateWebHost.Customization.BasicConsumers;

namespace EMS.Event_Services.API.Events
{

    public class ClubCreatedEventConsumer :
        BasicDuplicateConsumer<EventContext, Club, ClubCreatedEvent>
    {
        public ClubCreatedEventConsumer(EventContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
