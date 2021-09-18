using System.Collections.Generic;
using Tomappto.Domain.Aggregates.TomatoAggregate;

namespace Tomappto.Domain.Repositories
{
    public interface ITomatoesRepository
    {

        IEnumerable<Tomato> GetTomatoes();

    }
}
