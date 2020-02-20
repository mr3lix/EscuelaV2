namespace EscuelaPowert
{
    partial class FrmaddCiclo
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
            this.dtpInicioCiclo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFinalCiclo = new System.Windows.Forms.DateTimePicker();
            this.btnAgregarCiclo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpInicioCiclo
            // 
            this.dtpInicioCiclo.Location = new System.Drawing.Point(104, 34);
            this.dtpInicioCiclo.Name = "dtpInicioCiclo";
            this.dtpInicioCiclo.Size = new System.Drawing.Size(200, 20);
            this.dtpInicioCiclo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Final:";
            // 
            // dtpFinalCiclo
            // 
            this.dtpFinalCiclo.Location = new System.Drawing.Point(104, 88);
            this.dtpFinalCiclo.Name = "dtpFinalCiclo";
            this.dtpFinalCiclo.Size = new System.Drawing.Size(200, 20);
            this.dtpFinalCiclo.TabIndex = 2;
            // 
            // btnAgregarCiclo
            // 
            this.btnAgregarCiclo.Location = new System.Drawing.Point(152, 131);
            this.btnAgregarCiclo.Name = "btnAgregarCiclo";
            this.btnAgregarCiclo.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCiclo.TabIndex = 4;
            this.btnAgregarCiclo.Text = "Agregar";
            this.btnAgregarCiclo.UseVisualStyleBackColor = true;
            this.btnAgregarCiclo.Click += new System.EventHandler(this.btnAgregarCiclo_Click);
            // 
            // FrmaddCiclo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 182);
            this.Controls.Add(this.btnAgregarCiclo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFinalCiclo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpInicioCiclo);
            this.Name = "FrmaddCiclo";
            this.Text = "FrmaddCiclo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpInicioCiclo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFinalCiclo;
        private System.Windows.Forms.Button btnAgregarCiclo;
    }
}