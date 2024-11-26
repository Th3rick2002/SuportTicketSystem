using CommonLayer.Entities;
using FluentValidation;


namespace PresentationLayer.Validations
{
    public class AgentValidator : AbstractValidator<Agent>
    { 
        public AgentValidator()
        {
            RuleLevelCascadeMode = CascadeMode.Stop;

        }
    }
}
