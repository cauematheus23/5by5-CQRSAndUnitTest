﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.v1
{
    public class Response
    {
        public object? Content { get; init; }
        public static long Timestamp => new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
        public string? TraceId { get; set; }
        public IReadOnlyList<string> Notifications { get; set; } = new List<string>();
        public static Response None => new();
    }
}
