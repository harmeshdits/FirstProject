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
    
    public partial class vClientMedicationLog
    {
        public int ClientMedicationLogId { get; set; }
        public int ClientId { get; set; }
        public int ClientPrescriptionId { get; set; }
        public System.DateTime LogDate { get; set; }
        public int LogTypeId { get; set; }
        public string LogType { get; set; }
        public decimal Quantity { get; set; }
        public decimal QuantityOnHand { get; set; }
        public int UserId { get; set; }
        public string User { get; set; }
        public string Comments { get; set; }
    }
}
