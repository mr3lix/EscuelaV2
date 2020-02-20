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
    public partial class FrmAlumnos : Form
    {
        public FrmAlumnos()
        {
            InitializeComponent();
            ReadAl();
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            //frmadd F = new frmaddAlu();
            //F.ShowDialog();
        }

        private void ReadAl()
        {
            using (EscuelaEntitys db = new EscuelaEntitys())
            {
                DateGriAlum.DataSource = db.Alumnos.ToList();
                CMBCiclo.DataSource = db.Cicloes.ToList();
            }
        }
    }
}
