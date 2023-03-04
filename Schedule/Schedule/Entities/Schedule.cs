using System;
using System.Collections.Generic;
using System.Text;

namespace Schedule.Entities
{
    public class Schedule
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public int Number { get; set; }
        public int SubjectId { get; set; }
        public int CabinetId { get; set; }
        public int LessonPeriodId { get; set; }
        public int TeacherId { get; set; }
        public int DayOfTheWeekId { get; set; }

        public Class Class { get; set; }
        public Subject Subject { get; set; }
        public Cabinet Cabinet { get; set; }
        public LessonPeriod LessonPeriod { get; set; }
        public Teacher Teacher { get; set; }
        public DayOfTheWeek DayOfTheWeek { get; set; }
    }
}
