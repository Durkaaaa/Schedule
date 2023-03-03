using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.Entities
{
    public class ScheduleList
    {
        public int Id { get; set; }
        public int SchoolClassId { get; set; }
        public int DayOfTheWeekId { get; set; }
        public int Number { get; set; }
        public string Cabinet { get; set; }
        public DateTime LessonStart { get; set; }
        public DateTime EndOfTheLesson { get; set; }
        public int TeacherId { get;set; }

        public SchoolClass SchoolClass { get; set; }
        public DayOfTheWeek DayOfTheWeek { get; set; }
        public Teacher Teacher { get; set; }
    }
}
