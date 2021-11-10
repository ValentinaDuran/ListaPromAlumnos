using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPromAlumnos
{
    public class PromAlum
    {
        public Alumno[] alumno { get; set; }

        public DataTable DaTa { get; set; } = new DataTable();

        public PromAlum()
        {
            DaTa.TableName = "Lista de Alumnos";
            DaTa.Columns.Add("Nombre");
            DaTa.Columns.Add("Apellido");
            DaTa.Columns.Add("1° Nota");
            DaTa.Columns.Add("2° Nota");
            DaTa.Columns.Add("3° Nota");
            DaTa.Columns.Add("Promedio");
            LeerDaTa_Archivo();
        }
        public void LeerDaTa_Archivo()
        {
            if (System.IO.File.Exists("Prom.xml"))
            {
                DaTa.Clear();
                DaTa.ReadXml("Prom.xml");
               
            }
        }
       
        public void Cargar (Alumno alumno) 
        {
           
            if (alumno.Nombre!="" &&
                alumno.Apellido!= ""&& 
                alumno.nota1!=0 &&
                alumno.nota2!=0 &&
                alumno.nota3!=0 &&
                alumno.promedio!=0)
            {
                DaTa.Rows.Add();
                int NuevoAlumno = DaTa.Rows.Count - 1;
                DaTa.Rows[NuevoAlumno]["Nombre"] = alumno.Nombre;
                DaTa.Rows[NuevoAlumno]["Apellido"] = alumno.Apellido;
                DaTa.Rows[NuevoAlumno]["1° Nota"] = alumno.nota1;
                DaTa.Rows[NuevoAlumno]["2° Nota"] = alumno.nota2;
                DaTa.Rows[NuevoAlumno]["3° Nota"] = alumno.nota3;
                DaTa.Rows[NuevoAlumno]["Promedio"] = alumno.promedio;
                DaTa.WriteXml("Prom.xml");
            }
        }

        //Botón de calcular
        public int CalcularPromedio (Alumno alumno)
        {
            return (alumno.nota1 + alumno.nota2 + alumno.nota3) / 3;

        }

        //Botón de borrar
        public void Borrar() 
        {
            DaTa.Rows.Clear();
            DaTa.WriteXml("Prom.xml");
        }



    }
}
