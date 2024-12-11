using CommonLayer.Entities;
using FluentValidation;

namespace PresentationLayer.Validations.ValidationsClient
{
    public class TicketValidator : AbstractValidator<Ticket>
    {
        public TicketValidator()
        {
            RuleLevelCascadeMode = CascadeMode.Stop;

            RuleFor(ticket => ticket.NameTicket)
                .NotEmpty()
                .WithMessage("El nombre del ticket es obligatorio.")
                .MinimumLength(3).WithMessage("El nombre debe contener minimo 3 letras")
                .MaximumLength(100).WithMessage("El nombre no puede tener mas de 100 letras")
                .Matches(@"^[a-zA-Z\s]+$").WithMessage("El nombre solo puede contener letras y espacios");


            RuleFor(ticket => ticket.DescriptionTicket)
                .NotEmpty()
                .WithMessage("La descripción del ticket es obligatoria.")
                .MinimumLength(5).WithMessage("La descripción debe contener mínimo 5 caracteres.")
                .MaximumLength(100).WithMessage("La descripción no puede tener más de 100 caracteres.")
                .Matches(@"^[a-zA-Z\s]+$").WithMessage("La descripción solo puede contener letras y espacios.");

            RuleFor(ticket => ticket.Priority)
                .NotEmpty()
                .WithMessage("Debes seleccionar una prioridad.");

            RuleFor(ticket => ticket.categorie)
                .GreaterThan(0)
                .WithMessage("Debes seleccionar una categoría.");

            RuleFor(ticket => ticket.tag)
                .GreaterThan(0)
                .WithMessage("Debes seleccionar una etiqueta.");
        }
    }
}
