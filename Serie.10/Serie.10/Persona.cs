using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Threading;

namespace _10_Persona {
    class Persona {
        //Obtenemos la fecha
        DateTime fecha = new DateTime(2020, 2, 9, 12, 00, 0); 
        // Creamos las variables
        public string Nombre;
        public int AnoNacimiento;
        public int Estatura;
        public int Peso;
        // Creamos el Constructor
        public Persona(string nombre, int año, int estatura, int peso) {
            Nombre = nombre;
            AnoNacimiento = año;
            Estatura = estatura;
            Peso = peso;
        } 
        // Método para calcular la edad
        public void calcularEdad(int edad) {
            int Edad = fecha.Year - edad;
            Console.WriteLine("\n{0} tiene {1} años de edad.", Nombre, Edad);
        }
        // Método para calcular la estatura
        public void cmPies(int estatura) {
            double estaturaPies = estatura * 0.032808;
            Console.WriteLine("\n{0} mide {1} en pies que es {2} cm", Nombre, estaturaPies, estatura);
        }
        // Método para calcular el peso
        public void kgLibras(int peso) {
            double pesoLibras = peso * 2.20462;
            Console.WriteLine("\n{0} pesa {1} libras que son {2} kg", Nombre, pesoLibras, peso);
        }
    }
}
