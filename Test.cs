using System;
using TP1_club_deportivo;

internal class Test
{
    public static void Main() { 
    
        // Creamos lo Objetos
        ClubDeportivo club = new ClubDeportivo();
        club.guardarActividad("Tenis", 35);
        club.guardarActividad("Basquet", 24);
        club.guardarActividad("Natacion", 80);
        club.guardarActividad("Futbol", 110);
        club.altaSocio("Juan Perez");
        club.altaSocio("Sergio Gonzalez");

        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine("CLUB DEPORTIVO");
        Console.WriteLine("-------------------------------------------------------\n");
        
        Console.WriteLine("Se ha inscripto el socio: " + club.ListaSocios[0]);
        Console.WriteLine("Se ha inscripto el socio: " + club.ListaSocios[1]);
        Console.WriteLine("-------------------------------------------------------\n");

        // Inscribimos al socio en las actividades.
        Console.WriteLine(club.inscribirActividad("Tenis", 1));
        Console.WriteLine("El cupo actualizado para " + club.ListaActividades[0].Nombre + " es " + club.ListaActividades[0].Cupo);
        Console.WriteLine(club.inscribirActividad("Basquet", 1));
        Console.WriteLine("El cupo actualizado para " + club.ListaActividades[1].Nombre + " es " + club.ListaActividades[1].Cupo);
        Console.WriteLine("-------------------------------------------------------\n");

        // Socio y actividad inexistente.
        Console.WriteLine(club.inscribirActividad("N", 1));
        Console.WriteLine(club.inscribirActividad("Natacion", 0));
        Console.WriteLine("-------------------------------------------------------\n");

        Console.WriteLine(club.inscribirActividad("Natacion", 1));
        Console.WriteLine(club.inscribirActividad("Basquet", 2));
        Console.WriteLine("El cupo actualizado para " + club.ListaActividades[2].Nombre + " es " + club.ListaActividades[2].Cupo);
        Console.WriteLine("El cupo actualizado para " + club.ListaActividades[1].Nombre + " es " + club.ListaActividades[1].Cupo);
        Console.WriteLine("-------------------------------------------------------\n");

        // Excede el límite de actividades permitido.
        Console.WriteLine(club.inscribirActividad("Futbol", 1));
        Console.WriteLine("-------------------------------------------------------\n");
    }
         
}
