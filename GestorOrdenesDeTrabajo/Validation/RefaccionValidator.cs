using FluentValidation;
using GestorOrdenesDeTrabajo.DB;

namespace GestorOrdenesDeTrabajo.Validation
{
    public class RefaccionValidator : AbstractValidator<Refaccion>
    {
        public RefaccionValidator()
        {
            RuleFor(el => el.Codigo).NotEmpty().MaximumLength(20).WithMessage("El codigo debe contener maximo 20 caracteres");
            RuleFor(el => el.Descripcion).NotEmpty().MaximumLength(50).WithMessage("Descripcion muy larga, maximo 50 caracteres");
            RuleFor(el => el.PrecioMinimo).NotEmpty().GreaterThanOrEqualTo(0);
        }
    }
}
