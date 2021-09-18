using System;

namespace Tomappto.Domain.Aggregates.TomatoAggregate
{
    public class Tomato
    {
        private Tomato()
        {

        }

        public Tomato( DateTime pickedOn , string pickedBy )
        {
            PickedOn = pickedOn;
            PickedBy = pickedBy;
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }

        public DateTime PickedOn { get; private set; }
        public string PickedBy { get; private set;  }
    }
}
