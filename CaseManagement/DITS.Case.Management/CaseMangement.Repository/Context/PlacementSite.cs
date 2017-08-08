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
    
    public partial class PlacementSite
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PlacementSite()
        {
            this.ClientProgramPlacements = new HashSet<ClientProgramPlacement>();
        }
    
        public int PlacementSiteId { get; set; }
        public string PlacementSite1 { get; set; }
        public Nullable<int> PlacementSiteType { get; set; }
        public Nullable<System.DateTime> EffectiveDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string ContactName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public Nullable<int> State { get; set; }
        public string ZIP { get; set; }
        public string PhoneNumber { get; set; }
        public string Comments { get; set; }
        public Nullable<int> ManagingLocation { get; set; }
        public string Active { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string RecordDeleted { get; set; }
        public string DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientProgramPlacement> ClientProgramPlacements { get; set; }
        public virtual GlobalCode GlobalCode { get; set; }
        public virtual GlobalCode GlobalCode1 { get; set; }
        public virtual GlobalCode GlobalCode2 { get; set; }
    }
}
