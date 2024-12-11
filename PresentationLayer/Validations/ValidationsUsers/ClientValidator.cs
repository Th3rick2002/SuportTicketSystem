using CommonLayer.Entities;
using FluentValidation;

namespace PresentationLayer.Validations.ValidationsUsers
{
    public class ClientValidator : AbstractValidator<Client>
    {
        public ClientValidator()
        {
            RuleLevelCascadeMode = CascadeMode.Stop;

            RuleFor(client => client.FirstName)
                .NotEmpty().WithMessage("El nombre es obligatorio")
                .Length(2, 50).WithMessage("El nombre debe tener entre 2 y 50 caracteres")
                .Matches("^[a-zA-Z]+$").WithMessage("El apellido del agente solo puede contener letras.");

            RuleFor(client => client.LastName)
                .NotEmpty().WithMessage("El apellido es obligatorio")
                .Length(2, 50).WithMessage("El apellido debe tener entre 2 y 50 caracteres")
                .Matches("^[a-zA-Z]+$").WithMessage("El apellido del agente solo puede contener letras.");

            RuleFor(client => client.Email)
                .NotEmpty().WithMessage("El correo es obligatorio")
                .EmailAddress().WithMessage("El correo debe tener un formato válido");

            RuleFor(client => client.Password)
                .NotEmpty().WithMessage("La contraseña es obligatoria")
                .MinimumLength(8).WithMessage("La contraseña debe tener al menos 8 caracteres");

            // Validar si las contraseñas coinciden
            RuleFor(client => client.Password)
                .Equal(client => client.VerifyPassword)
                .WithMessage("Las contraseñas no coinciden")
                .OverridePropertyName(nameof(Client.Password));
        }
    }
}
