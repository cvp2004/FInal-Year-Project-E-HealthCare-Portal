//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OPD_Section
{
    using System;
    using System.Collections.Generic;
    
    public partial class VILLAGE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VILLAGE()
        {
            this.HOUSES = new HashSet<House>();
        }
    
        public int VILLAGE_ID { get; set; }
        public string VILLAGE_NAME { get; set; }
        public string VILLAGE_CODE { get; set; }
        public int NO_OF_HOUSES { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<House> HOUSES { get; set; }
    }
}
