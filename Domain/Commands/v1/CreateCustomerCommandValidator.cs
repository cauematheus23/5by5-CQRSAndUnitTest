using FluentValidation;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace Domain.Commands.v1
{
    private readonly BaseDbRepository _connection;
    public class CreateCustomerCommandValidator : AbstractValidator<CreateCustomerCommand>
    {
        private bool IsValidCPF()
        {
            return IsCpf(cpf);
        }

        private async Task<bool> IsUniqueCpf(string cpf, CancellationToken cancellationToken)
        {
            return !await 
        }
        private bool IsCpf(string cpf)
        {
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)
                return false;

            if (!cpf.All(char.IsDigit))
                return false;

            // Verificação dos dígitos verificadores
            int[] multiplierFirst = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplierSecond = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf = cpf.Substring(0, 9);
            int sum = 0;

            for (int i = 0; i < 9; i++)
                sum += int.Parse(tempCpf[i].ToString()) * multiplierFirst[i];

            int remainder = sum % 11;
            int digit1 = remainder < 2 ? 0 : 11 - remainder;

            tempCpf += digit1;
            sum = 0;

            for (int i = 0; i < 10; i++)
                sum += int.Parse(tempCpf[i].ToString()) * multiplierSecond[i];

            remainder = sum % 11;
            int digit2 = remainder < 2 ? 0 : 11 - remainder;

            tempCpf += digit2;

            return cpf.EndsWith(tempCpf.Substring(cpf.Length - 2));
        }

        public CreateCustomerCommandValidator()
        {
            RuleFor(createCustomerCommand => createCustomerCommand.BirthDate)
                .Must(createCustomerCommand => DateTime.Now.Year - createCustomerCommand.Year >= MinimumAge)
                .WithMessage("Idade deve ser maior que 18 anos!"); // TODO colocar essas mensagens em constantes para poder fazer validação no teste

            RuleFor(createCustomerCommand => createCustomerCommand.Name)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("O campo {PropertyName} é obrigatório!")
                .MinimumLength(MinimumNameLength)
                .WithMessage($"O campo {{PropertyName}} deve conter mais que {MinimumNameLength} caracteres!");

            RuleFor(createCustomerCommand => createCustomerCommand.Document)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("O campo {PropertyName} é obrigatório!")
                .Must(x => _onlyNumbers.Replace(x, string.Empty).Length == MinimumDocLength)
                .WithMessage($"O campo {{PropertyName}} deve conter mais que {MinimumDocLength} caracteres!");
        }
    }
}
