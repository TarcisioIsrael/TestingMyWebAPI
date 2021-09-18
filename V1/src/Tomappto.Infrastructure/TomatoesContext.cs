using Microsoft.EntityFrameworkCore;
using Tomappto.Domain.Aggregates.TomatoAggregate;

namespace Tomappto.Infrastructure
{
    public class TomatoesContext:DbContext
    {

        public static string DefaultSchema = "Tomappto";

        public DbSet<Tomato> Tomatoes { get; set; }


        public TomatoesContext(DbContextOptions<TomatoesContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EntityConfigurations.TomatoEntityConfiguration());
        }


    }
}
