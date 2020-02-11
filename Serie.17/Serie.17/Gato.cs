using System;
using System.Collections.Generic;
using System.Text;

namespace Serie._17
{
    //Implementacion de la interfaz Mascota ha gato
    class Gato : Mascota
    {
        //Creacion de la variable que guardara el nombre del gato
        private string Nombre { get; set; }
        //Se crea el constructor que solicita el nombre
        public Gato(string nombre){
            //Se asigna el valor del constructor a la variale local
            Nombre = nombre;
        }
        //Implementacion del metodo nombre de la interfaz
        public string nombre(){
            //Regresa el nombre del gato
            return Nombre;
        }
        //Implementacion del metodo comer de la interfaz
        public void comer(){
            //Imprime que el gato come
            Console.WriteLine(Nombre + " come pezcado");
        }
        //Implementacion del metodo juagr de la interfaz
        public void jugar(){
            //Imprime que el gato juega
            Console.WriteLine(Nombre + " juega con una bola de estambre");
        }
        //Implementacion del metodo dormir de la interfaz
        public void dormir(){
            //Imprime que el gato duerme
            Console.WriteLine(Nombre + " esta durmiendo... Zzz");
        }
    }
}
