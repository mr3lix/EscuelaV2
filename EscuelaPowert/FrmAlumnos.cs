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
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            FrmaddGrupo F = new FrmaddGrupo();
            F.ShowDialog();
        }
    }
}
