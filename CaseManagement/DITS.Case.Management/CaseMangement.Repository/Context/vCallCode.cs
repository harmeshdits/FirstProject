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
    
    public partial class vCallCode
    {
        public int CallCodeId { get; set; }
        public int CompanyId { get; set; }
        public string Company { get; set; }
        public string CallCode { get; set; }
        public string Description { get; set; }
        public int SchedulingPeriodId { get; set; }
        public string SchedulingPeriod { get; set; }
        public int SchedulingFrequencyId { get; set; }
        public string SchedulingFrequency { get; set; }
        public string ExcludeSunday { get; set; }
        public string ExcludeMonday { get; set; }
        public string ExcludeTuesday { get; set; }
        public string ExcludeWednesday { get; set; }
        public string ExcludeThursday { get; set; }
        public string ExcludeFriday { get; set; }
        public string ExcludeSaturday { get; set; }
    }
}
