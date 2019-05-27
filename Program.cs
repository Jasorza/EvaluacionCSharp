using System;

namespace EvaluacionCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********Bienvenido a la Aplicacion Billetera*********");
            EjercicioBilletera opc = new EjercicioBilletera();
            opc.Menu();
        }
    }
}
