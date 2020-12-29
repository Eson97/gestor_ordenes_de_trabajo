using FluentValidation;
using GestorOrdenesDeTrabajo.DB;

namespace GestorOrdenesDeTrabajo.Validation
{
    public class OrdenHistorialValidator : AbstractValidator<OrdenHistorial>
    {
        public OrdenHistorialValidator()
        {
            RuleFor(el => el.Status).GreaterThan(0).WithMessage("El Status de la Orden en historial es invalido");
            RuleFor(el => el.IdOrden).GreaterThan(0).WithMessage("El Id Orden en historial es invalido");
            RuleFor(el => el.FechaStatus).NotEmpty().WithMessage("La Fecha de status de la Orden en historial es invalida");
        }
    }
}
