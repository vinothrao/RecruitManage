using System;
using System.Collections.Generic;
using System.Text;

namespace RecruitManage.Domain.Entities
{
   public class User
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PasswordHash { get; set; }
        public string AuthToken { get; set; }
        public bool IsEmailActivated { get; set; }
    }
}
