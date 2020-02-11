using System;

namespace Serie_8{
    class Program{
        static void Main(string[] args){
            //Creamos 3 pbjetos del tipo coche e incicalizamos dos y uno usamos el consructor por defecto
            Auto a1 = new Auto("Labmbo", 254687985, 1780589.38);
            Auto a2 = new Auto();
            Auto a3 = new Auto("BMW", 0987654321, 12371.82);
            //Usamos los metodos
            Console.WriteLine(a1.Marca);
            a1.Encender();
            a1.Acelerar();
            a1.Apagar();
            a1.Marca = "Ferrari";
            a1.Precio = 98716523.678;
            Console.WriteLine(a1.Marca);
            Console.WriteLine(a1.Precio);
            Console.WriteLine(a2.Marca);
            a2.Encender();
            a2.Apagar();
            Console.WriteLine(a3.Marca);
            a3.Encender();
            a3.Frenar();
            Console.ReadKey();
        }
    }
}
