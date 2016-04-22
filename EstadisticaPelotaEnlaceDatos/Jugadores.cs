//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EstadisticaPelotaEnlaceDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Jugadores
    {
        public Jugadores()
        {
            this.TipoEstadisticas = new HashSet<TipoEstadisticas>();
        }
    
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Ponche { get; set; }
        public string Hits { get; set; }
        public string Carreras { get; set; }
        public string HomeRun { get; set; }
        public Nullable<int> EquipoId { get; set; }
        public Nullable<int> PosicionID { get; set; }
        public Nullable<int> ligaID { get; set; }
    
        public virtual Equipos Equipos { get; set; }
        public virtual Posiciones Posiciones { get; set; }
        public virtual ICollection<TipoEstadisticas> TipoEstadisticas { get; set; }
    }
}
