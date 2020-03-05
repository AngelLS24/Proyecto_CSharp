using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escuela
{
    public partial class Menu : Form
    {
        protected SqlConnection conexion;
        public double examen;
        public double proyecto;
        public double tareas;
        public Menu(string usuario, SqlConnection conect, double Examen, double Proyecto, double Tareas)
        {
            InitializeComponent();
            conexion = conect;
            examen = Examen;
            proyecto = Proyecto;
            tareas = Tareas;
        }

        private void creditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tElaborado por:\n\n\tCastillo Alan\n\tLiberos Angel\n\tMartinez Antonio\t", "Creditos");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void porcentajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string evaluacion = "Examen:   " + examen + " %\n" +
                "Proyecto: " + proyecto + " %\n" +
                "Tareas:   " + tareas + " %";
            MessageBox.Show(evaluacion, "Forma de evaluar");
        }
        // Bloque de consultas a la base de datos
        private void grupo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ejecuta("SELECT cuenta, ap_paterno, ap_materno, nombre FROM alumnos WHERE grupo = 1 ORDER BY ap_paterno");
        }

        private void grupo2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ejecuta("SELECT cuenta, ap_paterno, ap_materno, nombre FROM alumnos WHERE grupo = 2 ORDER BY ap_paterno");
        }

        private void alumnosAprobadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ejecuta("SELECT cuenta, ap_paterno, ap_materno, nombre, cal_final FROM alumnos WHERE cal_final > 5 ORDER BY ap_paterno");
        }

        private void alumnosReprobadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ejecuta("SELECT cuenta, ap_paterno, ap_materno, nombre, cal_final FROM alumnos WHERE cal_final < 6 ORDER BY ap_paterno");
        }

        private void alumnosTotalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ejecuta("SELECT cuenta, ap_paterno, ap_materno, nombre FROM alumnos ORDER BY ap_paterno");
        }

        private void calificacionExamenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ejecuta("SELECT cuenta, ap_paterno, ap_materno, nombre, cal_examen FROM alumnos ORDER BY ap_paterno");
        }

        private void calificacionProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ejecuta("SELECT cuenta, ap_paterno, ap_materno, nombre, cal_proyecto FROM alumnos ORDER BY ap_paterno");
        }

        private void calificacionTareasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ejecuta("SELECT cuenta, ap_paterno, ap_materno, nombre, cal_tareas FROM alumnos ORDER BY ap_paterno");
        }

        private void calificacionFinalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ejecuta("SELECT cuenta, ap_paterno, ap_materno, nombre, cal_final FROM alumnos ORDER BY ap_paterno");
        }

        private void todasLasCalificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ejecuta("SELECT cuenta, ap_paterno, ap_materno, nombre, cal_examen, cal_proyecto, cal_tareas, cal_final FROM alumnos ORDER BY ap_paterno");
        }
        // Funcion que ejecuta cada query, recibe una consulta
        private void ejecuta(string query)
        {
            conexion.Open();
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataAdapter adaptor = new SqlDataAdapter();
            adaptor.SelectCommand = command;
            DataTable tabla = new DataTable();
            adaptor.Fill(tabla);
            dgConsula.DataSource = tabla;
            conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Actualiza actualiza = new Actualiza(conexion, examen, proyecto, tareas);
            actualiza.Show();
        }
    }
}
