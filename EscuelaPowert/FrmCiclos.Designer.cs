﻿namespace EscuelaPowert
{
    partial class FrmCiclos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAgregarCiclo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(292, 128);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAgregarCiclo
            // 
            this.btnAgregarCiclo.Location = new System.Drawing.Point(87, 59);
            this.btnAgregarCiclo.Name = "btnAgregarCiclo";
            this.btnAgregarCiclo.Size = new System.Drawing.Size(113, 23);
            this.btnAgregarCiclo.TabIndex = 1;
            this.btnAgregarCiclo.Text = "Agregar ciclo";
            this.btnAgregarCiclo.UseVisualStyleBackColor = true;
            this.btnAgregarCiclo.Click += new System.EventHandler(this.btnAgregarCiclo_Click);
            // 
            // FrmCiclos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 216);
            this.Controls.Add(this.btnAgregarCiclo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmCiclos";
            this.Text = "FrmCiclos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAgregarCiclo;
    }
}