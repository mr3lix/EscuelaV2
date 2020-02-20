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
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loadData()
        {
            using (EscuelaEntitys db = new EscuelaEntitys())
            {
                datagridAsus.DataSource = db.Asistencias.ToList();
            }
        }

        private void LoadCom()
        {
            using (EscuelaEntitys db = new EscuelaEntitys())
            {
                cbmciclo.DataSource = db.Cicloes.ToList();
            }
        }
    }
}
