//instancia de club deportivo
using ConsoleApp1;

ClubDeportivo bocaJuniors = new ClubDeportivo();

Actividad newActividad = new Actividad("Futbol", 22);
Console.WriteLine("va bien");

Socio newSocio = new Socio("Alfredo","Caseros",22585655);


bocaJuniors.altaSocio(newSocio);




