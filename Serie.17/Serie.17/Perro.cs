using System;
using System.Collections.Generic;
using System.Text;

namespace Serie._17
{
    //Implementacion de la interfaz Mascota ha perro
    class Perro : Mascota{
        //Creacion de la variable que guardara el nombre del perro 
        private string Nombre { get; set; }
        //Se crea el constructor que solicita el nombre
        public Perro(string nombre){
            //Se asigna el valor del constructor a la variale local
            Nombre = nombre;
        }
        //Implementacion del metodo nombre de la interfaz
        public string nombre(){
            //Regresa el nombre del perro
            return Nombre;
        }
        //Implementacion del metodo comer de la interfaz
        public void comer(){
            //Imprime que el perro come
            Console.WriteLine(Nombre + " come croquetas");
        }
        //Implementacion del metodo jugar de la interfaz
        public virtual void jugar(){
            //Imprime que el perro juega
            Console.WriteLine(Nombre + " juega con la pelota");
        }
        //Implementacion del metodo dormir de la interfaz
        public void dormir(){
            //Imprime que el perro duerme
            Console.WriteLine(Nombre + " esta durmiendo... Zzz");
        }
    }
}
