﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Commands.v1
{
    public class CreateCustomerCommandResponse
    {
        public string Name { get; set; } = string.Empty;
        public Guid Id { get; set; }
    }
}