using System;
using System.Collections.Generic;
using System.Text;

namespace Serie._6
{
    class CuentaBancaria
    {
        //Se crea la variable donde se guardara el nombre de la cuenta
        private string nombre;
        //Se crea la variable donde se guarda el saldo de la cuenta
        private double saldo;
        //Se crea el constructor de la clase el cual solicita un nombre y un saldo incial para poder ser creado y al crearse
        //regresa informacion del nombre de la cuenta y el saldo con el que se creo
        public CuentaBancaria(string Nombre, double Saldo) {
            //Se asignan los datos del constructor a los de la clase
            nombre = Nombre;
            saldo = Saldo;
            //Regresa la informacion de la cuenta creada
            Console.WriteLine("Cuenta {0} creada con exito con un saldo de: {1}",nombre,saldo);
        }
        //Se crea el metodo mostarInformacion el cual nos regresa los datos de una cuenta(nombre y saldo)
        public string mostarInformacion()
        {
            //Al ser llamado este metodo regresara la informacion de la cuenta en forma de cadena
            return string.Format("Cuenta: {0}\nSaldo: {1}",nombre,saldo);
        } 
        //Se crea el metodo depositar para aumentar la cantidad de una cuenta
        public void depositar(double cantidad){
            //Se crea una variable que almacena el saldo anterior antes del deposito para poder mostrar el resmuen de la transaccion
            double saldoOld = saldo;
            //Se le suma la cantidad depositada al saldo previo
            saldo += cantidad;
            //Se muestra el resumen del movimiento con el nombre de la cuenta, el saldo anterior y el saldo al final de la transaccion
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Cuenta: {0} \nSaldo incial: ${1}\nLa cantidad agregada fue de: ${2} \nSaldo actual: ${3}",nombre,saldoOld,cantidad,saldo);
        }
        //Se crea el metodo retirar para disminuir la cantidad de una cuenta
        public void retirar(double retiro){
            //Se verifica que lo que se desea retirar no sea mayor al saldo actual de la cuenta
            if(retiro > saldo)
            {
                //Si lo que se desea rtirar es mayor al saldo disponible regresara un error
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Cuenta: {0} \nSaldo Insuficiente",nombre);
            }
            else
            {
                //Si el salo es suficiente entonces se crea una variable que almacena el saldo anterior antes del deposito para poder mostrar el resmuen de la transaccion
                double saldoOld = saldo;
                //Se le resta la cantidad retirada al saldo previo
                saldo -= retiro;
                //Se muestra el resumen del movimiento con el nombre de la cuenta, el saldo anterior y el saldo al final de la transaccion
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Cuenta: {0} \nSaldo incial: ${1}\nLa cantidad retirada fue de: ${2} \nSaldo actual: ${3}", nombre,saldoOld, retiro, saldo);
            }
        }
    }
}
