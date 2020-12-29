using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorOrdenesDeTrabajo.Validation
{
    public static class ShowErrorValidation
    {
        public static bool Valid(ValidationResult res)
        {
            if (!res.IsValid)
            {
                foreach (var item in res.Errors)
                    MessageBox.Show(item.ErrorMessage, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return res.IsValid;
        }
    }
}
