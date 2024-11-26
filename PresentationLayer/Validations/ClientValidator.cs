using CommonLayer.Entities;
using FluentValidation;

namespace PresentationLayer.Validations
{
    public class ClientValidator : AbstractValidator<Client>
    {
        public ClientValidator()
        {
            RuleLevelCascadeMode = CascadeMode.Stop;

        }
    }
}
