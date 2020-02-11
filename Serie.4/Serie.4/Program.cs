using System;

namespace Serie._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se crea la variable a que es el primer elemento de la serie de Fibonacci
            int a = 0;
            //Se crea la variable a que es el segundo elemento de la serie de Fibonacci
            int b = 1;
            //Se crea una variable auxiliar que  nos ayudara a poder realizar las sumas
            int aux;
            //Se crea una variable que guardara la cantidad de elemntos a mostrar de la serie
            int limite = 0;
            //Se solicita al usuario ingresar los datos del limite
            Console.WriteLine("Ingrese el numero de elementos a mostrar");
            try
            {
                //Se leen el limite y se verifica que sea un numero
                limite = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                //Si el usuario no ingresa un numero mandara error
                Console.WriteLine("ERROR: Ingrese solo numeros enteros");
            }
            finally
            {
                //Imprime la leyenda "Serie de Fiboncacci"
                Console.WriteLine("\n---------Serie de Fibonacci---------\n");
                //Se cre un ciclo que se reptira las veces que alla indicado el usuario
                for (int i = 0; i < limite; i++)
                {
                    //Se guarda el valor de a en aux para tener el valor del numero anterior en la serie
                    aux = a;
                    //Se asigna el valor del numero actual que es b en la variable a que es el numero actual
                    a = b;
                    //Se suma el valor del numero anterior con el actual (aux+a) y se guarda en b el cual sera el nuevo valor actual
                    b = aux + a;
                    //Se imprime el valor de a
                    Console.WriteLine(a);
                }
                Console.ReadKey();
            }
        }
    }
}
