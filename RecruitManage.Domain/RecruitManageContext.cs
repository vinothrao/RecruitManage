using Microsoft.EntityFrameworkCore;
using RecruitManage.Domain.Entities;
using System;

namespace RecruitManage.Domain
{
    public class RecruitManageContext:DbContext
    {
        public RecruitManageContext(DbContextOptions<RecruitManageContext> options):base(options)
        {
        }

        public DbSet<User> User { get; set; }


    }
}
