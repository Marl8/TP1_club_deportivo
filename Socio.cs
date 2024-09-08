using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_club_deportivo
{
    internal class Socio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Actividad> actividades;

        public Socio(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
            this.actividades = new List <Actividad>();
        }

        public override string ToString()
        {
            return "Socio:{" +
                "Id: " + this.Id +
                ", nombre: " + this.Nombre +
                "}";
        }
    }
}
