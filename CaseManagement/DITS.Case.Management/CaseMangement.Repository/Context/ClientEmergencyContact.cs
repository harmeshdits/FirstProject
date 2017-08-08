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
    
    public partial class ClientEmergencyContact
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ClientEmergencyContact()
        {
            this.ClientLeaves = new HashSet<ClientLeaf>();
            this.ClientLeaves1 = new HashSet<ClientLeaf>();
            this.ClientLeaveSchedules = new HashSet<ClientLeaveSchedule>();
        }
    
        public int ClientEmergencyContactId { get; set; }
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Relationship { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public Nullable<int> State { get; set; }
        public string ZIP { get; set; }
        public string Phone_Home { get; set; }
        public string Phone_Work { get; set; }
        public string Phone_Cell { get; set; }
        public string Primary { get; set; }
        public string Emergency { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string ResidesWithClient { get; set; }
        public string ApprovedVisitor { get; set; }
        public Nullable<int> LicenseState { get; set; }
        public string LicenseNumber { get; set; }
        public Nullable<System.DateTime> LicenseExpiration { get; set; }
        public string Comments { get; set; }
        public string Active { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string RecordDeleted { get; set; }
        public string DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public string Email { get; set; }
        public Nullable<int> ClientVehicleId { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual ClientVehicle ClientVehicle { get; set; }
        public virtual GlobalCode GlobalCode { get; set; }
        public virtual GlobalCode GlobalCode1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientLeaf> ClientLeaves { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientLeaf> ClientLeaves1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientLeaveSchedule> ClientLeaveSchedules { get; set; }
    }
}
