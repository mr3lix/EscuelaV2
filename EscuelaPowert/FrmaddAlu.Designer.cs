namespace EscuelaPowert
{
    partial class FrmaddAlu
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
            this.btnadd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapell = new System.Windows.Forms.TextBox();
            this.txtmatri = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(12, 127);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(377, 23);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Agregar";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Matricula:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(71, 6);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(318, 20);
            this.txtnombre.TabIndex = 4;
            // 
            // txtapell
            // 
            this.txtapell.Location = new System.Drawing.Point(72, 51);
            this.txtapell.Name = "txtapell";
            this.txtapell.Size = new System.Drawing.Size(317, 20);
            this.txtapell.TabIndex = 5;
            // 
            // txtmatri
            // 
            this.txtmatri.Location = new System.Drawing.Point(71, 94);
            this.txtmatri.Name = "txtmatri";
            this.txtmatri.Size = new System.Drawing.Size(318, 20);
            this.txtmatri.TabIndex = 6;
            // 
            // FrmaddAlu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 160);
            this.Controls.Add(this.txtmatri);
            this.Controls.Add(this.txtapell);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnadd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmaddAlu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Alumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapell;
        private System.Windows.Forms.TextBox txtmatri;
    }
}