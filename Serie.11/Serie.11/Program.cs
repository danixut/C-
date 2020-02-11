using System;

namespace Serie._11
{
    class Program
    {
        static class MatrizN
        {
            //Se almacenan los valores en las matrices
            static public void Valores(ref double[,] matriz){
                //Ciclos para la lectura de archivos
                for (int i = 0; i < Math.Sqrt(matriz.Length); i++){
                    for (int j = 0; j < Math.Sqrt(matriz.Length); j++){
                        int bandera = 0;
                        do{
                            try
                            {
                                // Se valida que el valor ingresado sea un numero
                                Console.WriteLine("Ingrese el valor [{0},{1}]", i, j);
                                //Casteo de los valos ingresados
                                matriz[i, j] = Convert.ToDouble(Console.ReadLine());
                                bandera = 1;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Escribe un valor valido " + e.Message);
                            }
                        } while (bandera == 0);

                    }
                }
            }
            // Funcion para imprimir las matrices
            static public void Imprimir(ref double[,] matriz)
            {
                double tamano = Math.Sqrt(matriz.Length);
                for (int i = 0; i < tamano; i++){
                    for (int j = 0; j < tamano; j++){
                        Console.Write(" " + matriz[i, j]);
                    }
                    Console.WriteLine("\n");
                }
            }
            // Funcion que Suma
            static public void Suma(ref double[,] ma1, ref double[,] ma2)
            {
                double tam = Math.Sqrt(ma1.Length);
                for (int i = 0; i < tam; i++){
                    for (int j = 0; j < tam; j++){
                        Console.Write(" " + (ma1[i, j] + ma2[i, j]));
                    }
                    Console.WriteLine();
                }
            }
            // Funcion que resta
            static public void Resta(ref double[,] ma1, ref double[,] ma2)
            {
                double tamano = Math.Sqrt(ma1.Length);
                for (int i = 0; i < tamano; i++){
                    for (int j = 0; j < tamano; j++){
                        Console.Write(" " + (ma1[i, j] - ma2[i, j]));
                    }
                    Console.WriteLine();
                }
            }
            // Funcion que multiplica
            static public void MultiplicaMatrices(ref double[,] ma1, ref double[,] ma2)
            {
                double respuesta;
                double tamano = Math.Sqrt(ma1.Length);
                for (int i = 0; i < tamano; i++){
                    for (int j = 0; j < tamano; j++){
                        respuesta = 0;
                        for (int k = 0; k < tamano; k++){
                            respuesta += ma1[i, k] * ma2[k, j];
                        }
                        Console.Write(" " + respuesta);
                    }
                    Console.WriteLine();
                }
            }
            // Funcion menu
            static public int Menu()
            {
                Console.WriteLine("1)Suma");
                Console.WriteLine("2)Resta");
                Console.WriteLine("3)Multiplicacion");
                try
                {
                    return Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Solo enteros");
                    return 0;
                }
            }
        }
        static void Main(string[] args)
        {
            int opcion = 0;
            double[,] ma1 = new double[0,0];
            double[,] ma2 = new double[0, 0];
            try
            {
                Console.Write("Escribe el tamaño de las matrices: ");
                // Se lee el tamaño de las matrices
                int tam = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Valores de la Matriz 1");
                // Solicitamos los varlores para llenar la matriz
                ma1 = new double[tam, tam];
                // Se almacenan los valores de la matriz
                MatrizN.Valores(ref ma1);
                Console.WriteLine("Valores de la Matriz 2");
                ma2 = new double[tam, tam];
                MatrizN.Valores(ref ma2);
                // Se lee el valor del menu
                opcion = MatrizN.Menu();
                //Se muestran los valores de las matrices
                Console.WriteLine("Matriz 1:");
                MatrizN.Imprimir(ref ma1);
                Console.WriteLine("Matriz 2:");
                MatrizN.Imprimir(ref ma2);
                Console.WriteLine("\n");
            }
            catch (FormatException) { 
                Console.WriteLine("ERROR");
            }
            //Se evalua la opcion
            switch (opcion)
            {
                case 0:
                    Console.WriteLine("Opcion Invalida");
                    break;
                case 1:
                    //Se usa le metodo suma
                    MatrizN.Suma(ref ma1, ref ma2);
                    break;
                case 2:
                    //Se usa le metodo resta
                    MatrizN.Resta(ref ma1, ref ma2);
                    break;
                case 3:
                    //Se usa le metodo multiplicacion
                    MatrizN.MultiplicaMatrices(ref ma1, ref ma2);
                    break;
            }
            Console.ReadKey();
        }
    }
}
