using System;
using System.Collections.Generic;
using System.Text;

namespace Serie._14
{
    class PiramideCuadrangular : IVolumen{
        //Varibale que guarda el valor de la base
        public double Base;
        //Varibale que guarda el valor de la altura
        public double Altura;
        //Varibale que guarda el valor del color
        public string Color;
        //Se crea el constructor de la clase que solicita los datos para inicializar las variables
        public PiramideCuadrangular(double bas, double altura, string color)
        {
            //Se asignan los datos recibidos a los de la clase
            Base = bas;
            Altura = altura;
            Color = color;
        }
        //Implementacion del metodo volumen de la interfaz
        public double volumen()
        {
            //Calculo y regreso del valor del volumen
            return ((Math.Pow(Base,2)*Altura)/3);
        }
        //Implementacion del metodo color de la interfaz
        public string color()
        {
            return Color;
        }
    }
}
