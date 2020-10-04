using HotChocolate;
using MassTransit.ExtensionsDependencyInjectionIntegration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using EMS.Permission_Services.API.Context;
using EMS.Permission_Services.API.GraphQlQueries;
using EMS.Permission_Services.API.Events;
using EMS.Permission_Services.API.Services;
using EMS.TemplateWebHost.Customization.StartUp;



namespace EMS.Permission_Services.API
{
    public class Startup : BaseStartUp<PermissionContext>
    {
        public Startup(IConfiguration configuration) : base(configuration)
        {
        }

        public override void ConfigureMassTransit(IServiceCollectionBusConfigurator busServices)
        {
            busServices.AddConsumer<UserCreatedEventConsumer>();
            busServices.AddConsumer<ClubCreatedEventConsumer>();
        }

        public override IServiceCollection AddServices(IServiceCollection service)
        {
            service.AddSingleton<JwtService>();
            return service;
        }

        public override ISchemaBuilder AddGraphQlServices(ISchemaBuilder builder)
        {
            return builder
                .AddQueryType<PermissionQueries>();
          
        }

        protected override string GetName()
        {
            return "Permission";
        }
    }
}
