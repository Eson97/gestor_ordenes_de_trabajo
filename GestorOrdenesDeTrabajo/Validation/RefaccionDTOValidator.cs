using FluentValidation;
using GestorOrdenesDeTrabajo.Auxiliares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorOrdenesDeTrabajo.Validation
{
    public class RefaccionDTOValidator : AbstractValidator<RefaccionDTO>
    {
        public RefaccionDTOValidator()
        {
            RuleFor(el => el.Codigo).NotEmpty();
            RuleFor(el => el.Descripcion).NotEmpty();
            RuleFor(el => el.PrecioUnitrio).NotEmpty().GreaterThanOrEqualTo(0);
            RuleFor(el => el.Cantidad).GreaterThan(0);
            RuleFor(el => el.Total).GreaterThan(0);
        }
    }
}
