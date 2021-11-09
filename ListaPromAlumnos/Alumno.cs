using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPromAlumnos
{
    public class Alumno 
    {
        //Propiedades
        
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public int nota1 { get; set; }

        //
        public string NombreCompleto()
        {
            return Nombre + Apellido;
        }

       
    }
    

}
