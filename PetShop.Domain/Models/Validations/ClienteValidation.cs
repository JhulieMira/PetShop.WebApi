using FluentValidation;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static PetShop.Domain.Models.Validations.Documentos.ValidacaoDoc;

namespace PetShop.Domain.Models.Validations
{
    public class ClienteValidation : AbstractValidator<Cliente>
    {
        public ClienteValidation() 
        { 
            RuleFor(x => x.Nome)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 100)
                .WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .EmailAddress().WithMessage("O campo {PropertyName}, não é válido");

            RuleFor(x => x.Endereco)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");

            RuleFor(c => c.DataNascimento)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Must(BeAValidDate).WithMessage("O campo {PropertyName} precisa ser válido e estar no mesmo formato que o exemplo: 25/01/2000");

            RuleFor(c => c.NumeroCelular)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Must(BeAValidPhoneNumber).WithMessage("O campo {PropertyName} precisa ser válido e estar no mesmo formato que o exemplo: (11) 90000-0000");

            RuleFor(f => f.Cpf.Length).Equal(CpfValidacao.TamanhoCpf)
                .WithMessage("O campo Documento precisa ter {ComparisonValue} caracteres e foi fornecido {PropertyValue}.");
            RuleFor(f => CpfValidacao.Validar(f.Cpf)).Equal(true)
                .WithMessage("O documento fornecido é inválido.");

        }
        private bool BeAValidDate(DateTime dataNascimento)
        {
            return DateTime.TryParseExact(dataNascimento.ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _);
        }

        private bool BeAValidPhoneNumber(string phoneNumber)
        {
            Regex phoneRegex = new Regex(@"^\(\d{2}\) \d{5}-\d{4}$");
            return phoneRegex.IsMatch(phoneNumber);
        }
    }
}
