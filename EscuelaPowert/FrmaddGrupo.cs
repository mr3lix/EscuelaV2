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
    public partial class FrmaddGrupo : Form
    {
        public FrmaddGrupo()
        {
            InitializeComponent();
            loadCiclo();
        }

        private void btnAgregarGrupo_Click(object sender, EventArgs e)
        {
            using (EscuelaEntitys db = new EscuelaEntitys())
            {
                Grupo g = new Grupo();
                g.Grupo_Nombre = txtbGrupoNombre.Text;
                g.ID_Ciclo = cbCiclo.SelectedIndex;
                db.Grupoes.Add(g);
                db.SaveChanges();
            }
        }

        private void loadCiclo()
        {
            using (EscuelaEntitys db = new EscuelaEntitys())
            {
                var G = from d in db.Cicloes select d.Ciclo_ID;
                cbCiclo.DataSource = G.ToList();
            }
        }
    }
}
