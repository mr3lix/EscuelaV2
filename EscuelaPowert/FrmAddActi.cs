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
    public partial class FrmAddActi : Form
    {
        public FrmAddActi()
        {
            InitializeComponent();
            load();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            using (EscuelaEntitys db = new EscuelaEntitys())
            {
                Actividade A = new Actividade();
                A.Actividades_Nombre = txtnombre.Text;
                A.Tipo_Actividad = (Tipo_Actividad)cmbtipo.SelectedItem;
                db.Actividades.Add(A);
                db.SaveChanges();
            }
        }

        private void load()
        {
            using (EscuelaEntitys db = new EscuelaEntitys())
            {
                var T = from A in db.Tipo_Actividad select new { A.Actividad_Nombre };
                cmbtipo.DataSource = T.ToList();
            }
        }
    }
}
