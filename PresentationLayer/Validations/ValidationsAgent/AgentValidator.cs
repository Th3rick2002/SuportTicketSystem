using CommonLayer.Entities;
using FluentValidation;


namespace PresentationLayer.Validations.ValidationsAgent
{
    public class AgentValidator : AbstractValidator<Agent>
    {
        public AgentValidator()
        {
            RuleLevelCascadeMode = CascadeMode.Stop;

            RuleFor(agent => agent).NotNull().WithMessage("Debe seleccionar un agente.");

            // Validación de campos obligatorios
            RuleFor(agent => agent.FirstName)
               .NotEmpty().WithMessage("El nombre del agente es obligatorio.")
               .Matches("^[a-zA-Z]+$").WithMessage("El nombre del agente solo puede contener letras.");


            RuleFor(agent => agent.LastName)
                .NotEmpty().WithMessage("El apellido del agente es obligatorio.")
                .Matches("^[a-zA-Z]+$").WithMessage("El apellido del agente solo puede contener letras.");

            RuleFor(agent => agent.Email)
                .NotEmpty().WithMessage("El correo electrónico es obligatorio.")
                .EmailAddress().WithMessage("El correo electrónico no es válido.");

            RuleFor(agent => agent.Password)
                .NotEmpty().WithMessage("La contraseña es obligatoria.")
                .MinimumLength(6).WithMessage("La contraseña debe tener al menos 6 caracteres.")
                .Matches(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d).+$").WithMessage("La contraseña debe incluir al menos una letra mayúscula, una minúscula y un número.");
                
        }
    }
}
