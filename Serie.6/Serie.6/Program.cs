using System;

namespace Serie._6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se crea un objeto de tipo cuentaBancaria y se le asigna un nombre y un saldo incial
            CuentaBancaria c1 = new CuentaBancaria("Daniel",1532.0);
            //Se crea otro objeto de tipo cuentaBancaria y se le asigna un nombre y un saldo incial
            CuentaBancaria c2 = new CuentaBancaria("Juan", 783.25);
            //Se utiliza el metodo mostrarInformacion del objeto c1
            c1.mostarInformacion();
            //Se utiliza el metodo depositar del objeto c2
            c2.depositar(250.50);
            //Se utiliza el metodo retirar del objeto c1 con una cantidad valida
            c1.retirar(500.30);
            //Se utiliza el metodo retirar del objeto c1 con una cantidad invalida
            c1.retirar(2000);
            Console.ReadKey();
        }
    }
}
