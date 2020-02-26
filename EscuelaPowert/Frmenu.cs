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
    public partial class Frmenu : Form
    {
        public Frmenu()
        {
            InitializeComponent();
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            FrmAlumnos A = new FrmAlumnos();
            A.ShowDialog();
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            FrmAsistencia A = new FrmAsistencia();
            A.ShowDialog();
        }

        private void btngrupo_Click(object sender, EventArgs e)
        {
            FrmGrupos A = new FrmGrupos();
            A.ShowDialog();
        }

        private void btnmaterias_Click(object sender, EventArgs e)
        {
            FrmMaterias A = new FrmMaterias();
            A.ShowDialog();
        }

        private void btnactividades_Click(object sender, EventArgs e)
        {
            FrmActividades A = new FrmActividades();
            A.ShowDialog();
        }
    }
}
