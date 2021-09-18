using System.Collections.Generic;
using System.Linq;
using Tomappto.Domain.Aggregates.TomatoAggregate;

namespace Tomappto.Infrastructure.Repositories
{
    public class TomatoesRepository : Domain.Repositories.ITomatoesRepository
    {
        private readonly TomatoesContext context;

        public TomatoesRepository(TomatoesContext context)
        {
            this.context = context;
        }

        public IEnumerable<Tomato> GetTomatoes()
        {
            return context.Tomatoes.ToList();
        }
    }
}
