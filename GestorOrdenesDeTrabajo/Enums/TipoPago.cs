namespace GestorOrdenesDeTrabajo.Enums
{
    public enum TipoPago
    {
        EFECTIVO = 1,
        TERMINAL = 2,
        TRANSFERENCIA = 3,
        CHEQUE = 4,
        CREDITO = 5
    }

    public static class TipoPagoManager
    {
        public static string ToString(int tipoPago)
        {
            switch (tipoPago)
            {
                case (int)TipoPago.EFECTIVO:
                    return "EFECTIVO";
                case (int)TipoPago.TERMINAL:
                    return "TERMINAL";
                case (int)TipoPago.TRANSFERENCIA:
                    return "TRANSFERENCIA";
                case (int)TipoPago.CHEQUE:
                    return "CHEQUE";
                case (int)TipoPago.CREDITO:
                    return "CREDITO";
                default:
                    return "INDEFINIDO";
            }
        }
    }
}
