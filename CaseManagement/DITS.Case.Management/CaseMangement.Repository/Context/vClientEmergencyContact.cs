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
    
    public partial class vClientEmergencyContact
    {
        public int ClientEmergencyContactId { get; set; }
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string RelationshipId { get; set; }
        public string Relationship { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public Nullable<int> StateId { get; set; }
        public string State { get; set; }
        public string ZIP { get; set; }
        public string Phone_Home { get; set; }
        public string Phone_Work { get; set; }
        public string Phone_Cell { get; set; }
        public string Primary { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string ResidesWithClient { get; set; }
        public Nullable<int> LicenseStateId { get; set; }
        public string LicenseState { get; set; }
        public string LicenseNumber { get; set; }
        public Nullable<System.DateTime> LicenseExpiration { get; set; }
        public string ApprovedVisitor { get; set; }
    }
}
