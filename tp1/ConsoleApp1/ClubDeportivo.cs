using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ConsoleApp1
{
    internal class ClubDeportivo
    {
        private List<Socio> socios = new List<Socio>();
        private List<Actividad> actividades = new List<Actividad>();

        public void altaSocio(Socio newSocio)
        {
            if(!socios.Exists(socio => socio.Dni == newSocio.Dni))
            {
                socios.Add(newSocio);
                Console.WriteLine($"El socio {newSocio.Nombre} se registró exitosamente");
            }
            else
            {
                Console.WriteLine($"El socio {newSocio.Nombre} ya existe");
            }
        }

        public string inscribirActividad(Actividad actividad)
        {
            if (!actividades.Exists(item => item.Nombre == actividad.Nombre))
            {
                actividades.Add(actividad);
                return $"La actividad {actividad.Nombre} se registró exitosamente";
            }
                return $"La actividad {actividad.Nombre} ya existe";
        }

        public string inscribirActividad(string nombreActividad, int dni)
        {
            Socio ? socioAInscribir = socios.Find(el => el.Dni == dni);
            Actividad ? actividadAInscribir = actividades.Find(el => el.Nombre == nombreActividad);
            if (socioAInscribir == null)
            {
                return "SOCIO INEXISTENTE";
            }
            if (actividadAInscribir == null)
            {
                return "ACTIVIDAD INEXISTENTE";
            }
            if(socioAInscribir.ActividadesInscriptas.Exists(el => el == nombreActividad))
            {
                return $"EL SOCIO {socioAInscribir.Nombre} YA SE ENCUENTRA INSCRIPTO EN {nombreActividad}";
            }
            if(actividadAInscribir.Cupos == 0)
            {
                return "NO QUEDAN MAS CUPOS PARA ESA ACTIVIDAD";
            }
            if (socioAInscribir.ActividadesInscriptas.Count >= 3)
            {
                return "TOPE DE ACTIVIDADES ALCANZADO";
            }
            socioAInscribir.ActividadesInscriptas.Add(nombreActividad);
            actividadAInscribir.Cupos--;
            return "INSCRIPCIÓN EXITOSA";
        }
    }
}
