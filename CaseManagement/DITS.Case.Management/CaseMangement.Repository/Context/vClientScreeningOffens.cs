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
    
    public partial class vClientScreeningOffens
    {
        public int ClientScreeningOffenseId { get; set; }
        public int ClientScreeningId { get; set; }
        public string Offense { get; set; }
        public string Jurisdiction { get; set; }
        public string Code { get; set; }
        public Nullable<System.DateTime> OffenseDate { get; set; }
    }
}
