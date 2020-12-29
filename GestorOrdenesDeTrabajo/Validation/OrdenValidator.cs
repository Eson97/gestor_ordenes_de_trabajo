using FluentValidation;
using GestorOrdenesDeTrabajo.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorOrdenesDeTrabajo.Validation
{
    public class OrdenValidator : AbstractValidator<Orden>
    {
        public OrdenValidator()
        {
            RuleFor(el => el.Equipo).NotEmpty().MaximumLength(50).WithMessage("El Equipo no debe sobrepasar los 50 caracteres");
            RuleFor(el => el.Folio).NotNull().GreaterThan(0).WithMessage("El Folio no debe sobrepasar los 50 caracteres");
            RuleFor(el => el.IdCliente).NotNull().GreaterThan(0).WithMessage("Seleccione un cliente");
            RuleFor(el => el.Observaciones).NotEmpty().MaximumLength(250).WithMessage("Las observaciones no deben sobrepasar los 250 caracteres");
            RuleFor(el => el.Status).NotNull().GreaterThan(0).WithMessage("El estado no es correcto");
        }
    }
}
