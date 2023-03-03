using Microsoft.EntityFrameworkCore;
using Schedule.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.Date
{
    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<ScheduleList> ScheduleLists { get; set; }
        public virtual DbSet<TeacherSubjectSchoolClass> TeacherSubjectSchoolClasses { get; set; }
        public virtual DbSet<SchoolClass> SchoolClasses { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-6971TL9\\SQLEXPRESS;Initial Catalog=Schedule;User ID=sa;Password=0$sa");
            }
        }
    }
}
