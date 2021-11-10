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

        public Alumno Alumno = new Alumno();
        public PromAlum PromAlum = new PromAlum();
        
       
      
        public Form1()
        {
            InitializeComponent();
            DGV.DataSource = PromAlum.DaTa;
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            Alumno.nota1 = System.Convert.ToInt32(txtNot1.Text);
            Alumno.nota2 = System.Convert.ToInt32(txtNot2.Text);
            Alumno.nota3 = System.Convert.ToInt32(txtNot3.Text);
            Alumno.promedio= PromAlum.CalcularPromedio(Alumno);
            lblPromedio.Text = System.Convert.ToString(Alumno.promedio);

        }
        
        private void btCargar_Click(object sender, EventArgs e)
        {

            Alumno.Nombre = txt1.Text;
            Alumno.Apellido = txt2.Text;
            PromAlum.Cargar(Alumno);

            txt1.Text = "";
            txt2.Text = "";
            txtNot1.Text = "";
            txtNot2.Text = "";
            txtNot3.Text = "";
            lblPromedio.Text = "";

        }

        private void bt2_Click(object sender, EventArgs e)
        {
            PromAlum.Borrar();
        }
    }
}
