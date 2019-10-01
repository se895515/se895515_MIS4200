using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using se895515_MIS4200.Models;
using System.Data.Entity;

namespace se895515_MIS4200.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base ("name=DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Context,
                se895515_MIS4200.Migrations.MISContext.Configuration>("DefaultConnection"));
        }


        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Professor> Professors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}