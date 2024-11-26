using CommonLayer.Entities;
using FluentValidation;

namespace PresentationLayer.Validations
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
                .WithMessage("La prioridad del ticket es obligatoria.");

            RuleFor(ticket => ticket.Status)
                .NotEmpty()
                .WithMessage("El estado del ticket es obligatorio.");

            RuleFor(ticket => ticket.categorie)
                .GreaterThan(0)
                .WithMessage("La categoría del ticket debe ser válida.");

            RuleFor(ticket => ticket.tag)
                .GreaterThan(0)
                .WithMessage("La etiqueta del ticket debe ser válida.");
        }
    }
}
