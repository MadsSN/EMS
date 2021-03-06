using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using EMS.BuildingBlocks.EventLogEF;

namespace EMS.TemplateWebHost.Customization.EventService
{
    /// <summary>
    /// Based on: https://github.com/dotnet-architecture/eShopOnContainers
    /// </summary>
    public interface IEventService
    {
        Task SaveEventAndDbContextChangesAsync(Event evt, Func<Task> action = null);
        Task PublishEventAsync<T>(T evt, Type type = null) where T : Event;
        Task SaveContextThenPublishEvent(Event evt, Func<Task> action = null);

        Task SaveEventAndDbContextChangesAsync(IEnumerable<Event> events);
    }
}
