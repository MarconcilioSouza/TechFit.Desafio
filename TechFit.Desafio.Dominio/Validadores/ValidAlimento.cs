using FluentValidation;
using TechFit.Desafio.Dominio.Entidades;

namespace TechFit.Desafio.Dominio.Validadores
{
    public class AlimentoValidator : AbstractValidator<Alimento>
    {
        public AlimentoValidator()
        {
            RuleFor(a => a.Nome).NotNull();
            RuleFor(a => a.GordurasTotais).NotNull();
            RuleFor(a => a.FibraAlimentar).NotNull();
            RuleFor(a => a.Carboidratos).NotNull();
            RuleFor(a => a.Calorias).NotNull();
            RuleFor(a => a.GordurasSaturadas).NotNull();
            RuleFor(a => a.Proteinas).NotNull();
            RuleFor(a => a.QtdGramas).NotNull();
            RuleFor(a => a.Sodio).NotNull();
        }
    }
}
