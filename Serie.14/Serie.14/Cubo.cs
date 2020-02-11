using System;
using System.Collections.Generic;
using System.Text;

namespace Serie._14
{
    class Cubo : IVolumen{
        //Varibale que guarda el valor de la base
        public double Base;
        //Varibale que guarda el valor del color
        public string Color;
        //Se crea el constructor de la clase que solicita los datos para inicializar las variables
        public Cubo(double bas,string color){
            //Se asignan los datos recibidos a los de la clase
            Base = bas;
            Color = color;
        }
        //Implementacion del metodo volumen de la interfaz
        public double volumen(){
            //Calculo y regreso del valor del volumen
            return (Math.Pow(Base,3));
        }
        //Implementacion del metodo color de la interfaz
        public string color(){
            return Color;
        }
    }
}
