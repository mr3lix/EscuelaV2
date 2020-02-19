﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EscuelaPowert.Models;

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
            using (EscuelaEntities1 db = new EscuelaEntities1())
            {
                Alumnos A = new Alumnos();
                A.Alumno_Nombre = txtnombre.Text;
                A.Alumno_Apellido = txtapell.Text;
                A.Alumno_Control = int.Parse(txtmatri.Text);
                db.Alumnos.Add(A);
                db.SaveChanges();
            }
        }
    }
}
