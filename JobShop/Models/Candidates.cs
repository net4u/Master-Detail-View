//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JobShop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Candidates
    {
        public Candidates()
        {
            this.CandidateEducation = new HashSet<CandidateEducation>();
            this.CandidateExperience = new HashSet<CandidateExperience>();
            this.CandidateReq = new HashSet<CandidateReq>();
            this.CandidatesApplications = new HashSet<CandidatesApplications>();
            this.CandidateSkills = new HashSet<CandidateSkills>();
            this.JobApplications = new HashSet<JobApplications>();
        }
    
        public int IdCV { get; set; }
        public string User { get; set; }
        public string Experienta { get; set; }
        public Nullable<System.DateTime> DateAdd { get; set; }
        public string ImageSRC { get; set; }
        public string Titlu { get; set; }
        public string WhereWhat { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Solicitare { get; set; }
        public string Orar { get; set; }
        public Nullable<double> MinSal { get; set; }
        public Nullable<double> MaxSal { get; set; }
        public string Localitate { get; set; }
        public string Address { get; set; }
        public string ZIP { get; set; }
        public Nullable<double> Latitudine { get; set; }
        public Nullable<double> Longitudine { get; set; }
        public Nullable<System.DateTime> DateStart { get; set; }
        public Nullable<System.DateTime> DateEnd { get; set; }
        public string Region { get; set; }
        public string Sex { get; set; }
    
        public virtual AspNetUsers AspNetUsers { get; set; }
        public virtual ICollection<CandidateEducation> CandidateEducation { get; set; }
        public virtual ICollection<CandidateExperience> CandidateExperience { get; set; }
        public virtual ICollection<CandidateReq> CandidateReq { get; set; }
        public virtual ICollection<CandidatesApplications> CandidatesApplications { get; set; }
        public virtual ICollection<CandidateSkills> CandidateSkills { get; set; }
        public virtual ICollection<JobApplications> JobApplications { get; set; }
    }
}
