using System;
using System.IO;

namespace Serie._18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bandera para indicar si se realizo un cambio en la cadena de entrada
            bool cambio = false;
            //Variable que guarla la cadena modificad de la ruta
            string nuevaCadena = "";
            //Se solicita al usuario la ruta donde quiere gaurdar el archivo
            Console.WriteLine("Ingrese la ruta donde desea crear el archivo incluyendo el nombre del archivo");
            //Guardamos la ruta del archivo con su nombre
            string ruta = Console.ReadLine();
            //Solicitamos al usuario el texto que quiere poner en el archivo 
            Console.WriteLine("Ingrese el texto que desea escribir en el archivo");
            //Se almacena el texto ingresado por el usuario
            string texto = Console.ReadLine();
            //Recorremos la ruta ingresada por el usuario para poder escapar las diagonales de la ruta
            for (int i = 0; i < ruta.Length; i++)
            {
                //Se verifica si se encuentra una diagonal en la ubicacion actual de la ruta
                if (ruta[i].Equals('\\'))
                {
                    //Si se encuetra la bandera de cambio se levanta
                    cambio = true;
                    //Se le agrega la diagonal extra para poderla escapar
                    nuevaCadena += ("\\" + ruta[i]);
                }
                else
                {
                    //Si no la bandera de cambio se mantiene abajo
                    cambio = false;
                }
                //Se verifica si no hubo un cambio para afgregar el valor actual a la cadena nueva d ela ruta
                if (!cambio)
                    nuevaCadena += ruta[i];
            }
            try
            {
                //Escribimos el texto que ingreso el usuario al archivo en la ruta indicada
                File.WriteAllText(nuevaCadena, texto);
                //Se abre el archivo para leerlo y ver que el texto se escribio
                var fs = File.OpenRead(nuevaCadena);
                //Agregamos la tama a otra variable para poder leer el archivo
                var stream = new StreamReader(fs);
                //Creamos una variable que guardara cada linea del archivo
                String line;
                Console.WriteLine("\nEl texto ingresado fue el siguiente");
                //Recorreremos el archivohasat encontarr una cadena vacia
                while ((line = stream.ReadLine()) != null)
                {
                    //Imprimimos la linea actual
                    Console.WriteLine(line);
                }
                //Cerramos el archivo
                fs.Close();
                //Informamos que todo paso con exito
                Console.WriteLine("\nArchivo escrito con exito");
            }
            catch(FormatException)
            {
                Console.WriteLine("ERROR AL ABRIR EL ARCHIVO");
            }
            Console.ReadKey();
        }
    }
}
