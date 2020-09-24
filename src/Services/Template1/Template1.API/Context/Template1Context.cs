using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Template1.API.Context.EntityConfigurations;
using TemplateWebHost.Customization.Context;

namespace Template1.API.Context
{
    using Model;
    public class Template1Context : Base1Context<Template1Context>
    {
        public Template1Context(DbContextOptions<Template1Context> options) : base(options)
        {
        }
        public DbSet<Template1> Template1s { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new Template1EntityTypeConfiguration());
        }
    }


    public class Template1ContextDesignFactory : IDesignTimeDbContextFactory<Template1Context>
    {
        public Template1Context CreateDbContext(string[] args)
        {
            var optionsBuilder =  new DbContextOptionsBuilder<Template1Context>()
                .UseSqlServer("Server=.;Initial Catalog=Microsoft.eShopOnContainers.Services.Template1Db;Integrated Security=true");

            return new Template1Context(optionsBuilder.Options);
        }
    }
}