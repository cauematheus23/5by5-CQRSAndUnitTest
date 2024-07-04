using AutoMapper;
using Domain.Entities.v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Commands.v1
{
    public class CreateCustomerCommandProfile : Profile
    {
        public CreateCustomerCommandProfile()
        {
            CreateMap<CreateCustomerCommand, Customer>()
                .ForMember(fieldOutput => fieldOutput.Document, option => option
                    .MapFrom(input => GetOnlyNumbers(input.Document)));

            CreateMap<Customer, CreateCustomerCommandResponse>();
        }
        public static string GetOnlyNumbers(string text)
        {
            var stringNumber = new String((text ?? string.Empty).Where(Char.IsDigit).ToArray());
            return stringNumber;
        }
    }
}
