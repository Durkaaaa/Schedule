using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.Entities
{
    public class TeacherSubjectSchoolClass
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public int SubjectId { get; set; }
        public int SchoolClassId { get; set; }

        public Teacher Teacher { get; set; }
        public Subject Subject { get; set; }
        public SchoolClass SchoolClass { get; set; }
    }
}
