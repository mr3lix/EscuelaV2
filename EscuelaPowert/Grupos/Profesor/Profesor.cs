using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaPowert.Grupos.Profesor
{
    class Profesor
    {
        private int ID { get; set; }

        private string Nombre { get; set; }

        public int id
        {
            get { return ID; }
            set { ID = value;}
        }
    }
}
