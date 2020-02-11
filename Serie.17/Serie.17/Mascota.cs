using System;
using System.Collections.Generic;
using System.Text;

namespace Serie._17
{
    //Creacion de la interfaz mascota y creacion de los metodos e una mascota(Comer,jugar,dormir, y saber su nombre)
    interface Mascota
    {
        public string nombre();
        public void comer();
        public void jugar();
        public void dormir();
    }
}
