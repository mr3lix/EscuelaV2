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
    public partial class FrmGrupos : Form
    {
        public FrmGrupos()
        {
            InitializeComponent();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            FrmaddGrupo F = new FrmaddGrupo();
            F.ShowDialog();
        }

        private void LoadData()
        {
            using (Models.EscuelaEntities2 db = new Models.EscuelaEntities2())
            {
                dataGridView1.DataSource = db.Grupo.ToList();
            }
        }

        private void buscartxt()
        {
            using (Models.EscuelaEntities2 db = new Models.EscuelaEntities2())
            {
                
                
            }
        }
    }
}
