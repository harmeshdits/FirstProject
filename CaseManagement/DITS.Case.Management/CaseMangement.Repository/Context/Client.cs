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
    
    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            this.ClientAddresses = new HashSet<ClientAddress>();
            this.ClientAlerts = new HashSet<ClientAlert>();
            this.ClientAlternateNames = new HashSet<ClientAlternateName>();
            this.ClientArrestInfoes = new HashSet<ClientArrestInfo>();
            this.ClientBikes = new HashSet<ClientBike>();
            this.ClientBondInfoes = new HashSet<ClientBondInfo>();
            this.ClientCaseFiles = new HashSet<ClientCaseFile>();
            this.ClientCommunityFinancials = new HashSet<ClientCommunityFinancial>();
            this.ClientConflicts = new HashSet<ClientConflict>();
            this.ClientConflicts1 = new HashSet<ClientConflict>();
            this.ClientContactNotes = new HashSet<ClientContactNote>();
            this.ClientDiagnoses = new HashSet<ClientDiagnos>();
            this.ClientDockets = new HashSet<ClientDocket>();
            this.ClientDrugsOfChoices = new HashSet<ClientDrugsOfChoice>();
            this.ClientDrugTreatments = new HashSet<ClientDrugTreatment>();
            this.ClientDrugUseHistories = new HashSet<ClientDrugUseHistory>();
            this.ClientEducations = new HashSet<ClientEducation>();
            this.ClientEmergencyContacts = new HashSet<ClientEmergencyContact>();
            this.ClientEmployments = new HashSet<ClientEmployment>();
            this.ClientEmploymentSkills = new HashSet<ClientEmploymentSkill>();
            this.ClientIdentifiers = new HashSet<ClientIdentifier>();
            this.ClientInventories = new HashSet<ClientInventory>();
            this.ClientJobHistories = new HashSet<ClientJobHistory>();
            this.ClientLeaves = new HashSet<ClientLeaf>();
            this.ClientMovements = new HashSet<ClientMovement>();
            this.ClientOffenses = new HashSet<ClientOffens>();
            this.ClientOtherEmployments = new HashSet<ClientOtherEmployment>();
            this.ClientOtherInfoes = new HashSet<ClientOtherInfo>();
            this.ClientPassSites = new HashSet<ClientPassSite>();
            this.ClientPhones = new HashSet<ClientPhone>();
            this.ClientPhotos = new HashSet<ClientPhoto>();
            this.ClientPhysicalCharacteristics = new HashSet<ClientPhysicalCharacteristic>();
            this.ClientPrescriptions = new HashSet<ClientPrescription>();
            this.ClientProgramEnrollments = new HashSet<ClientProgramEnrollment>();
            this.ClientResidentFinancialAccounts = new HashSet<ClientResidentFinancialAccount>();
            this.ClientRooms = new HashSet<ClientRoom>();
            this.ClientScreenings = new HashSet<ClientScreening>();
            this.ClientSecurityFlags = new HashSet<ClientSecurityFlag>();
            this.ClientSignatures = new HashSet<ClientSignature>();
            this.ClientSignOutHolds = new HashSet<ClientSignOutHold>();
            this.ClientStatus = new HashSet<ClientStatu>();
            this.ClientVehicles = new HashSet<ClientVehicle>();
            this.HeadcountDetails = new HashSet<HeadcountDetail>();
            this.ShiftNoteClients = new HashSet<ShiftNoteClient>();
            this.Tasks = new HashSet<Task>();
            this.VisitorLogs = new HashSet<VisitorLog>();
        }
    
        public int ClientId { get; set; }
        public Nullable<int> Prefix { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Nullable<int> Surname { get; set; }
        public string SSN { get; set; }
        public Nullable<int> Sex { get; set; }
        public Nullable<System.DateTime> Birthdate { get; set; }
        public Nullable<int> Race { get; set; }
        public Nullable<int> MaritalStatus { get; set; }
        public string Alias { get; set; }
        public string SpecialEmploymentSkills { get; set; }
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
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientAddress> ClientAddresses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientAlert> ClientAlerts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientAlternateName> ClientAlternateNames { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientArrestInfo> ClientArrestInfoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientBike> ClientBikes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientBondInfo> ClientBondInfoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientCaseFile> ClientCaseFiles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientCommunityFinancial> ClientCommunityFinancials { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientConflict> ClientConflicts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientConflict> ClientConflicts1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientContactNote> ClientContactNotes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientDiagnos> ClientDiagnoses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientDocket> ClientDockets { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientDrugsOfChoice> ClientDrugsOfChoices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientDrugTreatment> ClientDrugTreatments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientDrugUseHistory> ClientDrugUseHistories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientEducation> ClientEducations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientEmergencyContact> ClientEmergencyContacts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientEmployment> ClientEmployments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientEmploymentSkill> ClientEmploymentSkills { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientIdentifier> ClientIdentifiers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientInventory> ClientInventories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientJobHistory> ClientJobHistories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientLeaf> ClientLeaves { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientMovement> ClientMovements { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientOffens> ClientOffenses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientOtherEmployment> ClientOtherEmployments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientOtherInfo> ClientOtherInfoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientPassSite> ClientPassSites { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientPhone> ClientPhones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientPhoto> ClientPhotos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientPhysicalCharacteristic> ClientPhysicalCharacteristics { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientPrescription> ClientPrescriptions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientProgramEnrollment> ClientProgramEnrollments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientResidentFinancialAccount> ClientResidentFinancialAccounts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientRoom> ClientRooms { get; set; }
        public virtual GlobalCode GlobalCode { get; set; }
        public virtual GlobalCode GlobalCode1 { get; set; }
        public virtual GlobalCode GlobalCode2 { get; set; }
        public virtual GlobalCode GlobalCode3 { get; set; }
        public virtual GlobalCode GlobalCode4 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientScreening> ClientScreenings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientSecurityFlag> ClientSecurityFlags { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientSignature> ClientSignatures { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientSignOutHold> ClientSignOutHolds { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientStatu> ClientStatus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientVehicle> ClientVehicles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HeadcountDetail> HeadcountDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShiftNoteClient> ShiftNoteClients { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Task> Tasks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VisitorLog> VisitorLogs { get; set; }
    }
}
