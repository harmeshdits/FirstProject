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
    
    public partial class vClientSecurityLevel
    {
        public int ClientSecurityLevelId { get; set; }
        public int ClientId { get; set; }
        public int ClientProgramEnrollmentId { get; set; }
        public int SecurityLevelId { get; set; }
        public int SecurityLevel { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
    }
}
