//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EstadisticaPelotaEnlaceDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Juegos
    {
        public int Id { get; set; }
        public string NumeroJuego { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public Nullable<int> Equipo1 { get; set; }
        public Nullable<int> Equipo2 { get; set; }
        public Nullable<int> Ganador { get; set; }
    
        public virtual Equipos Equipos { get; set; }
        public virtual Equipos Equipos1 { get; set; }
        public virtual Equipos Equipos2 { get; set; }
    }
}
