using System;
using System.Collections.Generic;
using System.Text;

namespace Serie_8{
    class Auto {
        //Declaramos las variables y generamos sus metodos
        string marca;
        public string Marca {
            get { return marca; }
            set { marca = value; }
        }
        double precio;
        public double Precio {
            get { return precio; }
            set { precio = value; } 
        }
        int serie;
        public int NoSerie {
            get { return serie; }
            set { serie = value; } 
        }
        //creamos el constructor
        public Auto() {
            Console.WriteLine("Mercedes" + " " + "1234567890678" + " " +"$5830000");
        }
        //csobrecargamos del constructor
        public Auto(string Marca, int Serie, double Precio){
            marca = Marca;
            precio = Precio;
            serie = Serie;
        }
        //Creamos el metodo encender
        public void Encender(){
            Console.WriteLine("Encernder auto");
        }
        //Creamos el metodo acelerar
        public void Acelerar(){
            Console.WriteLine("Kuchau");
        }
        //Creamos el metodo apagar
        public void Frenar(){
            Console.WriteLine("Enfrenon");
        }
        //Creamos el metodo apagar
        public void Apagar(){
            Console.WriteLine("Adios");
        }


    }
}
