//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dual_Hotel_EX3.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pensio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pensio()
        {
            this.TipusHabitacios = new HashSet<TipusHabitacio>();
        }
    
        public int IDPensio { get; set; }
        public string Nom { get; set; }
        public string Descripcio { get; set; }
        public decimal Preu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TipusHabitacio> TipusHabitacios { get; set; }
    }
}
