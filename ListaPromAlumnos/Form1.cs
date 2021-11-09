using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaPromAlumnos
{
    public partial class Form1 : Form
    {

        public Alumno Alumnos = new Alumno();
        public PromAlum PromAlum = new PromAlum();
      
            
       // int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        //public PromAlum
        
        
        private void btCalcular_Click(object sender, EventArgs e)
        {
            //Alumnos.nota1 =
            
            decimal num1, num2, num3;
            decimal promedio;
            num1 = System.Convert.ToDecimal(txtNot1.Text);
            num2 = System.Convert.ToDecimal(txtNot2.Text);
            num3 = System.Convert.ToDecimal(txtNot3.Text);

            promedio = (num1 + num2 + num3)/3;
            lblPromedio.Text =System.Convert.ToString(promedio);
            //contador += 1;
            //PromAlum.calculatePromedio(Alumnos);
        }
        
        private void btCargar_Click(object sender, EventArgs e)
        {
            //Alumno NoAp = new Alumno();
            //NoAp.Nombre = txt1.Text;
            //NoAp.Apellido = txt2.Text;
            //lblNomComp.Text = NoAp.Apellido + " " + NoAp.Nombre;
            //Redimensionar();
            //Alumno[Alumno.Length + 1] = NoAp;

        }
       
           
       
    }
}
