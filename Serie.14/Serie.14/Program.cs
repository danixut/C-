using System;

namespace Serie._14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creacion de un nuevo objeto cubo
            Cubo cubo = new Cubo(5,"azul");
            //Creacion de un nuevo objeto primsa cuadrangualr
            PrismaCuadrangular pris = new PrismaCuadrangular(3,7,12,"verde");
            //Creacion de un nuevo objeto piramide cuadrangular
            PiramideCuadrangular piramide = new PiramideCuadrangular(4,15,"amarillo");
            //Impresion del metodo volumen del cubo
            Console.WriteLine(cubo.volumen());
            //Impresion del metodo volumen del primsa
            Console.WriteLine(pris.volumen());
            //Impresion del metodo volumen de la piramide
            Console.WriteLine(piramide.volumen());
            //Impresion del metodo color del prisma
            Console.WriteLine(pris.color());
            //Impresion del metodo color de la piramide
            Console.WriteLine(piramide.color());
            Console.ReadKey();
        }
    }
}
