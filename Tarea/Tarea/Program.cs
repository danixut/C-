using System;

namespace Tarea
{
    class Program
    {

        static double Calculadora(int CalP, int NumT, int NumP)
        {
            double punProyecto = CalP * 0.6;
            double punTareas = 0;
            bool Participaciones = false;
            double punParticipacion = 0.8;
            double CaliFinal;            
                if (NumT == 5)
                    punTareas = 4;
                else
                    punTareas = (NumT * 4) / 5;            
            if (NumP < 5)
            {
                Participaciones = true;
            }
            if (Participaciones)
                CaliFinal = punProyecto + punTareas + punParticipacion;
            else
                CaliFinal = punProyecto + punTareas;
            if (CaliFinal > 10)
                return 10;
            else
                return CaliFinal;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el numero de alumnos a calificar");
            int numAl = Convert.ToInt32(Console.ReadLine());
            Alumno[] alumnos = new Alumno[numAl];

            for (int i = 0; i < alumnos.Length; i++)
            {
                Console.WriteLine("Ingrese el nombre del Alumno:");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el apellido del Alumno:");
                string apPaterno = Console.ReadLine();
                Console.WriteLine("Ingrese la calificacion del Proyecto:");
                int calProyecto = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el numero de Tareas:");
                int numTareas = Convert.ToInt32(Console.ReadLine());
                if (numTareas > 5)
                {                    
                        Console.WriteLine("Las tareas ingresadas son mas de las que deberian");
                        Console.WriteLine("Ingrese el numero de Tareas:");
                        numTareas = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Ingrese el numero de Participaciones:");
                int numParticipaciones = Convert.ToInt32(Console.ReadLine());
                alumnos[i] = new Alumno(nombre, apPaterno, calProyecto, numTareas, numParticipaciones);
            }
            double calificacion;
            foreach (var alumno in alumnos)
            {
                calificacion = Calculadora(alumno.calProyecto,alumno.numTareas,alumno.numParticipaciones);
                Console.WriteLine("La calificiacion de "+alumno.nombre+" es: {0:0.00}",calificacion);
                
            }
            Console.ReadKey();
        }
    }
}
