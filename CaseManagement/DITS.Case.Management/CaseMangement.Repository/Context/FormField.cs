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
    
    public partial class FormField
    {
        public int FormFieldId { get; set; }
        public int FormQueryId { get; set; }
        public string FormFieldName { get; set; }
        public string FormFieldDescription { get; set; }
        public string FormQueryFieldName { get; set; }
        public Nullable<int> FormEntityId { get; set; }
    
        public virtual FormEntity FormEntity { get; set; }
    }
}
