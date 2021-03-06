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
    public partial class FrmMaterias : Form
    {
        public FrmMaterias()
        {
            InitializeComponent();
            loadDataMa();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Frmaddmate F = new Frmaddmate();
            F.ShowDialog();
        }

        private void loadDataMa()
        {
            using (EscuelaEntitys db = new EscuelaEntitys())
            {
                var b = from d in db.Materias select new { d.Materia_ID, d.Materia_Nombre };
                dataGridView1.DataSource = b.ToList();
            }
        }
    }
}
