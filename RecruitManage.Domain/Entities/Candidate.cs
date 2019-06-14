using System;
using System.Collections.Generic;
using System.Text;

namespace RecruitManage.Domain.Entities
{
    public class Candidate
    {

        public int CandidateId { get; set; }
        public string CandidateName { get; set; }
        public string CurrentCompanyName { get; set; }
        public decimal YearsOfExperience { get; set; }
        public int NoticePeriodInDays { get; set; }
        public bool InNoticePeriod { get; set; }
        public DateTime LastWorkingDay { get; set; }
         
    }
}
