//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CaseMangement.Repository.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class vClientTreatmentPlan
    {
        public int ClientTreatmentPlanId { get; set; }
        public int ClientId { get; set; }
        public int ClientProgramEnrollmentId { get; set; }
        public string TreatmentPlanName { get; set; }
        public System.DateTime TreatmentPlanDate { get; set; }
        public string ResidentProfile { get; set; }
        public byte[] ClientSignature { get; set; }
        public byte[] StaffSignature { get; set; }
        public byte[] AdditionalSignature { get; set; }
        public string AdditionalSignerDescription { get; set; }
        public byte[] AdditionalSignature2 { get; set; }
        public string AdditionalSignerDescription2 { get; set; }
    }
}
