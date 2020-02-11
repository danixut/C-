using System;
using System.Collections.Generic;
using System.Text;

namespace Serie._14
{
    class PrismaCuadrangular : IVolumen{
        //Varibale que guarda el valor de la base
        public double Base;
        //Varibale que guarda el valor de la altura
        public double Altura;
        //Varibale que guarda el valor de la profundidad
        public double Profundidad;
        //Varibale que guarda el valor del color
        public string Color;
        //Se crea el constructor de la clase que solicita los datos para inicializar las variables
        public PrismaCuadrangular(double bas,double altura,double profundidad, string color){
            //Se asignan los datos recibidos a los de la clase
            Base = bas;
            Altura = altura;
            Profundidad = profundidad;
            Color = color;
        }
        //Implementacion del metodo volumen de la interfaz
        public double volumen()
        {
            //Calculo y regreso del valor del volumen
            return (Base*Altura*Profundidad);
        }
        //Implementacion del metodo color de la interfaz
        public string color()
        {
            return Color;
        }
    }
}
