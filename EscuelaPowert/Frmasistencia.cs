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
            LoadCom();
            LoadClase();
            loadData();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loadData()
        {
            using (EscuelaEntitys db = new EscuelaEntitys())
            {
                var a = from d in db.Asistencias join A in db.Alumnos on d.ID_Alumno 
                            equals A.Alumno_ID where A.ID_Grupo == 1
                                select new { A.Alumno_ID, A.Alumno_Nombre, A.Alumno_Apellido };

                datagridAsus.DataSource = a.ToList();
            }
            Generar();
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
                var Al = from N in db.Alumnos where N.ID_Grupo == 1 select N;
                foreach (var item in Al)
                {
                    Gen(item.Alumno_ID, item.ID_Grupo);
                }
            }
        }

        private void Gen(int IDA, int IDG)
        {
            using (EscuelaEntitys db = new EscuelaEntitys())
            {
                Asistencia A = new Asistencia();
                A.Asistencia_Fecha = DateTime.Now;
                A.ID_Alumno = IDA;
                A.ID_Clase = IDG;
                db.Asistencias.Add(A);
                db.SaveChanges();
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

        }

        private void cmbclase_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnallsele_Click(object sender, EventArgs e)
        {
            using (EscuelaEntitys db = new EscuelaEntitys())
            {
                var Al = from N in db.Alumnos where N.ID_Grupo == 1 select N;
                foreach (var item in Al)
                {
                   // Gen(item.Alumno_ID, item.ID_Grupo);
                }
            }
        }
    }
}
