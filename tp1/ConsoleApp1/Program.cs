using ConsoleApp1;

ClubDeportivo bocaJuniors = new ClubDeportivo();

Actividad futbol = new Actividad("Futbol", 0);
Actividad basquet = new Actividad("Basquet", 10);
Actividad boxeo = new Actividad("Boxeo", 10);
Actividad voley = new Actividad("Voley", 10);
Actividad hockey = new Actividad("Hockey", 10);
Actividad gimnasio = new Actividad("Gimnasio", 10);

Socio newSocio = new Socio("Alfredo","Caseros",22585655);
Socio newSocio2 = new Socio("Diego", "Capusotto",25556425);


//se registran nuevas actividades en el club
Console.WriteLine(bocaJuniors.inscribirActividad(futbol));
Console.WriteLine(bocaJuniors.inscribirActividad(basquet));
Console.WriteLine(bocaJuniors.inscribirActividad(voley));
Console.WriteLine(bocaJuniors.inscribirActividad(hockey));
Console.WriteLine(bocaJuniors.inscribirActividad(gimnasio));


//se registra al socio en el club
bocaJuniors.altaSocio(newSocio);

//se intenta inscribir al socio en una actividad no registrada en el club
//se usó sobrecarga de metodos
Console.WriteLine(bocaJuniors.inscribirActividad(boxeo.Nombre, newSocio.Dni));

//se intenta inscribir al socio en una actividad sin cupos disponibles
Console.WriteLine(bocaJuniors.inscribirActividad(futbol.Nombre, newSocio.Dni));

//se intenta inscribir a un socio no registrado en el club a una actividad
Console.WriteLine(bocaJuniors.inscribirActividad(futbol.Nombre, newSocio2.Dni));

//se inscribe exitosamente al socio en tres actividades
Console.WriteLine(bocaJuniors.inscribirActividad(basquet.Nombre, newSocio.Dni));
Console.WriteLine(bocaJuniors.inscribirActividad(gimnasio.Nombre, newSocio.Dni));

//se intenta inscribir en una actividad que ya estaba inscripto
Console.WriteLine(bocaJuniors.inscribirActividad(gimnasio.Nombre, newSocio.Dni));
Console.WriteLine(bocaJuniors.inscribirActividad(voley.Nombre, newSocio.Dni));

// se intenta sobrepasar el cupo de tres actividades por socio
Console.WriteLine(bocaJuniors.inscribirActividad(hockey.Nombre, newSocio.Dni));






