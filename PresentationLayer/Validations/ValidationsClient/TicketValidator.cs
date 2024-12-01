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
                .WithMessage("El nombre del ticket es obligatorio.");

            RuleFor(ticket => ticket.DescriptionTicket)
                .NotEmpty()
                .WithMessage("La descripción del ticket es obligatoria.");

            RuleFor(ticket => ticket.Priority)
                .NotEmpty()
                .WithMessage("Debes seleccionar una prioridad.");

            RuleFor(ticket => ticket.categorie)
                .GreaterThan(0)
                .WithMessage("Debes seleccionar una categoría válida.");

            RuleFor(ticket => ticket.tag)
                .GreaterThan(0)
                .WithMessage("Debes seleccionar una etiqueta válida.");

            RuleFor(ticket => ticket.tag)
                .GreaterThan(0)
                .WithMessage("La etiqueta del ticket debe ser válida.");
        }
    }
}
