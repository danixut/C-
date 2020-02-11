using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio9
{
    class Octagono
    {
        public const int Lados = 8;

        public double Long_Lado { get; set; }

        public Octagono(double long_lado)
        {
            try 
            { 
                //Abs nos regresa el valor absoluto de un valor. En este caso es para que no importe si nos dan valores negativos
                Long_Lado = Math.Abs(long_lado);
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        public double CalcularPerimetro()
        {
            return Long_Lado * Convert.ToDouble(Lados);
        }

        public double CalcularApotema()
        {
            //Usamos Tan para obtener la tangente de un ángulo. Aquí es para usar la formula general para obtener el apotema de una figura regular
            return Long_Lado / (2 * Math.Tan(180/ Convert.ToDouble(Lados)));
        }
        public double CalcularArea()
        {
            return ( CalcularPerimetro() * CalcularApotema() ) / 2;
        }

        public void DatosOctagono()
        {
            Console.WriteLine("Longitud de los lados: {0}\nPerimetro: {1}\nÁrea: {2}", Long_Lado, CalcularPerimetro(),  CalcularArea());
        }
    }
}
