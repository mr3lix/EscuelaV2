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
    public partial class FrmActividades : Form
    {
        public FrmActividades()
        {
            InitializeComponent();
            load();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddAct F = new FrmAddAct();
            F.ShowDialog();
        }

        private void load()
        {
            using (EscuelaEntitys db = new EscuelaEntitys())
            {
                var s = from d in db.Actividades select new { d.Actividades_ID, d.Actividades_Nombre, d.Actividad_Descripcion};
                dataGridView1.DataSource = s.ToList();
            }
        }
    }
}
