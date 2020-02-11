using System;

namespace Serie._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se solicita al usuario el limite para sumar los numeros
            Console.WriteLine("Ingrese el limite de numeros que quiere sumar");
            int N=0;
            try
            {
                //Se lee la entrada del usuario y se convierte a entero
                N = Convert.ToInt32(Console.ReadLine());
            }catch(FormatException)
            {
                Console.WriteLine("ERROR: Solo enteros");
            }
            //Se crea una variable donde se almacenara la suma
            int suma = 0;
            //Se crea un ciclo for que se repetira hasta que llegue al limite ingresado por el usuario empezando a sumar desde el uno
            for (int i = 1; i <= N; i++)
            {
                //se agrega el valor de cada repeticion a la variable suma
                suma += i;
            }
            //Se imprime el resutado de la suma
            Console.WriteLine("El resultado de la suma es: " + suma);
            Console.ReadKey();
        }
    }
}
