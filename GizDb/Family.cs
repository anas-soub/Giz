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
    
    public partial class Family
    {
        public System.Guid Id { get; set; }
        public System.Guid FamilyId { get; set; }
        public decimal Income { get; set; }
        public int IncomeCurrency { get; set; }
        public int MembersCount { get; set; }
        public int RegularIncomeMembersCount { get; set; }
        public int Status { get; set; }
    
        public virtual FamilyId FamilyId1 { get; set; }
    }
}
