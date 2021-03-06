//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EstadisticaPelota.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Jugador
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Jugador()
        {
            this.TipoEstadisticas = new HashSet<TipoEstadistica>();
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
    
        public virtual Equipo Equipo { get; set; }
        public virtual Liga Liga { get; set; }
        public virtual Posicione Posicione { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TipoEstadistica> TipoEstadisticas { get; set; }
    }
}
