using System;
using System.Threading.Tasks;
using EMS.BuildingBlocks.EventLogEF;

namespace TemplateWebHost.Customization.EventService
{
    public interface IEventService
    {
        Task SaveEventAndDbContextChangesAsync(Event evt, Func<Task> action = null);
        Task PublishThroughEventBusAsync<T>(T evt) where T : Event;
        Task SaveContextThenPublishEvent(Event evt, Func<Task> action = null);
    }
}
