using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RecruitManage.Domain.Entities
{
   public class Technologies
    {
        [Key]
        public int TechnologyId { get; set; }
        public string TechnologyName { get; set; }
        public bool IsActive { get; set; }
    }
}
