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
    public partial class FrmAlumnos : Form
    {
        public FrmAlumnos()
        {
            InitializeComponent();
            ReadAl();
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
             FrmaddAlu F = new FrmaddAlu();
            F.ShowDialog();
        }

        private void ReadAl()
        {
            using (EscuelaEntitys db = new EscuelaEntitys())
            {
                var l = from d in db.Alumnos select new { d.Alumno_ID, d.Alumno_Nombre, d.Alumno_Apellido, d.Alumno_Control };
                DateGriAlum.DataSource = l.ToList();
                var c = from d in db.Cicloes select d.Ciclo_Ano;
                CMBCiclo.DataSource = c.ToList();
            }
        }
    }
}
