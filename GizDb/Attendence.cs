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
    
    public partial class Attendence
    {
        public System.Guid Id { get; set; }
        public System.Guid BeneficiaryId { get; set; }
        public System.Guid ProjectId { get; set; }
        public System.DateTime date { get; set; }
        public int WorkingHours { get; set; }
        public System.Guid CurrentPaymentId { get; set; }
        public System.Guid SupervisorId { get; set; }
        public string SiteId { get; set; }
        public int WorkTypeId { get; set; }
        public bool IsUnderWorkPermit { get; set; }
        public bool IsUnderSocialSecurity { get; set; }
    }
}
