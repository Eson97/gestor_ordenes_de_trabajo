using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorOrdenesDeTrabajo.Clases
{
    public enum Estado : short
    {
        EN_ESPERA = 01,
        EN_PROCESO = 02,
        POR_ENTREGAR = 03,
        ENTREGADA = 04,
        GARANTIA = 05,
        CANCELADA = 06
    }
}
