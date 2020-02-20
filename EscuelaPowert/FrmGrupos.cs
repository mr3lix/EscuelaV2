using System;
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
            LoadData();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            FrmaddGrupo F = new FrmaddGrupo();
            F.ShowDialog();
        }

        private void LoadData()
        {
            using (EscuelaEntitys db = new EscuelaEntitys())
            {
                var G = from d in db.Grupoes select new { d.Grupo_ID, d.Grupo_Nombre, d.ID_Ciclo };
                dataGridView1.DataSource = G.ToList();
            }
        }

        private void buscartxt()
        {
            using (EscuelaEntitys db = new EscuelaEntitys())
            {
                
                
            }
        }
    }
}
