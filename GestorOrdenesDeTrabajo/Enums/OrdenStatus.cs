using System;

namespace GestorOrdenesDeTrabajo.Enums
{
    public enum OrdenStatus
    {
        ESPERA = 1,
        PROCESO = 2,
        POR_ENTREGAR = 3,
        ENTREGADA = 4,
        GARANTIA = 5,
        GARANTIA_POR_ENTREGAR = 6,
        GARANTIA_ENTREGADA = 7,
        CANCELADA = 8,
    }

    public static class OrdenStatusManager
    {
        public static string ToString(int status)
        {
            switch (status)
            {
                case (int)OrdenStatus.ESPERA:
                    return "EN ESPERA";
                case (int)OrdenStatus.PROCESO:
                    return "EN PROCESO";
                case (int)OrdenStatus.POR_ENTREGAR:
                    return "POR ENTREGAR";
                case (int)OrdenStatus.ENTREGADA:
                    return "ENTREGADA";
                case (int)OrdenStatus.GARANTIA:
                    return "GARANTIA";
                case (int)OrdenStatus.GARANTIA_POR_ENTREGAR:
                    return "GARANTIA SIN ENTREGAR";
                case (int)OrdenStatus.GARANTIA_ENTREGADA:
                    return "GARANTIA ENTREGADA";
                case (int)OrdenStatus.CANCELADA:
                    return "CANCELADA";
                default:
                    return "INDEFINIDO";
            }
        }
    }
}
