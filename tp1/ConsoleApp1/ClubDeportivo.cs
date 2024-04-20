using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                foreach(Socio socio in socios)
                {
                    Console.WriteLine(socio.Nombre);
                }
            }
            else
            {
                Console.WriteLine($"El socio {newSocio.Nombre} ya existe");
            }
        }

        public void inscribirActividad(Actividad actividad)
        {
            if (!actividades.Exists(item => item.Nombre == actividad.Nombre))
            {
                actividades.Add(actividad);
                Console.WriteLine($"La actividad {actividad.Nombre} se registró exitosamente");
                Console.WriteLine(actividades);
            }
            else
            {
                Console.WriteLine($"La actividad {actividad.Nombre} ya existe");
            }
        }

        public void inscribirActividad(string actividadAInscribir, int dni)
        {
            
        }
    }
}
