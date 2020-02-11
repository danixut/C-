using System;

namespace Serie._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitamos al usuario la cadena
            Console.WriteLine("Ingrese una cadena");
            //Leemos la cadena y la guardamos
            string cadena = Console.ReadLine();
            //Creamos un arreglo con las vocales minusculas y mayusculas
            char[] vocales = { 'a', 'e', 'i', 'o', 'u','A','E','I','O','U' };
            //creeamos una bandera que nos indica si hay cambios es decir que una vocal cambie por f+vocal
            bool cambio = false;
            //Creamos una nueva cadena que guardara los cambios
            string nuevaCadena = "";
            //Creamos un ciclo que recorra toda la cadena
            for (int i = 0; i < cadena.Length; i++)
            {
                //Creamos un ciclo que recorra el arreglo de vocales
                for (int j = 0; j < vocales.Length; j++)
                {
                    //Verificamos si el caracter actual que se esta evaluando es igual a alguna de las vocales
                    if (cadena[i].Equals(vocales[j]))
                    {
                        //Si se cumple la condicion anterior se levanta la bandera de cambio
                        cambio = true;
                        //Se agrega el a la cadena la f+vocal a la nueva cadena
                        nuevaCadena += ("f" + cadena[i]);
                        //Se sale del ciclo que recorre las vocales 
                        break;
                    }
                    else
                    {
                        //Si no se cumple la condicion anterior se mantiene abajo la bandera de cambio
                        cambio = false;
                    }
                }
                //Si no hubo cambios en el ciclo de las vocales se agrega el valor actual de la cenda a la nueva cadena
                if (!cambio)
                    nuevaCadena += cadena[i];
            }
            //Se imprime la nueva cadena
            Console.WriteLine(nuevaCadena);
            Console.ReadKey();
        }
    }
}
