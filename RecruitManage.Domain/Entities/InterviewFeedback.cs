using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RecruitManage.Domain.Entities
{
    public class InterviewFeedback
    {
        public int InterviewFeedbackId { get; set; }

        [ForeignKey("InterviewSchedule")]
        public int ScheduleId { get; set; }
        public bool IsSelected { get; set; }
        public string Feedback { get; set; }
        public bool FeedbackSentToCandidate { get; set; }

        public InterviewSchedule  InterviewSchedule { get; set; }
    }
}
