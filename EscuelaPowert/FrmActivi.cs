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
    public partial class FrmActivi : Form
    {
        public FrmActivi()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            FrmAddActi F = new FrmAddActi();
            F.ShowDialog();
        }

        private void LoadActivi()
        {
            using (EscuelaEntitys db = new EscuelaEntitys())
            {
                var a = from s in db.Actividades select new { s.Actividades_ID, s.Actividades_Nombre, s.Actividad_Descripcion };
                DatagridActivi.DataSource = a.ToList();
            }
        }
    }
}
