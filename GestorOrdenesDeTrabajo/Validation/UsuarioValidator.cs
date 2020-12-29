using FluentValidation;
using GestorOrdenesDeTrabajo.DB;

namespace GestorOrdenesDeTrabajo.Validation
{
    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator()
        {
            RuleFor(el => el.Password).NotEmpty().MinimumLength(6).MaximumLength(20).WithMessage("La contraseña debe contener al menos 6 caracteres y maximo 20");
            RuleFor(el => el.Usuario1).Matches("^[a-zA-Z]+(?:[_-]?[a-zA-Z0-9])*$").MaximumLength(20).NotEmpty()
                .WithMessage("El nombre de usuario no es correcto, solo puede contener letras, guiones y numeros al final de este");
        }
    }
}
