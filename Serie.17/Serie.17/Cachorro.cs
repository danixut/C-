using System;
using System.Collections.Generic;
using System.Text;

namespace Serie._17
{
    //Se crea la clase cachorro que hereda de la clase perro
    class Cachorro : Perro{
        //Creacion de la variable que guardara el nombre del cachorro
        private string Nombre { get; set; }
        //Se crea el constructor que solicita el nombre
        public Cachorro(string nombre) : base(nombre){
            //Se asigna el valor del constructor a la variale local
            Nombre = nombre;
        }
        //Modificar el metodo jugar de perro ya que en un cachorro es diferente
        public override void jugar(){
            //Imprime que el cachorro juega
            Console.WriteLine(Nombre + " no deja de jugar tiene mucha energia!!!!");
        }
    }
}
