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
    public partial class FrmaddCiclo : Form
    {
        public FrmaddCiclo()
        {
            InitializeComponent();
        }

        private void btnAgregarCiclo_Click(object sender, EventArgs e)
        {
            using (EscuelaEntities1 db = new EscuelaEntities1())
            {
                Ciclo c = new Ciclo();
                //c.Ciclo_Ano El año podría manejarse por separado
                //c.CicloInicio = dtpInicioCiclo.Fecha
                //c.CicloFinal = dtpFinalCiclo.Fecha

                db.Grupo.Add(g);
                db.SaveChanges();
            }
        }
    }
}
