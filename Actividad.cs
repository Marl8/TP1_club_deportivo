using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_club_deportivo
{
    internal class Actividad
    {
        public string Nombre {  get; set; }
        public int Cupo {  get; set; }

        public Actividad(string nombre, int cupo)
        {
            Nombre = nombre;
            Cupo = cupo;
        }
    }
}
