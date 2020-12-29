using FluentValidation;
using GestorOrdenesDeTrabajo.DB;

namespace GestorOrdenesDeTrabajo.Validation
{
    public class OrdenEntregaValidator : AbstractValidator<Orden>
    {
        public OrdenEntregaValidator()
        {
            RuleFor(el => el.Equipo).NotEmpty().MaximumLength(50).WithMessage("El Equipo no debe sobrepasar los 50 caracteres");
            RuleFor(el => el.Folio).NotNull().GreaterThan(0).WithMessage("El Folio no debe sobrepasar los 50 caracteres");
            RuleFor(el => el.IdCliente).NotNull().GreaterThan(0).WithMessage("Seleccione un cliente");
            RuleFor(el => el.Observaciones).NotEmpty().MaximumLength(250).WithMessage("Las observaciones no deben sobrepasar los 250 caracteres");
            RuleFor(el => el.Referencia).NotEmpty().MaximumLength(11).WithMessage("La referencia no debe ser mayor de 11 caracteres");
            RuleFor(el => el.Status).NotNull().GreaterThan(0).WithMessage("El estado no es correcto");
            RuleFor(el => el.TipoPago).NotNull().GreaterThan(0).WithMessage("El tipo de pago no es correcto");
            RuleFor(el => el.FechaEntrega).NotEmpty().WithMessage("Seleccione una fecha");
        }
    }
}
