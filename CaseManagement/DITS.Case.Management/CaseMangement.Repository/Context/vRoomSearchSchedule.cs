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
    
    public partial class vRoomSearchSchedule
    {
        public int RoomSearchScheduleId { get; set; }
        public int RoomId { get; set; }
        public string Room { get; set; }
        public int BuildingId { get; set; }
        public string Building { get; set; }
        public System.DateTime ScheduleDate { get; set; }
        public int ProcedureStatusId { get; set; }
        public string ProcedureStatus { get; set; }
        public Nullable<System.DateTime> CompletedDate { get; set; }
        public Nullable<int> StaffId { get; set; }
        public string Staff { get; set; }
        public string Comments { get; set; }
    }
}
