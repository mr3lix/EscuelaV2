//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EscuelaPowert
{
    using System;
    using System.Collections.Generic;
    
    public partial class Materias
    {
        public int Materia_ID { get; set; }
        public string Materia_Nombre { get; set; }
        public int ID_Plan { get; set; }
    
        public virtual Plan_Estudio Plan_Estudio { get; set; }
    }
}
