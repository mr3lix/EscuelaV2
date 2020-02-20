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
    public partial class FrmAddActi : Form
    {
        public FrmAddActi()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            using (EscuelaEntitys db = new EscuelaEntitys())
            {
                Actividade A = new Actividade();
                A.Actividades_Nombre = txtnombre.Text;
                db.Actividades.Add(A);
                db.SaveChanges();
            }
        }
    }
}
