//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLTV_DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class BCTKTRATRE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BCTKTRATRE()
        {
            this.CTBCTKTRATREs = new HashSet<CTBCTKTRATRE>();
        }
    
        public string MaBCTKTraTre { get; set; }
        public System.DateTime Ngay { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTBCTKTRATRE> CTBCTKTRATREs { get; set; }
    }
}
