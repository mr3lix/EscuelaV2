namespace EscuelaPowert
{
    partial class Frmenu
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
            this.btnmaterias = new System.Windows.Forms.Button();
            this.btnactividades = new System.Windows.Forms.Button();
            this.btngrupo = new System.Windows.Forms.Button();
            this.btnAsistencia = new System.Windows.Forms.Button();
            this.btnAlumnos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnmaterias
            // 
            this.btnmaterias.Location = new System.Drawing.Point(31, 216);
            this.btnmaterias.Name = "btnmaterias";
            this.btnmaterias.Size = new System.Drawing.Size(85, 77);
            this.btnmaterias.TabIndex = 3;
            this.btnmaterias.Text = "Materias";
            this.btnmaterias.UseVisualStyleBackColor = true;
            this.btnmaterias.Click += new System.EventHandler(this.btnmaterias_Click);
            // 
            // btnactividades
            // 
            this.btnactividades.Image = global::EscuelaPowert.Properties.Resources.actividad;
            this.btnactividades.Location = new System.Drawing.Point(276, 216);
            this.btnactividades.Name = "btnactividades";
            this.btnactividades.Size = new System.Drawing.Size(89, 77);
            this.btnactividades.TabIndex = 4;
            this.btnactividades.UseVisualStyleBackColor = true;
            this.btnactividades.Click += new System.EventHandler(this.btnactividades_Click);
            // 
            // btngrupo
            // 
            this.btngrupo.Image = global::EscuelaPowert.Properties.Resources.grupo;
            this.btngrupo.Location = new System.Drawing.Point(31, 34);
            this.btngrupo.Name = "btngrupo";
            this.btngrupo.Size = new System.Drawing.Size(73, 72);
            this.btngrupo.TabIndex = 2;
            this.btngrupo.UseVisualStyleBackColor = true;
            this.btngrupo.Click += new System.EventHandler(this.btngrupo_Click);
            // 
            // btnAsistencia
            // 
            this.btnAsistencia.Image = global::EscuelaPowert.Properties.Resources.lista_de_verificacion__2_;
            this.btnAsistencia.Location = new System.Drawing.Point(504, 34);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.Size = new System.Drawing.Size(88, 71);
            this.btnAsistencia.TabIndex = 1;
            this.btnAsistencia.UseVisualStyleBackColor = true;
            this.btnAsistencia.Click += new System.EventHandler(this.btnAsistencia_Click);
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.Image = global::EscuelaPowert.Properties.Resources.ex_alumnos;
            this.btnAlumnos.Location = new System.Drawing.Point(276, 34);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Size = new System.Drawing.Size(89, 71);
            this.btnAlumnos.TabIndex = 0;
            this.btnAlumnos.UseVisualStyleBackColor = true;
            this.btnAlumnos.Click += new System.EventHandler(this.btnAlumnos_Click);
            // 
            // Frmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 323);
            this.Controls.Add(this.btnactividades);
            this.Controls.Add(this.btnmaterias);
            this.Controls.Add(this.btngrupo);
            this.Controls.Add(this.btnAsistencia);
            this.Controls.Add(this.btnAlumnos);
            this.Name = "Frmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlumnos;
        private System.Windows.Forms.Button btnAsistencia;
        private System.Windows.Forms.Button btngrupo;
        private System.Windows.Forms.Button btnmaterias;
        private System.Windows.Forms.Button btnactividades;
    }
}