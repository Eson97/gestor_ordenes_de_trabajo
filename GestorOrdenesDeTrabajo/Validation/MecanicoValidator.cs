using FluentValidation;
using GestorOrdenesDeTrabajo.DB;

namespace GestorOrdenesDeTrabajo.Validation
{
    class MecanicoValidator :AbstractValidator<Mecanico>
    {
        public MecanicoValidator()
        {
            RuleFor(el => el.Nombre).NotEmpty().MaximumLength(25).WithMessage("El Nombre no debe sobrepasar los 25 caracteres y debe de ser un nombre valido");
        }
    }
}
