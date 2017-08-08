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
    
    public partial class CallCode
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CallCode()
        {
            this.CallCodeSchedules = new HashSet<CallCodeSchedule>();
            this.ClientCallCodes = new HashSet<ClientCallCode>();
        }
    
        public int CallCodeId { get; set; }
        public int CompanyId { get; set; }
        public string CallCode1 { get; set; }
        public string Description { get; set; }
        public int SchedulingPeriod { get; set; }
        public int SchedulingFrequency { get; set; }
        public string ExcludeSunday { get; set; }
        public string ExcludeMonday { get; set; }
        public string ExcludeTuesday { get; set; }
        public string ExcludeWednesday { get; set; }
        public string ExcludeThursday { get; set; }
        public string ExcludeFriday { get; set; }
        public string ExcludeSaturday { get; set; }
        public string Active { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string RecordDeleted { get; set; }
        public string DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual GlobalCode GlobalCode { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CallCodeSchedule> CallCodeSchedules { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientCallCode> ClientCallCodes { get; set; }
    }
}
