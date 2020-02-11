using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{	
	public static class Calculadora
	{
		//Declaracion de variables
		static double number1;
		static double number2;
		//Creacion del metodo Sumar
		public static double Suma(double num1, double num2)
		{
			Console.WriteLine("La suma de " + num1 + " + " + num2 + " es\n"+(num1+num2));
			return num1 + num2;
		}
		//Creacion del metodo Restar
		public static double Resta(double num1, double num2)
		{
			Console.WriteLine("La resta de " + num1 + " - " + num2 + " es\n" + (num1 - num2));
			return num1 - num2;
		}
		//Creacion del metodo Multicar
		public static double Multiplicar(double num1, double num2)
		{
			Console.WriteLine("La multiplicacion de " + num1 + " * " + num2 + " es\n" + (num1 * num2));
			return num1 * num2;
		}
		//Creacion del metodo Dividir
		public static double Divide(double num1, double num2)
		{
			//Validamos que la division no sea entre 0
			if(num2 == 0)
			{
				Console.WriteLine("No se puede hacer la dividion entre 0");
				Inicio(1);
			}
			Console.WriteLine("La division de " + num1 + " / " + num2 + " es\n" + (num1 / num2));
			return num1 / num2;
		}

		public static void Numeros(string operacion)
		{
			Console.WriteLine("Ingrese el primer número" + operacion);
			number1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Ingrese el segundo número" + operacion);
			number2 = Convert.ToInt32(Console.ReadLine());
		}

		public static int Inicio(int estado=0)
		{
			int salida = 0;

			Console.WriteLine("\nSelecciona una operación:");
			Console.WriteLine("\t1)Realizar suma");
			Console.WriteLine("\t2)Realizar resta");
			Console.WriteLine("\t3)Realizar multiplicacion");
			Console.WriteLine("\t4)Realizar división");
			Console.WriteLine("\t5)Salir");

			try
			{
				int respuesta = Convert.ToInt32(Console.ReadLine());

				switch (respuesta)
				{
					case 1:
						Console.WriteLine("Suma");
						Numeros("sumar");
						Suma(number1, number2);
						break;
					case 2:
						Console.WriteLine("resta");
						Numeros("restar");
						Resta(number1, number2);
						break;
					case 3:
						Console.WriteLine("Multiplica");
						Numeros("multiplicar");
						Multiplicar(number1, number2);
						break;
					case 4:
						Console.WriteLine("Divide");
						Numeros("dividir");
						Divide(number1, number2);
						break;
					case 5:
						Console.WriteLine("¡Adiós!");
						Console.ReadKey();
						return 0;
					default:
						break;
				}
			}
			catch
			{
				Console.Clear();
				Console.WriteLine("ERROR");
				Console.WriteLine("Solo opciones validas");
				Console.WriteLine("Solo puedes operar números: ");
			}
			if (salida == 0)
				Inicio(1);
			return 1;
		}
	}
}
