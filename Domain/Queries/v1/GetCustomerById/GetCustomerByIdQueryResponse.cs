using Domain.ValueObject.v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Queries.v1.GetCustomerById
{
    public class GetCustomerByIdQueryResponse
    {
        public string Name { get; set; }
        public string Document { get; set; }
        public DateTime BirthDate { get; set; }
        public Address? Address { get; set; }
        public string Phone {  get; set; }
        public string Email { get; set; }
        public Guid Id { get; set; }
    }
}
