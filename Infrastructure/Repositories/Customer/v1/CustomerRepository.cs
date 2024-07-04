using Domain.Contracts.v1;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Customer.v1
{
    public class CustomerRepository(IMongoClient client) : BaseDbRepository<Domain.Entities.v1.Customer, Guid>(client), ICustomerRepository;
}
