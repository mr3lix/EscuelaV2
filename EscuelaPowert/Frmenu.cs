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
    }
}
