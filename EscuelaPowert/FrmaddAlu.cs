﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscuelaPowert
{
    public partial class FrmaddAlu : Form
    {
        public FrmaddAlu()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {

                using (EscuelaEntitys db = new EscuelaEntitys())
                {
                    Alumno A = new Alumno();
                    A.Alumno_Nombre = txtnombre.Text;
                    A.Alumno_Apellido = txtapellido.Text;
                    A.Alumno_Control = int.Parse(txtmatricula.Text);
                    A.Alumno_Estado = true;
                    A.ID_Grupo = 2;
                    db.Alumnos.Add(A);
                    db.SaveChanges();
                }
                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Error en guardar");
            }
        }
    }
}
