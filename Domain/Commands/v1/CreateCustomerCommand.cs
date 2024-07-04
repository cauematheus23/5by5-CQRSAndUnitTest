using Domain.ValueObject.v1;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Commands.v1
{
    public class CreateCustomerCommand : IRequest<GetCustomerByIdQueryResponse>
    {
        public string Name { get; set; } = string.Empty;
        public string Document { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public Address? Address { get; set; }
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}
