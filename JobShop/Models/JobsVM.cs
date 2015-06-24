using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobShop.Models
{
    class JobsVM
    {
        //As List
        public List<Jobs> listJobs { get; set; }
        public List<JobSkills> listJobSkills { get; set; }
        public List<JobRequirements> listJobRequirements { get; set; }
        public List<JobsLanguages> listJobLanguages { get; set; }
        public List<JobExperience> listJobExperience { get; set; }
        public List<JobEducation> listJobEducation { get; set; }
        public List<JobApplications> listJobApplications { get; set; }

        
        //As IEnumerable
        public IEnumerable<Jobs> enumJobs { get; set; }
        public IEnumerable<JobSkills> enumJobsSkills { get; set; }
        public IEnumerable<JobRequirements> enumJobRequirements { get; set; }
        public IEnumerable<JobsLanguages> enumJobsLanguages { get; set; }
        public IEnumerable<JobExperience> enumJobExperience { get; set; }
        public IEnumerable<JobEducation> enumJobEducation { get; set; }
        public IEnumerable<JobApplications> enumJobApplications { get; set; }

    }
}
