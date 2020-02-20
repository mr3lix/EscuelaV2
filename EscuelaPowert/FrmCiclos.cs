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
    public partial class FrmCiclos : Form
    {
        public FrmCiclos()
        {
            InitializeComponent();
            loadCiclo();
        }

        private void btnAgregarCiclo_Click(object sender, EventArgs e)
        {
            FrmaddCiclo add = new FrmaddCiclo();
            add.ShowDialog();
        }

        private void loadCiclo()
        {
            using (EscuelaEntitys db = new EscuelaEntitys())
            {
                dataGridView1.DataSource = db.Cicloes.ToList();
            }
        }
    }
}
