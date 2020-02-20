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
        }

        private void btnAgregarGrupo_Click(object sender, EventArgs e)
        {
            using (EscuelaEntities1 db = new EscuelaEntities1())
            {
                Grupo g = new Grupo();
                g.Grupo_Nombre = txtbGrupoNombre.Text;
                g.ID_Ciclo = cbCiclo.SelectedIndex;
                db.Grupo.Add(g);
                db.SaveChanges();
            }
        }

        private void loadCiclo()
        {
            using (EscuelaEntities1 db = new EscuelaEntities1())
            {
                cbCiclo.DataSource = db.Ciclo.ToList();
            }
        }
    }
}
