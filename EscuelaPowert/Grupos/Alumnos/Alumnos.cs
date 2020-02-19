using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaPowert.Grupos.Alumnos
{
    class Alumnos
    {
        private int ID { get; set; }

        private string Nombre { get; set; }

        private string Apellido { get; set; }

        private int Control { get; set; }
        
        private int ID_Grupo { get; set; }

        private bool Estado { get; set; }
        public int id
        {
            get { return ID; }
            set { ID = value; }
        }
    }
}
