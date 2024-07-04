﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.v1
{
    public interface IDomainNotificationService : IDisposable
    {
        bool HasNotification { get; }
        void Add(string message);
        void AddRange(IEnumerable<string> messages);
        IReadOnlyCollection<string>? Get();
    }
}
