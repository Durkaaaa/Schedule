using System;
using System.Collections.Generic;
using System.Text;

namespace Schedule.Entities
{
    public class TeacherSubject
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public int SubjectId { get; set; }

        public Teacher Teacher { get; set; }
        public Subject Subject { get; set; }
    }
}
