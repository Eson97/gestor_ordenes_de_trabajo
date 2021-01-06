using FluentValidation;
using GestorOrdenesDeTrabajo.DB;

namespace GestorOrdenesDeTrabajo.Validation
{
    public class RefaccionValidator : AbstractValidator<Refaccion>
    {
        public RefaccionValidator()
        {
            RuleFor(el => el.Codigo).NotEmpty().MaximumLength(30).WithMessage("El codigo debe contener maximo 30 caracteres");
            RuleFor(el => el.Descripcion).NotEmpty().MaximumLength(100).WithMessage("Descripcion muy larga, maximo 100 caracteres");
            RuleFor(el => el.PrecioMinimo).NotEmpty().GreaterThanOrEqualTo(0);
        }
    }
}
