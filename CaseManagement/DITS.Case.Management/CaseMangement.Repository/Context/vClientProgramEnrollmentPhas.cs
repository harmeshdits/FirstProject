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
    
    public partial class vClientProgramEnrollmentPhas
    {
        public int ClientProgramPhaseId { get; set; }
        public int ClientId { get; set; }
        public int ClientProgramEnrollmentId { get; set; }
        public int ProgramPhaseId { get; set; }
        public string Phase { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string Comments { get; set; }
    }
}
