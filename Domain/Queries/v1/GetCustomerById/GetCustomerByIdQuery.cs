using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Queries.v1.GetCustomerById
{
    public class GetCustomerByIdQuery(Guid Id) : IRequest<GetCustomerByIdQueryResponse>
    {
        public Guid Id { get; set; } = Id;
    }
}
