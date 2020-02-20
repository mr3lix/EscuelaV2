namespace EscuelaPowert
{
    partial class FrmaddGrupo
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
            this.btnAgregarGrupo = new System.Windows.Forms.Button();
            this.txtbGrupo = new System.Windows.Forms.TextBox();
            this.cbCiclo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregarGrupo
            // 
            this.btnAgregarGrupo.Location = new System.Drawing.Point(112, 140);
            this.btnAgregarGrupo.Name = "btnAgregarGrupo";
            this.btnAgregarGrupo.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarGrupo.TabIndex = 0;
            this.btnAgregarGrupo.Text = "Agregar";
            this.btnAgregarGrupo.UseVisualStyleBackColor = true;
            this.btnAgregarGrupo.Click += new System.EventHandler(this.btnAgregarGrupo_Click);
            // 
            // txtbGrupo
            // 
            this.txtbGrupo.Location = new System.Drawing.Point(125, 50);
            this.txtbGrupo.Name = "txtbGrupo";
            this.txtbGrupo.Size = new System.Drawing.Size(121, 20);
            this.txtbGrupo.TabIndex = 1;
            // 
            // cbCiclo
            // 
            this.cbCiclo.FormattingEnabled = true;
            this.cbCiclo.Location = new System.Drawing.Point(125, 92);
            this.cbCiclo.Name = "cbCiclo";
            this.cbCiclo.Size = new System.Drawing.Size(121, 21);
            this.cbCiclo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ciclo escolar:";
            // 
            // FrmaddGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 184);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCiclo);
            this.Controls.Add(this.txtbGrupo);
            this.Controls.Add(this.btnAgregarGrupo);
            this.Name = "FrmaddGrupo";
            this.Text = "FrmaddGrupo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarGrupo;
        private System.Windows.Forms.TextBox txtbGrupo;
        private System.Windows.Forms.ComboBox cbCiclo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}