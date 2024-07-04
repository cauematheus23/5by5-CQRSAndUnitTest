using Domain.Contracts.v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.v1
{
    public sealed class Customer : IEntity<Guid>
    {
        public Customer()
        {
            Id = Guid.NewGuid();
        }

        public string Name { get; set; }
        public string Document { get; set; }
        public DateTime BirthDate { get; set; }
        public Address? Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Guid Id { get; set; }

    }
}
