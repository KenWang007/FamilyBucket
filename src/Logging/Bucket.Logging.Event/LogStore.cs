﻿using Bucket.EventBus.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bucket.Logging.Events
{
    public class LogStore : ILogStore
    {
        private readonly IEventBus _eventBus;
        public LogStore(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public void Post(LogInfo logs)
        {
            _eventBus.Publish(new LogEvent(logs));
        }
    }
}
