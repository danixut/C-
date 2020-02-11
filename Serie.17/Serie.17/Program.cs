using System;

namespace Serie._17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creacion de un nuevo objeto perro
            Perro perro = new Perro("Canelo");
            //Creacion de un nuevo objeto gato
            Gato gato = new Gato("Mishi");
            //Creacion de un nuevo objeto cachorro
            Cachorro cachorro = new Cachorro("Firulais");
            //Uso de los metodos de cada objeto
            gato.comer();
            cachorro.jugar();
            perro.jugar();
            cachorro.dormir();
            Console.ReadKey();
        }
    }
}
