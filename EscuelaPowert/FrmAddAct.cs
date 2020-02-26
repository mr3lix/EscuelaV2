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
            loadcm();
        }

        private void loadcm()
        {
            using (EscuelaEntitys db = new EscuelaEntitys())
            {
                var s = from d in db.Tipo_Actividad select d.Actividad_ID;
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
                A.ID_Actividad = Convert.ToInt32(cmbtipo.Text);
                A.ID_Clase = 1;
                db.Actividades.Add(A);
                db.SaveChanges();
            }
            this.Close();
        }
    }
}
