using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RecruitManage.Domain.Entities
{
   public class Permissions
    {
        [Key]
        public int PermissionId { get; set; }
        public string PermissionName { get; set; }

    }
}
