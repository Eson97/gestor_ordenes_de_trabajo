namespace BussinessLayer.Enum
{
    public enum OrdenStatus
    {
        ESPERA = 1,
        PROCESO = 2,
        POR_ENTREGAR = 3,
        ENTREGADA = 4,
        GARANTIA = 5,
        CANCELADA = 6

    }

    public class OrdenStatusMan
    {
        private string ToString(int status)
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
                case (int)OrdenStatus.CANCELADA:
                    return "CANCELADA";
                default:
                    return "INDEFINIDO";
            }
        }
    }
}
