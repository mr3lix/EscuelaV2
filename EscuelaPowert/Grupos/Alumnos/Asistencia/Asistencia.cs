using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaPowert.Grupos.Alumnos.Asistencia
{
    class Asistencia
    {
        private int ID { get; set; }

        private DateTime Fecha { get; set; }

        private int ID_Alumno { get; set; }

        private int ID_Clase { get; set; }

        public int id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
