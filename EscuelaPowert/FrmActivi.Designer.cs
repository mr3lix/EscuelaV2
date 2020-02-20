namespace EscuelaPowert
{
    partial class FrmActivi
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
            this.pnlabajo = new System.Windows.Forms.Panel();
            this.DatagridActivi = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.pnlabajo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridActivi)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlabajo
            // 
            this.pnlabajo.Controls.Add(this.DatagridActivi);
            this.pnlabajo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlabajo.Location = new System.Drawing.Point(0, 106);
            this.pnlabajo.Name = "pnlabajo";
            this.pnlabajo.Size = new System.Drawing.Size(762, 270);
            this.pnlabajo.TabIndex = 0;
            // 
            // DatagridActivi
            // 
            this.DatagridActivi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatagridActivi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatagridActivi.Location = new System.Drawing.Point(0, 0);
            this.DatagridActivi.Name = "DatagridActivi";
            this.DatagridActivi.Size = new System.Drawing.Size(762, 270);
            this.DatagridActivi.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtbuscar);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 48);
            this.panel1.TabIndex = 1;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(105, 15);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(546, 20);
            this.txtbuscar.TabIndex = 1;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(4, 13);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Nuevo";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // FrmActivi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 376);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlabajo);
            this.Name = "FrmActivi";
            this.Text = "Actividades";
            this.pnlabajo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatagridActivi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlabajo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView DatagridActivi;
    }
}