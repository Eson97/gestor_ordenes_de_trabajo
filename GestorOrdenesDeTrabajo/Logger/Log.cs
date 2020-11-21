using System;

namespace GestorOrdenesDeTrabajo.Logger
{
    public class Log
    {
        public static void Write(string message)
        {
            WriteDB(message, true);
        }

        // Util por si solo queremos utilizar el Log para debug
        public static void WriteDB(string message, bool show)
        {
            if (show)
                Console.WriteLine(message);
        }
    }
}
