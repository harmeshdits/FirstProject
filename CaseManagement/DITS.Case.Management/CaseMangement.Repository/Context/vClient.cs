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
    
    public partial class vClient
    {
        public int ClientId { get; set; }
        public string Prefix { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string ClientName_FL { get; set; }
        public string ClientName_LF { get; set; }
        public string Surname { get; set; }
        public string SSN { get; set; }
        public string Sex { get; set; }
        public Nullable<System.DateTime> Birthdate { get; set; }
        public string Race { get; set; }
        public string MaritalStatus { get; set; }
        public string Comments { get; set; }
        public Nullable<int> Age { get; set; }
    }
}
