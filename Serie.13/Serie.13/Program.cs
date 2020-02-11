using System;

namespace claseCarro
{
    class Program
    {
        static void Main()
        {
            BMW b1 = new BMW(500, 1.50) { Modelo = "serie1" };
            Console.WriteLine(b1.ToString());
            b1.Estado();
            b1.Encender();
            b1.Estado();
            b1.Apagar();
            b1.Estado();
            Ferrari f1 = new Ferrari(1000, 1.40) { Modelo = "f40" };
            Console.WriteLine(f1.ToString());
            f1.Estado();
            f1.Encender();
            f1.Estado();
            f1.Apagar();
            f1.Estado();
            Console.ReadKey();
        }
    }
}
