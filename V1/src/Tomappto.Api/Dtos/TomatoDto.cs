using System;
using System.Collections.Generic;
using System.Linq;
using Tomappto.Domain.Aggregates.TomatoAggregate;

namespace Tomappto.Api.Dtos
{
    public class TomatoDto
    {

        public Guid Id { get; set; }

        public string PickedBy { get; set; }

        public DateTime PickedOn { get; set; }


        internal static IEnumerable<TomatoDto> ToDto(IEnumerable<Tomato> tomatoes) 
        {
            if (tomatoes == null) return null;
            return
                tomatoes
                .Select(s => new TomatoDto() { Id = s.Id, PickedBy = s.PickedBy, PickedOn = s.PickedOn })
                .ToList();
        }

    }
}
