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
            Verificar();
        }
        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void loadData()
        {
            using (EscuelaEntitys db = new EscuelaEntitys())
            {
                var a = from d in db.Asistencias join A in db.Alumnos on d.ID_Alumno 
                            equals A.Alumno_ID where A.ID_Grupo == 2
                                select new { A.Alumno_ID, A.Alumno_Nombre, A.Alumno_Apellido, d.Asistencia_Fecha, d.Asistencia_Valor };
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
                var Al = from N in db.Alumnos where N.ID_Grupo == 2 select N;
                foreach (var item in Al)
                {
                    Gen(item.Alumno_ID);
                }
            }
            loadData();
        }

        private void Verificar()
        {
            using (EscuelaEntitys db = new EscuelaEntitys())
            {
                var fecha = DateTime.Now.Date;
                var a = from d in db.Asistencias where d.Asistencia_Fecha == fecha select d;
                if (a.ToList().Count >= 1)
                {
                    loadData();
                }
                else
                {
                    Generar();
                }
            }
        }

        private void Gen(int IDA)
        {
            using (EscuelaEntitys db = new EscuelaEntitys())
            {
                Asistencia A = new Asistencia();
                A.Asistencia_Fecha = DateTime.Now.Date;
                A.ID_Alumno = IDA;
                A.ID_Clase = 1;
                A.Asistencia_Valor = null;
                db.Asistencias.Add(A);
                db.SaveChanges();
            }
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            using (EscuelaEntitys db = new EscuelaEntitys())
            {
                var a = from d in db.Alumnos where d.Alumno_Nombre.Contains(txtbuscar.Text) select new { d.Alumno_ID, d.Alumno_Nombre, d.Alumno_Apellido, d.Alumno_Control };
                datagridAsus.DataSource = null;
                datagridAsus.DataSource = a.ToList();
            }
        }

        private void datagridAsus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int v = int.Parse(datagridAsus.Rows[datagridAsus.CurrentRow.Index].Cells[0].Value.ToString());
            //MessageBox.Show(v.ToString());
        }

        private void cmbclase_SelectedIndexChanged(object sender, EventArgs e)
        {
            //loadData();
        }

        private void btnallsele_Click(object sender, EventArgs e)
        {
            using (EscuelaEntitys db = new EscuelaEntitys())
            {
                List<Asistencia> Al = (from N in db.Asistencias where N.ID_Clase == 1 select N).ToList();
                foreach (var item in Al)
                {
                    item.Asistencia_Valor = true;
                }    
                    db.SaveChanges();
            }
            loadData();
        }

        private void datagridAsus_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //int v = int.Parse(datagridAsus.Rows[datagridAsus.CurrentRow.Index].Cells[0].Value.ToString());
            //MessageBox.Show(v.ToString());
           // Gen(v);
            //loadData();
        }

        private void datagridAsus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                int v = int.Parse(datagridAsus.Rows[datagridAsus.CurrentRow.Index].Cells[0].Value.ToString());
                using (EscuelaEntitys db = new EscuelaEntitys())
                {
                    var a = DateTime.Now.Date;
                    List<Asistencia> Al = (from N in db.Asistencias where N.ID_Alumno == v && N.Asistencia_Fecha == a select N).ToList();
                    foreach (var item in Al)
                    {
                        item.Asistencia_Valor = true;
                    }
                    db.SaveChanges();
                }
                loadData();
            }
        }
    }
}
