using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EscuelaPowert
{
    public partial class FrmAsistencia : Form
    {
        public FrmAsistencia()
        {
            InitializeComponent();
            loadData();
            LoadCom();
            LoadClase();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loadData()
        {
            using (EscuelaEntitys db = new EscuelaEntitys())
            {
                var a = from d in db.Asistencias select new { d.ID_Alumno, d.ID_Clase,d.Alumno.Alumno_Nombre };
                datagridAsus.DataSource = a.ToList();
            }
        }

        private void LoadCom()
        {
            using (EscuelaEntitys db = new EscuelaEntitys())
            {
                var a = from d in db.Cicloes select d.Ciclo_Ano;
                cbmciclo.DataSource = a.ToList();
            }
        }

        private void LoadClase()
        {
            using (EscuelaEntitys db = new EscuelaEntitys())
            {
                var a = from d in db.Grupoes select d.Grupo_Nombre;
                cmbclase.DataSource = a.ToList();
            }
        }

        private void Generar()
        {
            using (EscuelaEntitys db = new EscuelaEntitys())
            {
                Asistencia A = new Asistencia();
                var Al = from N in db.Alumnos where N.ID_Grupo == cmbclase.SelectedIndex select N.Alumno_ID;
                
            }
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            using (EscuelaEntitys db = new EscuelaEntitys())
            {
                var a = from d in db.Alumnos where (d.Alumno_Nombre == txtbuscar.Text) select new { d.Alumno_Nombre };
                datagridAsus.DataSource = null;
                datagridAsus.DataSource = a.ToList();
            }
        }

        private void datagridAsus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (EscuelaEntitys db = new EscuelaEntitys())
            {
                Asistencia A = new Asistencia();
                A.ID_Alumno = cmbclase.SelectedIndex;
                A.ID_Clase = cmbclase.SelectedIndex;
                db.Asistencias.Add(A);
                db.SaveChanges();
            }
        }
    }
}
