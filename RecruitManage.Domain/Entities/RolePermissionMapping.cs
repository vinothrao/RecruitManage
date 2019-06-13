using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RecruitManage.Domain.Entities
{
   public class RolePermissionMapping
    {

        public int RolePermissionMappingId { get; set; }

        [ForeignKey("Roles")]
        public int RoleId { get; set; }

        [ForeignKey("Permissions")]
        public int PermissionId { get; set; }

        public Roles Roles { get; set; }
        public Permissions Permissions { get; set; }
    }
}
