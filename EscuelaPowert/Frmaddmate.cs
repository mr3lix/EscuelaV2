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
    public partial class Frmaddmate : Form
    {
        public Frmaddmate()
        {
            InitializeComponent();
            loadPlan();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            using (EscuelaEntitys db = new EscuelaEntitys())
            {
                Materia M = new Materia();
                M.Materia_Nombre = txtnombre.Text;
                M.ID_Plan = cmbplan.SelectedIndex;
                db.Materias.Add(M);
                db.SaveChanges();
            }
            this.Close();
        }

        private void loadPlan()
        {
            using (EscuelaEntitys db = new EscuelaEntitys())
            {
                var d = from s in db.Cicloes select s.Ciclo_Ano;
                cmbplan.DataSource = d.ToList();
            }
        }
    }
}
