﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObject.v1
{
    public record Address(
    string ZipCode,
    string Street,
    string Number,
    string Neighborhood,
    string City,
    string State);
}
