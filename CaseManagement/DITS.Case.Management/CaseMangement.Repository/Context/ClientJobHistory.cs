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
    
    public partial class ClientJobHistory
    {
        public int ClientJobHistoryId { get; set; }
        public int ClientId { get; set; }
        public int EmployerId { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public Nullable<int> WorkType { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<System.DateTime> EmploymentConfirmationDate { get; set; }
        public Nullable<decimal> PayRate { get; set; }
        public string Tips { get; set; }
        public string Commission { get; set; }
        public string PieceWork { get; set; }
        public string Active { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string RecordDeleted { get; set; }
        public string DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public string WorkTypeOther { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Employer Employer { get; set; }
        public virtual GlobalCode GlobalCode { get; set; }
    }
}
