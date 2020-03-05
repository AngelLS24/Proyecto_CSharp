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
    public partial class Parametros : Form
    {
        //Variables de evaluacion
        public double examenPercent;
        public double proyectoPercent;
        public double tareasPercent;

        public double porcent = 100;

        public string user;
        public SqlConnection conect;

        //Para validación de datos
        Boolean flag = true;
        public Parametros(string usuario, SqlConnection conexion)
        {
            user = usuario;
            conect = conexion;
            InitializeComponent();
        }

        private void btParam_Click(object sender, EventArgs e)
        {

            if (Validacion(tbExamPercent.Text) && Validacion(tbProyectoPercent.Text) && Validacion(tbTareaPercent.Text))
            {
                // Guardamos datos del porcentaje del examen
                examenPercent = Convert.ToInt32(tbExamPercent.Text);
                proyectoPercent = Convert.ToInt32(tbProyectoPercent.Text);
                tareasPercent = Convert.ToInt32(tbTareaPercent.Text);
                // Calculamos el porcentaje
                double evalua = porcent - examenPercent - proyectoPercent - tareasPercent;
                // Valida que el porcentaje sea correcto
                if (evalua == 0)
                    flag = true;
                else if (evalua < 0)
                {
                    flag = false;
                    MessageBox.Show("La evaluacion es sobre 100%, no puede rebasar ese porcentaje", "Evaluacion");
                } else if (evalua < 100 && evalua > 0)
                {
                    flag = false;
                    MessageBox.Show("La evaluacion es sobre 100%, no puede ser menor a eso" + evalua, "Evaluacion");
                }
                    
            }
            else
                flag = false;
            
            //Lanzamos la siguiente ventana si los valores son válidos
            if (flag)
            {
                MessageBox.Show("Evaluacion asignada", "Evaluacion");
                //Lanzamos la form siguiente
                Menu Menu = new Menu(user, conect, examenPercent, proyectoPercent, tareasPercent);
                Menu.Visible = true;
                Visible = false;
                //Cerramos la ventana actual
                //this.Dispose();
            }
            else
            {
                // Limpiamos las textboxes
                tbProyectoPercent.Clear();
                tbExamPercent.Clear();
                tbTareaPercent.Clear();
            }
        }

        private bool Validacion(string numero)
        {
            try
            {
                Convert.ToInt32(numero);    //Si falla la conversion
                // Validacion de datos
                if (Convert.ToInt32(numero) >= 0 && Convert.ToInt32(numero) <= 100)
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
    }
}
