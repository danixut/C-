using System;
using System.Collections.Generic;
using System.Text;

namespace claseCarro
{
    class Ferrari : Carro
    {
        //Creacion de las variables con sus metodos get y set
        private string modelo;
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public Ferrari(double peso, double altura) : base(peso, altura) { } //Constructor heredado
        public override string ToString()
        {
            return string.Format("Modelo {0}: el peso es de {1}kgs y la altura de {2}mts", modelo, Peso, Altura);
        }
    }
}
