using FluentValidation;
using GestorOrdenesDeTrabajo.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
