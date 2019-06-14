using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RecruitManage.Domain.Entities
{
    public class InterviewSchedule
    {

        public int InterviewScheduleId { get; set; }

        public string ScheduleName { get; set; }
        public DateTime ScheduledDateTime { get; set; }
        public bool IsFeedbackRecieved { get; set; }
        public bool SentMailToCandidate { get; set; }
        public bool SentMailToInterviewer { get; set; }
        public int Round { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        [ForeignKey("Candidate")]
        public int CandidateId { get; set; }

        public User User { get; set; }
        public Candidate Candidate { get; set; }



    }
}
