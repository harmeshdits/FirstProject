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
    
    public partial class vClientInventory
    {
        public int ClientInventoryId { get; set; }
        public int ClientId { get; set; }
        public int InventoryTypeId { get; set; }
        public string InventoryType { get; set; }
        public string Description { get; set; }
        public System.DateTime AddedOn { get; set; }
        public int AddedById { get; set; }
        public string AddedBy { get; set; }
        public Nullable<System.DateTime> RemovedOn { get; set; }
        public Nullable<int> RemovedById { get; set; }
        public string RemovedBy { get; set; }
    }
}
