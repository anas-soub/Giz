//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GizDb
{
    using System;
    using System.Collections.Generic;
    
    public partial class HomeTown
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HomeTown()
        {
            this.Beneficiaries = new HashSet<Beneficiary>();
        }
    
        public System.Guid Id { get; set; }
        public string TownName { get; set; }
        public string CountryName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Beneficiary> Beneficiaries { get; set; }
    }
}
