using AutoMapper;
using Domain.Contracts.v1;
using Domain.Entities.v1;
using MediatR;


namespace Domain.Commands.v1
{
    public class CreateCustomerCommandHandler(ICustomerRepository repository, IMapper mapper, IDomainNotificationService domainNotification)
    : IRequestHandler<CreateCustomerCommand, CreateCustomerCommandResponse>
    {
        public async Task<CreateCustomerCommandResponse> Handle(
            CreateCustomerCommand request,
            CancellationToken cancellationToken)
        {
            var customer = mapper.Map<CreateCustomerCommand, Customer>(request);
            await repository.AddAsync(customer, cancellationToken);

            return mapper.Map<CreateCustomerCommandResponse>(customer);
        }
    }
}
