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
    public partial class FrmAddAct : Form
    {
        public FrmAddAct()
        {
            InitializeComponent();
        }

        private void loadcm()
        {
            using (EscuelaEntitys db = new EscuelaEntitys())
            {
                var s = from d in db.Tipo_Actividad select new { d.Actividad_ID };
                cmbtipo.DataSource = s.ToList();
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            using (EscuelaEntitys db = new EscuelaEntitys())
            {
                Actividade A = new Actividade();
                A.Actividades_Nombre = txt_name.Text;
                A.Actividad_Descripcion = txtdescrip.Text;
                A.Tipo_Actividad = cmbtipo.SelectedIndex;
                db.Actividades.Add(A);
                db.SaveChanges();
            }
            this.Close();
        }
    }
}
