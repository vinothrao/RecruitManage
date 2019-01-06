using System;
using System.Collections.Generic;
using System.Text;

namespace RecruitManage.Domain.Entities
{
    public class UserType
    {
        public bool HR { get; set; }
        public bool TechnicalRecruiter { get; set; }
        public bool IsIndependentRecruiter { get; set; }
    }
}
