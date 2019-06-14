using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RecruitManage.Domain.Entities
{
  public  class CandidateTechnologyMapping
    {
        public int CandidateTechnologyMappingId { get; set; }

        [ForeignKey("Candidate")]
        public int CanditateId { get; set; }

        [ForeignKey("Technologies")]
        public int TechnologyId { get; set; }


        public Technologies  Technologies { get; set; }
        public Candidate Candidate { get; set; }

    }
}
