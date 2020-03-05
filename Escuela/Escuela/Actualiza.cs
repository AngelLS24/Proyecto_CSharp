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
    public partial class Actualiza : Form
    {
        public double examen;
        public double proyecto;
        public double tareas;
        public double res;
        protected SqlConnection conect;
        public Actualiza(SqlConnection conexion, double Examen, double Proyecto, double Tareas)
        {
            InitializeComponent();
            conect = conexion;
            examen = Examen;
            proyecto = Proyecto;
            tareas = Tareas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string f_ex = "0", f_pr = "0", f_ta = "0", cuenta = "0";
            // Valida que se ingrese algo en el campo de numero de cuenta
            if (String.IsNullOrEmpty(tbCuenta.Text))
            {
                MessageBox.Show("Se debe ingresar un numero de cuenta", "Error Actualizacion");
            }
            else
            {
                // Guarga el numero de cuenta
                cuenta = tbCuenta.Text;
                // Valida que se ingrese algun valor en los Textboxes
                if (String.IsNullOrEmpty(tbExamen.Text) && String.IsNullOrEmpty(tbProyecto.Text) && String.IsNullOrEmpty(tbTareas.Text))
                {
                    MessageBox.Show("Se debe ingresar algun valor", "Error Actualizacion");
                }
                else
                {
                    // Valida que no este vacio
                    if (!String.IsNullOrEmpty(tbExamen.Text))
                    {
                        // Valida que sea numero
                        if (Validacion(tbExamen.Text))
                        {
                            // Actualiza el campo
                            UpdateField(conect, "cal_examen", tbExamen.Text, tbCuenta.Text);
                            f_ex = tbExamen.Text;
                        }
                    }
                    // Valida que no este vacio
                    if (!String.IsNullOrEmpty(tbProyecto.Text))
                    {
                        // Valida que sea numero
                        if (Validacion(tbProyecto.Text))
                        {
                            // Actualiza el campo
                            UpdateField(conect, "cal_proyecto", tbProyecto.Text, tbCuenta.Text);
                            f_pr = tbProyecto.Text;
                        }
                    }
                    // Valida que no este vacio
                    if (!String.IsNullOrEmpty(tbTareas.Text))
                    {
                        // Valida que sea numero
                        if (Validacion(tbTareas.Text))
                        {
                            // Actualiza el campo
                            UpdateField(conect, "cal_tareas", tbTareas.Text, tbCuenta.Text);
                            f_ta = tbTareas.Text;
                        }
                    }
                }
            }
            // Valida que se ingreso un numero de cuenta diferente de 0
            if(cuenta != "0")
                CalFinal(conect, cuenta, f_ex, f_pr, f_ta); // Llama a la funcion para que calcule la calificacion final
            // Limpia los textbox
            tbProyecto.Clear();
            tbExamen.Clear();
            tbTareas.Clear();

        }

        private bool Validacion(string numero)
        {
            try
            {
                Convert.ToDouble(numero);    //Si falla la conversion
                // Validacion de datos
                if (Convert.ToDouble(numero) >= 0 && Convert.ToDouble(numero) <= 10)
                    return true;
                else
                    return false;
            }
            catch (FormatException)
            {
                MessageBox.Show("Datos Invalidos, debe ingresar puros numeros", "Evaluacion");
                return false;
            }
        }

        private static void UpdateField(SqlConnection conect, string campo, string valor, string cuenta)
        {
            // Genera query update
            string query = "UPDATE alumnos SET " + campo + " = " + valor + " WHERE cuenta = " + cuenta;
            // Abre la conexion a la base de datos
            conect.Open();
            // Crea un nuevo comando
            SqlCommand command = new SqlCommand(query, conect);
            try
            {
                // Ejecuta el query
                command.ExecuteNonQuery();
                // Cierra la conexion
                conect.Close();
                MessageBox.Show("Informacion del campo " + campo + " Actualizada", "Actualizacion");
            }
            catch (SqlException)
            {
                MessageBox.Show("No se pudo actualizar el campo " + campo, "Actualizacion");
                // Cierra la conexion
                conect.Close();
            }
            finally
            {
                if (conect.State == ConnectionState.Open)
                    conect.Close();
            }
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            // Cierra la ventana
            this.Close();
        }

        private void CalFinal(SqlConnection conect, string cuenta, string cExamen, string cProyecto, string cTareas)
        {
            // Realiza el calculo de la calificacion final en base a los porcentajes ingresados
            double final = double.Parse(cExamen) * (examen / 100.0) + double.Parse(cProyecto) * (proyecto / 100) + double.Parse(cTareas) * (tareas / 100);
            // Actualiza el regsitro de la calificacion final
            UpdateField(conect, "cal_final", final.ToString(), cuenta);
        }
    }
}
