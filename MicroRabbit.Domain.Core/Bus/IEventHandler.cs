using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Domain.Core.Bus
{
    //This event handler takes any type of event
    public interface IEventHandler<in TEvent> : IEventHandler
        where TEvent : Event//and with restriction where the event that coming in has to be type of Event
    {
        Task Handle(TEvent @event);
    }

    public interface IEventHandler
    {

    }
}
