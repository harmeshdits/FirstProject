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
    
    public partial class ClientProgramEnrollmentDocket
    {
        public int ClientProgramEnrollmentDocketId { get; set; }
        public int ClientProgramEnrollmentId { get; set; }
        public int ClientDocketId { get; set; }
        public string PrimaryDocket { get; set; }
        public string Active { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string RecordDeleted { get; set; }
        public string DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
    
        public virtual ClientDocket ClientDocket { get; set; }
        public virtual ClientProgramEnrollment ClientProgramEnrollment { get; set; }
    }
}
