using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea
{
    class Alumno
    {
        public string nombre;
        public string apPaterno;
        public int calProyecto;
        public int numTareas;
        public int numParticipaciones;

        public Alumno(string Nombre, string ApPat, int CalP, int NumT, int NumP)
        {
            this.nombre = Nombre;
            this.apPaterno = ApPat;
            this.calProyecto = CalP;
            this.numTareas = NumT;
            this.numParticipaciones = NumP;
        }

        public override string ToString()
        {
            return string.Format("Hola me llamo " + nombre);
        }
    }
}
