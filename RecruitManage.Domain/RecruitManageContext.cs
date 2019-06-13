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
        public DbSet<Permissions>  Permissions { get; set; }
        public DbSet<RolePermissionMapping> RolePermissionMapping { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Technologies> Technologies { get; set; }
        public DbSet<UserTechnologyMapping> UserTechnologyMapping { get; set; }
        public DbSet<UserDetails> UserDetails { get; set; }

    }
}
