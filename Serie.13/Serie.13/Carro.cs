using System;
using System.Collections.Generic;
using System.Text;

namespace claseCarro
{
    class Carro
    {
        //Declaracion de variables con sus metodos get y set
        private double peso;
        public double Peso 
        {
            get { return peso; }
            set { peso = value; } 
        }
        private double altura;
        public double Altura 
        { get { return altura; }
            set { altura = value; } 
        }
        private bool encendido;
        public bool Encendido 
        {
            get { return encendido; }
            set { encendido = false; } 
        }
        //Creacion del constructor
        public Carro(double peso, double altura)
        {
            Peso = peso;
            Altura = altura;
        }
        //Creacion del metodo encender
        public void Encender() 
        {
            encendido = true;
            Console.WriteLine("Auto encendido");
        }
        //Creacion del metodo apagar
        public void Apagar() 
        {
            encendido = false; 
            Console.WriteLine("Auto Apagado");
        }
        //Creacion del metodo estado
        public void Estado() {
            //Se verifica si el coche esta encendido
            if (encendido) 
            {
                Console.WriteLine("Prendido");
            }
            else
            {
                Console.WriteLine("Apagado");
            }
        }
        //Modificamos el metodo ToString del padre
        public override string ToString()
        {
            return string.Format("El peso es de {0}kg y la altura de {1}m", peso, altura);
        }
    }
}
