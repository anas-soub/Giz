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
    
    public partial class IdType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IdType()
        {
            this.FamilyIds = new HashSet<FamilyId>();
            this.PersonIds = new HashSet<PersonId>();
        }
    
        public int Id { get; set; }
        public int Type { get; set; }
        public bool IsPersonId { get; set; }
        public bool IsFamilyId { get; set; }
        public string NameA { get; set; }
        public string NameE { get; set; }
        public string ShortDescriptionA { get; set; }
        public string ShortDescriptionE { get; set; }
        public string DescriptionA { get; set; }
        public string DescriptionE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FamilyId> FamilyIds { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonId> PersonIds { get; set; }
    }
}
