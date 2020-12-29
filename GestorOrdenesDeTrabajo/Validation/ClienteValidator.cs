using FluentValidation;
using GestorOrdenesDeTrabajo.DB;

namespace GestorOrdenesDeTrabajo.Validation
{
    public class ClienteValidator : AbstractValidator<Cliente>
    {
        public ClienteValidator()
        {
            RuleFor(el => el.Direccion).NotEmpty().MaximumLength(70).WithMessage("La Direccion no debe sobrepasar los 50 caracteres");
            RuleFor(el => el.Nombre).NotEmpty().MaximumLength(50).WithMessage("El Nombre no debe sobrepasar los 50 caracteres");
            RuleFor(el => el.Telefono).NotEmpty().MinimumLength(12).MaximumLength(12).WithMessage("No parece un numero telefonico");
        }
    }
}
