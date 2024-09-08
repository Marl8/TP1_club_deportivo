﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TP1_club_deportivo
{
    internal class ClubDeportivo
    {
        public List<Socio> ListaSocios { get; }
        public List<Actividad> ListaActividades { get; }

        public ClubDeportivo()
        {
            this.ListaSocios = new List<Socio>();
            this.ListaActividades = new List<Actividad>();
        }

        private bool validarExistenciaSocio(string nombre)
        {
            bool existe = false;
            if (nombre != "" && this.ListaSocios.Count > 0)
            {
                for (int i = 0; i < this.ListaSocios.Count; i++)
                {
                    if (this.ListaSocios[i].Nombre.Equals(nombre))
                    {
                        existe = true;
                        break;
                    }
                }
            }
            return existe;
        }

        public bool altaSocio(string nombre)
        {
            bool guardado = false;
            if (!validarExistenciaSocio(nombre))
            {
                int id = this.ListaSocios.Count + 1;
                Socio socio = new Socio(id, nombre);
                ListaSocios.Add(socio);
                guardado = true;
            }
            return guardado;
        }

        private bool validarActividad(string nombreActividad)
        {
            bool existe = false;
            if (nombreActividad != "" && this.ListaActividades.Count > 0)
            {
                for (int i = 0; i < this.ListaSocios.Count; i++)
                {
                    if (this.ListaActividades[i].Nombre.Equals(nombreActividad))
                    {
                        existe = true;
                        break;
                    }
                }
            }
            return existe;
        }

        public bool guardarActividad(string nombre, int cupo)
        {
            bool guardado = false;
            if (!validarActividad(nombre))
            {
                Actividad actividad = new Actividad(nombre, cupo);
                this.ListaActividades.Add(actividad);
                guardado = true;
            }
            return guardado;
        }

        public string inscribirActividad(string nombreAct, int idSocio)
        {
            string mensaje = "";
            Socio socio = buscarSocio(idSocio);
            Actividad actividad = buscarActividad(nombreAct);

            if (socio == null) {
                mensaje = "SOCIO INEXISTENTE";
            }

            if (actividad == null) {
                mensaje = "ACTIVIDAD INEXISTENTE";
            }
           
            if (socio != null && actividad != null && socio.actividades.Count < 3)
            {
                socio.actividades.Add(actividad);
                actividad.Cupo = actividad.Cupo - 1;
                mensaje = "INSCRIPCIÓN EXITOSA";
            }else if(socio.actividades.Count <= 3)
            {
                mensaje = "TOPE DE ACTIVIDADES ALCANZADO";
            }
            return mensaje;
        }

        private Socio buscarSocio(int id) {

            Socio? socio = null;
            for(int i = 0; i < this.ListaSocios.Count; i++)
            {
                if (this.ListaSocios[i].Id == id)
                {
                    socio = this.ListaSocios[i];
                    break;
                }
            }
            return socio;
        }

        private Actividad buscarActividad(string nombre)
        {
            Actividad? actividad = null;
            for (int i = 0; i < this.ListaActividades.Count; i++)
            {
                if (this.ListaActividades[i].Nombre.Equals(nombre))
                {
                    actividad = this.ListaActividades[i];
                    break;
                }
            }
            return actividad;
        }
    }
}     

