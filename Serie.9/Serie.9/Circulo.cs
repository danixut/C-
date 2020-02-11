using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio9
{
    class Circulo
    {
        public double Radio { get; set; }

        public Circulo(double radio)
        {
            try{
                Radio = Math.Abs(radio);
            }
            catch(FormatException)
            {
                Console.WriteLine("Error");
            }
            
        }

        public double CalcularPerimetro(){
            return 2 * Math.PI * Radio;
        }

        public double CalcularArea(){
            //Usamos Pow para elevar a la potencia indicada un valor.
            return Math.PI * Math.Pow(Radio,2);
        }

        public void DatosCirculo(){
            Console.WriteLine("Radio: {0}\nPerímetro: {1}\nÁrea: {2}", Radio, CalcularPerimetro(), CalcularPerimetro());
        }
    }
}
