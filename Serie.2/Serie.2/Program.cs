using System;

namespace Serie._2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                //Se solicita al usuario el primer numero para evaluar con los demas
                Console.WriteLine("Ingresa el primer numero");
                //Se lee el primer numero
                int num1 = Convert.ToInt32(Console.ReadLine());
                //Se solicita al usuario el segundo numero para evaluar con los demas
                Console.WriteLine("Ingresa el segundo numero");
                //Se lee el segundo numero
                int num2 = Convert.ToInt32(Console.ReadLine());
                //Se da un salto de linea extra para que sea mas presetable el programa
            
            Console.WriteLine("\n");
            //Se hace un ciclo desde el 1 al 100 para comparar cada valor con los dos ingresados con el usuario
            for (int i = 1; i <= 100; i++)
            {
                //Se compara si el numero actual es multiplo de alguno de los dos ingresdos por el usuario o se verifica si el mismo contiene alguno de ellos
                if((i % num1 == 0) || (i % num2 == 0) || i.ToString().Contains(num1.ToString()) || i.ToString().Contains(num2.ToString()))
                {
                    //Si se cumple la condicion anterior se imprime "clap" en vez del numero
                    Console.WriteLine("clap");
                }
                //En case de no cumplirse la condicion anterior se imprimira el numero
                else
                {
                    Console.WriteLine(i);
                }
            }
            }
            catch (FormatException)
            {
                Console.WriteLine("ERROR: Ingresar solo enteros");
            }
            Console.ReadKey();

        }
    }
}
