using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RecruitManage.Domain.Entities
{
   public class UserTechnologyMapping
    {
        public int UserTechnologyMappingId { get; set; }

        [ForeignKey("User")]
        public int userId { get; set; }

        [ForeignKey("Technologies")]
        public int TechnologyId { get; set; }

        public User  User { get; set; }
        public Technologies  Technologies { get; set; }

    }
}
