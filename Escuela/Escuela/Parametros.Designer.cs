namespace Escuela
{
    partial class Parametros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parametros));
            this.txBanner = new System.Windows.Forms.Label();
            this.txParam = new System.Windows.Forms.Label();
            this.txProy = new System.Windows.Forms.Label();
            this.txExam = new System.Windows.Forms.Label();
            this.txTarea = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbProyectoPercent = new System.Windows.Forms.TextBox();
            this.tbExamPercent = new System.Windows.Forms.TextBox();
            this.tbTareaPercent = new System.Windows.Forms.TextBox();
            this.btParam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txBanner
            // 
            this.txBanner.AutoSize = true;
            this.txBanner.Location = new System.Drawing.Point(27, 32);
            this.txBanner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txBanner.Name = "txBanner";
            this.txBanner.Size = new System.Drawing.Size(101, 13);
            this.txBanner.TabIndex = 0;
            this.txBanner.Text = "Bienvenido profesor";
            // 
            // txParam
            // 
            this.txParam.AutoSize = true;
            this.txParam.Location = new System.Drawing.Point(29, 67);
            this.txParam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txParam.Name = "txParam";
            this.txParam.Size = new System.Drawing.Size(299, 13);
            this.txParam.TabIndex = 1;
            this.txParam.Text = "Ingrese los parámetros de evaluacion de los siguientes rubros:";
            // 
            // txProy
            // 
            this.txProy.AutoSize = true;
            this.txProy.Location = new System.Drawing.Point(72, 128);
            this.txProy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txProy.Name = "txProy";
            this.txProy.Size = new System.Drawing.Size(54, 13);
            this.txProy.TabIndex = 2;
            this.txProy.Text = "Proyectos";
            // 
            // txExam
            // 
            this.txExam.AutoSize = true;
            this.txExam.Location = new System.Drawing.Point(72, 168);
            this.txExam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txExam.Name = "txExam";
            this.txExam.Size = new System.Drawing.Size(56, 13);
            this.txExam.TabIndex = 3;
            this.txExam.Text = "Examenes";
            // 
            // txTarea
            // 
            this.txTarea.AutoSize = true;
            this.txTarea.Location = new System.Drawing.Point(72, 205);
            this.txTarea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txTarea.Name = "txTarea";
            this.txTarea.Size = new System.Drawing.Size(40, 13);
            this.txTarea.TabIndex = 4;
            this.txTarea.Text = "Tareas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 110);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Porcentaje";
            // 
            // tbProyectoPercent
            // 
            this.tbProyectoPercent.Location = new System.Drawing.Point(184, 126);
            this.tbProyectoPercent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbProyectoPercent.MaxLength = 3;
            this.tbProyectoPercent.Name = "tbProyectoPercent";
            this.tbProyectoPercent.Size = new System.Drawing.Size(76, 20);
            this.tbProyectoPercent.TabIndex = 7;
            // 
            // tbExamPercent
            // 
            this.tbExamPercent.Location = new System.Drawing.Point(184, 166);
            this.tbExamPercent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbExamPercent.MaxLength = 3;
            this.tbExamPercent.Name = "tbExamPercent";
            this.tbExamPercent.Size = new System.Drawing.Size(76, 20);
            this.tbExamPercent.TabIndex = 8;
            // 
            // tbTareaPercent
            // 
            this.tbTareaPercent.Location = new System.Drawing.Point(184, 202);
            this.tbTareaPercent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTareaPercent.MaxLength = 3;
            this.tbTareaPercent.Name = "tbTareaPercent";
            this.tbTareaPercent.Size = new System.Drawing.Size(76, 20);
            this.tbTareaPercent.TabIndex = 9;
            // 
            // btParam
            // 
            this.btParam.Location = new System.Drawing.Point(134, 249);
            this.btParam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btParam.Name = "btParam";
            this.btParam.Size = new System.Drawing.Size(62, 23);
            this.btParam.TabIndex = 13;
            this.btParam.Text = "Continuar";
            this.btParam.UseVisualStyleBackColor = true;
            this.btParam.Click += new System.EventHandler(this.btParam_Click);
            // 
            // Parametros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 297);
            this.Controls.Add(this.btParam);
            this.Controls.Add(this.tbTareaPercent);
            this.Controls.Add(this.tbExamPercent);
            this.Controls.Add(this.tbProyectoPercent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txTarea);
            this.Controls.Add(this.txExam);
            this.Controls.Add(this.txProy);
            this.Controls.Add(this.txParam);
            this.Controls.Add(this.txBanner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Parametros";
            this.Text = "Parametros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txBanner;
        private System.Windows.Forms.Label txParam;
        private System.Windows.Forms.Label txProy;
        private System.Windows.Forms.Label txExam;
        private System.Windows.Forms.Label txTarea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbProyectoPercent;
        private System.Windows.Forms.TextBox tbExamPercent;
        private System.Windows.Forms.TextBox tbTareaPercent;
        private System.Windows.Forms.Button btParam;
    }
}