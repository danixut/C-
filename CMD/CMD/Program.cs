using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;

namespace CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salida = false;
            bool subirNivel = false;
            string destino = "";
            string usuario = Environment.UserName;
            string ruta = "C:\\Users\\" + usuario + "\\Documents";
            string prompt = "C:\\Users\\" + usuario + "\\Documents>";
            List<string> historial = new List<string>();
            System.IO.DirectoryInfo directorio = new System.IO.DirectoryInfo(ruta);

            while (!salida)
            {
                Console.Write(prompt);
                string entrada = Console.ReadLine();
                string[] entradas = new string[3];
                if (entrada.Contains(" ") || entrada.Contains(".."))
                {
                    if (entrada.Contains(" "))
                    {
                        entradas = entrada.Split(" ");
                        entrada = entradas[0];
                        historial.Add(entrada);
                        if (entradas[1].Contains("\\"))
                        {
                            ruta = entradas[1];
                            directorio = new System.IO.DirectoryInfo(ruta);
                        }
                        else if (entradas[1].Equals(".."))
                            Console.WriteLine("Ruta invalida");
                        else if (entrada.Equals("cd"))
                            directorio = new System.IO.DirectoryInfo(ruta + "\\" + entradas[1]);
                        else if (Regex.IsMatch(entradas[1], @"[a-zA-z]"))
                            ruta = entradas[1];
                        else
                            Console.WriteLine("Ruta invalida");
                        if ((entradas[2].Length > 0) && (entradas[2].Contains("\\")))
                            destino = entradas[2];
                    }
                    else if (entrada.Contains(".."))
                    {
                        subirNivel = true;
                        entrada = "cd";
                        historial.Add(entrada);
                    }
                    else
                    {
                        Console.WriteLine("Entrada Invalida");
                    }
                }
                else
                    historial.Add(entrada);

                try
                {
                    switch (entrada)
                    {
                        case "dir":
                            if (directorio.Exists)
                            {
                                System.IO.FileInfo[] fileNames = directorio.GetFiles("*.*");
                                Console.WriteLine("--------ARCHIVOS--------");
                                foreach (System.IO.FileInfo fi in fileNames)
                                {
                                    Console.WriteLine("{0}: {1}: {2}", fi.Name, fi.LastAccessTime, fi.Length);
                                }
                                System.IO.DirectoryInfo[] dirInfos = directorio.GetDirectories("*.*");
                                Console.WriteLine("--------CARPETAS--------");
                                foreach (System.IO.DirectoryInfo d in dirInfos)
                                {
                                    Console.WriteLine(d.Name);
                                }
                            }
                            else
                            {
                                Console.WriteLine("El directorio ingresado no existe");
                                break;
                            }
                            break;
                        case "cd":
                            if (subirNivel)
                            {
                                if (directorio.Parent.Exists)
                                {
                                    prompt = directorio.Parent.ToString() + ">";
                                    directorio = directorio.Parent;
                                    subirNivel = false;
                                }
                                else
                                {
                                    Console.WriteLine("No se puede subir mas");
                                    break;
                                }
                            }
                            else
                            {
                                if (directorio.Exists)
                                {
                                    prompt = directorio.ToString() + ">";
                                }
                                else
                                {
                                    Console.WriteLine("El directorio ingreado no existe");
                                    break;
                                }
                            }
                            break;
                        case "touch":
                            if (ruta.Contains(".txt"))
                            {
                                if (directorio.Exists)
                                {
                                    if (File.Exists(directorio.ToString() + "\\" + ruta))
                                        Console.WriteLine("El archivo ya existe");
                                    else
                                    {
                                        File.WriteAllText(directorio.ToString() + "\\" + ruta, "");
                                        Console.WriteLine("Archivo creado con exito");
                                    }
                                }
                                else
                                {
                                    System.IO.DirectoryInfo directorioPa = directorio.Parent;
                                    if (directorioPa.Exists)
                                    {
                                        if (File.Exists(directorio.ToString()))
                                            Console.WriteLine("El archivo ya existe");
                                        else
                                        {
                                            File.WriteAllText(directorio.ToString(), "");
                                            Console.WriteLine("Archivo creado con exito");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("El directorio ingreado no existe");
                                        break;
                                    }
                                }
                                break;
                            }
                            else
                            {
                                Console.WriteLine("No se especifco un nombre valido para el archivo");
                            }
                            break;
                        case "move":
                            // C:\Users\drago\Documents\hola.txt C:\Users\drago\Documents\Rodro\hola.txt
                            if (destino.Length > 0)
                            {
                                if (File.Exists(ruta))
                                {
                                    System.IO.DirectoryInfo directorioD = new System.IO.DirectoryInfo(destino);
                                    System.IO.DirectoryInfo directorioPa = directorioD.Parent;
                                    if (directorioPa.Exists)
                                    {
                                        if (!File.Exists(destino))
                                        {
                                            File.Move(directorio.ToString(), directorioD.ToString());
                                            File.Delete(directorio.ToString());
                                            Console.WriteLine("Archivo movido con exito a {0}", directorioPa.ToString());
                                        }
                                        else
                                            Console.WriteLine("Ya existe un archivo con ese nombre en la ubicacion destino");
                                    }
                                    else
                                        Console.WriteLine("El directorio ingreado no existe");
                                }
                                else
                                    Console.WriteLine("El archivo indicado no existe");
                            }
                            else
                            {
                                Console.WriteLine("No se especifico una ruta destino");
                            }
                            break;
                        case "history":
                            foreach (var elemento in historial)
                                Console.WriteLine(elemento);
                            break;
                        case "cls":
                            Console.Clear();
                            break;
                        case "exit":
                            salida = true;
                            break;
                        default:
                            Console.WriteLine("Instruccion desconocida");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("FATAL ERROR");
                }
            }
            Console.ReadKey();
        }
    }
}
