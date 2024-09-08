using System;
using System.Reflection.Emit;
using TP1_club_deportivo;

internal class Test
{
    public static void Main() { 
    
        ClubDeportivo club = new ClubDeportivo();
        club.guardarActividad("Tenis", 35);
        club.guardarActividad("Basquet", 24);
        club.guardarActividad("Natacion", 80);
        club.guardarActividad("Futbol", 110);
        club.altaSocio("Juan Perez");
        Console.WriteLine(club.inscribirActividad("Tenis", 1));
        Console.WriteLine("El cupo actualizado para " + club.ListaActividades[0].Nombre + " es " + club.ListaActividades[0].Cupo);
        Console.WriteLine(club.inscribirActividad("Basquet", 1));
        Console.WriteLine("El cupo actualizado para " + club.ListaActividades[1].Nombre + " es " + club.ListaActividades[1].Cupo);
        Console.WriteLine(club.inscribirActividad("Natacion", 1));
        Console.WriteLine("El cupo actualizado para " + club.ListaActividades[2].Nombre + " es " + club.ListaActividades[2].Cupo);
        Console.WriteLine(club.inscribirActividad("Futbol", 1));
    }
         
}
