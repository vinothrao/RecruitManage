using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RecruitManage.Domain.Entities
{
   public class UserDetails
    {
        public int UserDetailsId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public int CompanyId { get; set; }

        public User User { get; set; }
    }
}
