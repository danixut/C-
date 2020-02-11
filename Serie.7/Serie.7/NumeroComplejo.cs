using System;
using System.Collections.Generic;
using System.Text;

namespace Serie._7
{
    class NumeroComplejo
    { 
        //Se crea la variable que guardara la parte real del numero
        public int real;
        //Se crea la variable que guardara la parte imaginaria del numero
        public int imaginaria;
        //Se crea el constructor que solicita la parte real e imaginaria para poder crear el numero
        public NumeroComplejo(int Real, int Imaginaria){
            real = Real;
            imaginaria = Imaginaria;
        }
        //Funcion que imprime el numero imaginario con formato
        public void imprimir(){
            //Verifica si la parte imaginaria es postivica para imprimirlo con un signo de mas despues de la parte real
            if(imaginaria > 0)
                Console.WriteLine("{0}+{1}i",real,imaginaria);
            //Si lo anterior no se cumple verifica si la parte imaginaria es 0 para solo imprimir la parte real
            else if(imaginaria ==0)
                Console.WriteLine("{0}", real);
            //Si la parte imaginaria es negativa solo imprime la real segida de la imaginaria ya que trae su signo
            else
                Console.WriteLine("{0}{1}i", real, imaginaria);
        }
        //Funcion que suma dos numeros complejos, regresa un numero complejo y solicita un numero complejo de entrada
        public NumeroComplejo sumar(NumeroComplejo n1){
            //Se crea un nuevo  numero complejo dandole como valores de entrada la suma de la parte real e imaginaria del actual y el que se ingreso
            NumeroComplejo ns = new NumeroComplejo(real+n1.real,imaginaria+n1.imaginaria);
            //Se regresa el nuevo numero complejo
            return ns;
        }
    }
}
