using System;

namespace Serie._7
{
    class Program
    {
        static void Main(string[] args)
        {
            NumeroComplejo n1 = new NumeroComplejo(5,-3);
            NumeroComplejo n2 = new NumeroComplejo(8,12);
            NumeroComplejo n3;
            n1.imprimir();
            n3 = n2.sumar(n1);
            n3.imprimir();
            Console.ReadKey();
        }
    }
}
