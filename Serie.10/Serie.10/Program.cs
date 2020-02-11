using System;
using System.Globalization;
using System.Threading;

namespace _10_Persona {
    class Program {
        static void Main(string[] args) {

            // Creacion de variables
            string nombre;
            int ano=0;
            int altura=0;
            int peso=0;
            //solicitamos datos al usuario
            Console.WriteLine("Nombre : ");
            nombre = Console.ReadLine();
            do {
                try {
                    //solicitamos datos al usuario
                    Console.WriteLine("Año de nacimiento: ");
                    ano = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ingrese un año correcto.");
                }
                try {
                    //solicitamos datos al usuario
                    Console.WriteLine("Altura: ");
                    altura = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException )
                {
                    Console.WriteLine("Ingrese una altura correcta.");
                }
                try {
                    //solicitamos datos al usuario
                    Console.WriteLine("Peso: ");
                    peso = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ingrese un peso correcto.");
                }
            } while (true);

            // Se crea un objeto de tipo persona
            Persona nuevo = new Persona(nombre, ano, altura, peso);
            //Uso de los metodos
            nuevo.calcularEdad(ano);
            nuevo.cmPies(altura);
            nuevo.kgLibras(peso);

            Console.ReadKey();
        }
    }
}