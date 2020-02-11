using System;
using System.Collections.Generic;

namespace compras
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creacion de las listas
            List<string> nombres = new List<string>();
            List<double> precios = new List<double>();
            int opcion = 0;
            do
            {
                //Solicitamos al usuario su opcion 
                Console.WriteLine("1)Añadir al producto al carrito\n2)Carrito \n3)Salir");
                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ingrese una número");
                    opcion = -1;
                    continue;
                }
                //Validamos la opcion del usuario
                switch (opcion)
                {
                    case 1:
                        Agregar(nombres, precios);
                        break;
                    case 2:
                        CarritoDeCompras(nombres, precios);
                        break;
                    case 3:
                        Console.WriteLine("Adiós :)");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta");
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
            } while (opcion != 3);
        }

        //Metodo para agregar productos y precios
        public static void Agregar(List<string> nombres, List<double> precios)
        {
            //Variables
            string producto;
            double costo;
            Console.WriteLine("Nombre del producto:");
            producto = Console.ReadLine();
            nombres.Add(producto);
            Console.WriteLine("Precio:");
            do
            {
                try
                {
                    costo = Convert.ToDouble(Console.ReadLine());
                    precios.Add(costo);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ingresa una número");
                    Console.ReadKey();
                }
            } while (true);
        }

        //Metodo para comprar o devolver un producto
        public static void CarritoDeCompras(List<string> nombres, List<double> precios)
        {
            //Variables
            int op;
            int indice;
            double compraTotal;

            //Mostramos los datos de la compra
            compraTotal = Info(nombres, precios);
            //Solicitamos al usuario que quiere hacer
            do
            {
                Console.WriteLine("1)Comprar\n2)Dejar productos \n3)Salir");
                try
                {
                    op = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ingresa una número");
                    break;
                }
                switch (op)
                {
                    case 1:
                        //Verificamos el total de la compra
                        if (compraTotal > 500.00)
                        {
                            Console.WriteLine("Saldo insuficiente");
                            Console.ReadKey();
                        }
                        //Si no se cumple la opcion anterior terminamos la compra
                        else
                        {
                            Console.WriteLine("Gracias por su compra!");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Eliminar producto");
                        //Muestra los productos
                        Info(nombres, precios);
                        Console.WriteLine("Indique el producto que desea eliminar");
                        indice = Convert.ToInt32(Console.ReadLine());
                        try
                        {
                            nombres.RemoveAt(indice);
                            precios.RemoveAt(indice);
                            compraTotal = Info(nombres, precios);
                            break;
                        }
                        catch (IndexOutOfRangeException)
                        {
                            Console.WriteLine("Ingrese un indice correcto");
                            Console.ReadKey();
                            break;
                        }

                    case 3:
                        Console.WriteLine("Adiós Vuelva Pronto");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta");
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
            } while (op != 3);
        }

        //Metodo que regresa el total de la compra, los productos, precios e indices
        public static double Info(List<string> nombres, List<double> precios)
        {
            //Variable
            double total = 0;
            //ciclo para ver el contenido de la compra
            for (int i = 0; i < nombres.Count; i++)
            {
                Console.WriteLine("Producto: {0}, Precio: {1} = Indice {2}", nombres[i], precios[i], i);
                total += precios[i];
            }

            return total;
        }
    }
}