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
        public Alumno[] alumnos { get; set; }

        public DataTable DaTa { get; set; } = new DataTable();

        public PromAlum()
        {/// inicializar valores de la tabla wachin
            DaTa.TableName = "Lista de Alumnos";

        }

        //Botón de calcular
        public class Calcular
        {

        }

        // decimal num1, num2, num3;
        // decimal promedio;
        //num1 = System.Convert.ToDecimal(txtNot1.Text);
        // num2 = System.Convert.ToDecimal(txtNot2.Text);
        //num3 = System.Convert.ToDecimal(txtNot3.Text);

        //promedio = (num1 + num2 + num3)/3;
        //lblPromedio.Text = System.Convert.ToString(promedio);
        //contador += 1;


        //public PromAlum()
        //{
            /// inicializar valores de la tabla wachin
        //}

        //Botón de cargar
        public class Cargar { }
        //Botón de borrar

        //redimensionar


        public void calculatePromedio(Alumno AlumnoNotas)
        {
            /// CALCULAR PROMEDIO

        }

    }
}
