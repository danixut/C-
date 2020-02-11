using System;

namespace Serie._16
{
    class Program
    {
        //Creamos la interface base y agregamos un método imprimir
        public interface Base
        {
            void Imprimir();
        }
        //Creamos la clase Derivada que implementa la interfaz Base
        public class Derivada : Base
        {
            //Implementamos el metodo Imprimir y lo modificamos a lo que necesitamos
            public void Imprimir()
            {
                Console.WriteLine("Hola mundo");
            }
        }
        static void Main(string[] args)
        {
            //Creamos un nuevo objeto del tipo Derivada
            Derivada d = new Derivada();
            //Implemntamos su metodo imprimir
            d.Imprimir();
            Console.ReadKey();
        }
    }
}
