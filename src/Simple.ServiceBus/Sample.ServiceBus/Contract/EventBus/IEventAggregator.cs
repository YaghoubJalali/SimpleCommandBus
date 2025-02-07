﻿using Sample.ServiceBus.Contract.EventBus;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sample.ServiceBus.Contract
{
    public interface IEventAggregator
    {
        Task PublishAsync<TEvent>(TEvent eventToPublish) where TEvent : IEvent;

        void SubscribeEventHandler<T,U>() 
            where T : IEventHandler<U>
            where U : IEvent;

        void SubscribeActionHandler<T>() where T : IEvent;
    }
}
