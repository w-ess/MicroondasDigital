using FluentValidation;
using MicroondasDigitalDesktop.Entidades;

namespace MicroondasDigitalDesktop.Validacoes
{
    public class MicroondasValidator : AbstractValidator<Microondas>
    {
        public MicroondasValidator()
        {
            RuleFor(m => m.Minutos).LessThan(100).WithMessage("testando validador");
        }   
        
    }
}
