using System;

namespace Ejercicio9
{
    public class Program
    { 
        static void Main()
        {
            double radio;
            double lado;
                Console.Write("Ingrese el radio del cículo: ");
                try 
                {   
                    radio = Convert.ToDouble( Console.ReadLine() );
                    Circulo c1 = new Circulo(radio);
                    c1.DatosCirculo();
                }
                catch
                {   
                Console.WriteLine("Dato no valido");    
                }
                Console.Write("\n");
                Console.Write("Indique la longitud del lado: ");
                try 
                { 
                    lado = Convert.ToDouble( Console.ReadLine() );
                    Octagono p1 = new Octagono(lado);
                    p1.DatosOctagono();
                }
                catch
                { Console.WriteLine("Dato no valido"); }
                Console.Write("\n");
                Console.ReadLine();
        }
    }
}
