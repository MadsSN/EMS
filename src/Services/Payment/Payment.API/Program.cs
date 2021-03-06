using EMS.BuildingBlocks.EventLogEF;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using EMS.Payment_Services.API.Context;
using EMS.TemplateWebHost.Customization;
using EMS.TemplateWebHost.Customization.Settings;
using EMS.TemplateWebHost.Customization.StartUp;

namespace EMS.Payment_Services.API
{

    public class ProgramHelper : BaseProgramHelper<Startup>
    {
        public ProgramHelper(string appName) : base(appName)
        {
        }

        public override void MigrateDbContext(IWebHost host)
        {
            host.MigrateDbContext<PaymentContext>((context, services) =>
                {
                })
                .MigrateDbContext<EventLogContext>((context, services) => { });
        }
    }

    public class Program
    {

        public static string AppName = "Payment.API";
        public static int Main(string[] args)
        {
            return new ProgramHelper(AppName).Run(args);
        }
    }
}
