using AutoMapper;
using Domain.Entities.v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Queries.v1.GetCustomerById
{
    public class GetCustomerByIdQueryProfile : Profile
    {
        public GetCustomerByIdQueryProfile()
        {
            CreateMap<Customer, GetCustomerByIdQueryResponse>();
        }
    }
}
