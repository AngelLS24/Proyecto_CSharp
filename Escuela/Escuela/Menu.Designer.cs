using System.Windows.Forms;

namespace Escuela
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.materiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porcentajesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gruposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grupo1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grupo2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calificacionExamenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calificacionProyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calificacionTareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calificacionFinalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosAprobadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosReprobadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosTotalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LBienbenida = new System.Windows.Forms.Label();
            this.dgConsula = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.todasLasCalificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsula)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Location = new System.Drawing.Point(0, 24);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(565, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuStrip3
            // 
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.materiasToolStripMenuItem,
            this.gruposToolStripMenuItem,
            this.calificacionesToolStripMenuItem,
            this.alumnosToolStripMenuItem,
            this.opcionesToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(565, 24);
            this.menuStrip3.TabIndex = 2;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // materiasToolStripMenuItem
            // 
            this.materiasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porcentajesToolStripMenuItem});
            this.materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            this.materiasToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.materiasToolStripMenuItem.Text = "Evaluacion";
            // 
            // porcentajesToolStripMenuItem
            // 
            this.porcentajesToolStripMenuItem.Name = "porcentajesToolStripMenuItem";
            this.porcentajesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.porcentajesToolStripMenuItem.Text = "Porcentajes";
            this.porcentajesToolStripMenuItem.Click += new System.EventHandler(this.porcentajesToolStripMenuItem_Click);
            // 
            // gruposToolStripMenuItem
            // 
            this.gruposToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grupo1ToolStripMenuItem,
            this.grupo2ToolStripMenuItem});
            this.gruposToolStripMenuItem.Name = "gruposToolStripMenuItem";
            this.gruposToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.gruposToolStripMenuItem.Text = "Grupos";
            // 
            // grupo1ToolStripMenuItem
            // 
            this.grupo1ToolStripMenuItem.Name = "grupo1ToolStripMenuItem";
            this.grupo1ToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.grupo1ToolStripMenuItem.Text = "Grupo 1";
            this.grupo1ToolStripMenuItem.Click += new System.EventHandler(this.grupo1ToolStripMenuItem_Click);
            // 
            // grupo2ToolStripMenuItem
            // 
            this.grupo2ToolStripMenuItem.Name = "grupo2ToolStripMenuItem";
            this.grupo2ToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.grupo2ToolStripMenuItem.Text = "Grupo 2";
            this.grupo2ToolStripMenuItem.Click += new System.EventHandler(this.grupo2ToolStripMenuItem_Click);
            // 
            // calificacionesToolStripMenuItem
            // 
            this.calificacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calificacionExamenToolStripMenuItem,
            this.calificacionProyectoToolStripMenuItem,
            this.calificacionTareasToolStripMenuItem,
            this.calificacionFinalToolStripMenuItem,
            this.todasLasCalificacionesToolStripMenuItem});
            this.calificacionesToolStripMenuItem.Name = "calificacionesToolStripMenuItem";
            this.calificacionesToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.calificacionesToolStripMenuItem.Text = "Calificaciones";
            // 
            // calificacionExamenToolStripMenuItem
            // 
            this.calificacionExamenToolStripMenuItem.Name = "calificacionExamenToolStripMenuItem";
            this.calificacionExamenToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.calificacionExamenToolStripMenuItem.Text = "Calificacion Examen";
            this.calificacionExamenToolStripMenuItem.Click += new System.EventHandler(this.calificacionExamenToolStripMenuItem_Click);
            // 
            // calificacionProyectoToolStripMenuItem
            // 
            this.calificacionProyectoToolStripMenuItem.Name = "calificacionProyectoToolStripMenuItem";
            this.calificacionProyectoToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.calificacionProyectoToolStripMenuItem.Text = "Calificacion Proyecto";
            this.calificacionProyectoToolStripMenuItem.Click += new System.EventHandler(this.calificacionProyectoToolStripMenuItem_Click);
            // 
            // calificacionTareasToolStripMenuItem
            // 
            this.calificacionTareasToolStripMenuItem.Name = "calificacionTareasToolStripMenuItem";
            this.calificacionTareasToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.calificacionTareasToolStripMenuItem.Text = "Calificacion Tareas";
            this.calificacionTareasToolStripMenuItem.Click += new System.EventHandler(this.calificacionTareasToolStripMenuItem_Click);
            // 
            // calificacionFinalToolStripMenuItem
            // 
            this.calificacionFinalToolStripMenuItem.Name = "calificacionFinalToolStripMenuItem";
            this.calificacionFinalToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.calificacionFinalToolStripMenuItem.Text = "Calificacion Final";
            this.calificacionFinalToolStripMenuItem.Click += new System.EventHandler(this.calificacionFinalToolStripMenuItem_Click);
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnosAprobadosToolStripMenuItem,
            this.alumnosReprobadosToolStripMenuItem,
            this.alumnosTotalesToolStripMenuItem});
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            // 
            // alumnosAprobadosToolStripMenuItem
            // 
            this.alumnosAprobadosToolStripMenuItem.Name = "alumnosAprobadosToolStripMenuItem";
            this.alumnosAprobadosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.alumnosAprobadosToolStripMenuItem.Text = "Alumnos aprobados";
            this.alumnosAprobadosToolStripMenuItem.Click += new System.EventHandler(this.alumnosAprobadosToolStripMenuItem_Click);
            // 
            // alumnosReprobadosToolStripMenuItem
            // 
            this.alumnosReprobadosToolStripMenuItem.Name = "alumnosReprobadosToolStripMenuItem";
            this.alumnosReprobadosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.alumnosReprobadosToolStripMenuItem.Text = "Alumnos reprobados";
            this.alumnosReprobadosToolStripMenuItem.Click += new System.EventHandler(this.alumnosReprobadosToolStripMenuItem_Click);
            // 
            // alumnosTotalesToolStripMenuItem
            // 
            this.alumnosTotalesToolStripMenuItem.Name = "alumnosTotalesToolStripMenuItem";
            this.alumnosTotalesToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.alumnosTotalesToolStripMenuItem.Text = "Alumnos totales";
            this.alumnosTotalesToolStripMenuItem.Click += new System.EventHandler(this.alumnosTotalesToolStripMenuItem_Click);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // creditosToolStripMenuItem
            // 
            this.creditosToolStripMenuItem.Name = "creditosToolStripMenuItem";
            this.creditosToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.creditosToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.creditosToolStripMenuItem.Text = "Creditos";
            this.creditosToolStripMenuItem.Click += new System.EventHandler(this.creditosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // LBienbenida
            // 
            this.LBienbenida.AutoSize = true;
            this.LBienbenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBienbenida.Location = new System.Drawing.Point(38, 91);
            this.LBienbenida.Name = "LBienbenida";
            this.LBienbenida.Size = new System.Drawing.Size(0, 47);
            this.LBienbenida.TabIndex = 3;
            // 
            // dgConsula
            // 
            this.dgConsula.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgConsula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConsula.GridColor = System.Drawing.SystemColors.Control;
            this.dgConsula.Location = new System.Drawing.Point(12, 51);
            this.dgConsula.Name = "dgConsula";
            this.dgConsula.Size = new System.Drawing.Size(541, 140);
            this.dgConsula.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Actualizar Calificacion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // todasLasCalificacionesToolStripMenuItem
            // 
            this.todasLasCalificacionesToolStripMenuItem.Name = "todasLasCalificacionesToolStripMenuItem";
            this.todasLasCalificacionesToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.todasLasCalificacionesToolStripMenuItem.Text = "Todas las Calificaciones";
            this.todasLasCalificacionesToolStripMenuItem.Click += new System.EventHandler(this.todasLasCalificacionesToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 238);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgConsula);
            this.Controls.Add(this.LBienbenida);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem materiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gruposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calificacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.Label LBienbenida;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grupo1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grupo2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosAprobadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosReprobadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosTotalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditosToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private DataGridView dgConsula;
        private ToolStripMenuItem porcentajesToolStripMenuItem;
        private Button button1;
        private ToolStripMenuItem calificacionExamenToolStripMenuItem;
        private ToolStripMenuItem calificacionProyectoToolStripMenuItem;
        private ToolStripMenuItem calificacionTareasToolStripMenuItem;
        private ToolStripMenuItem calificacionFinalToolStripMenuItem;
        private ToolStripMenuItem todasLasCalificacionesToolStripMenuItem;
    }
}