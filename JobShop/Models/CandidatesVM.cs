using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobShop.Models
{
    class CandidatesVM
    {
        //As List
        public List<Candidates> listCandidates { get; set; }
        public List<CandidatesApplications> listCandidateApplications { get; set; }
        public List<CandidateEducation> listCandidateEducation { get; set; }
        public List<CandidateExperience> listCandidateExperience { get; set; }
        public List<CandidatesLanguages> listCandidatesLanguage { get; set; }
        public List<CandidateReq> listCandidateReq { get; set;}
        public List<CandidateViews> listCandidateView { get; set; }

        //As IEnumerable
        public IEnumerable<Candidates> enumCandidates { get; set; }
        public IEnumerable<CandidatesApplications> enumCandidatesApplications { get; set; }
        public IEnumerable<CandidateEducation> enumCandidateEducation { get; set; }
        public IEnumerable<CandidateExperience> enumCandidateExperience { get; set; }
        public IEnumerable<CandidatesLanguages> enumCandidatesLanguages { get; set; }
        public IEnumerable<CandidateReq> enumCandidateReq { get; set; }
        public IEnumerable<CandidateViews> enumCandidateViews { get; set; }



    }
}
