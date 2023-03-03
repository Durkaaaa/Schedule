using Microsoft.EntityFrameworkCore;
using Schedule.Date;
using Schedule.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Schedule.Service
{
    public class SchedulePageService
    {
        public List<ScheduleList> GetSchedules()
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                return db.ScheduleLists
                    .Include(sc => sc.SchoolClass)
                    .Include(t => t.Teacher)
                    .ToList();
            }
        }

        public List<int> GetScheduleNumbers()
        {
            var list = new List<int>();
            foreach (var item in GetSchedules())
            {
                list.Add(item.Number);
            }
            return list;
        }

        public List<Day> GetDay(int dayId)
        {
            var list = new List<Day>();
            foreach (var item in GetSchedules())
            {
                if (item.DayOfTheWeekId == dayId)
                {
                    Day day = new Day(item.Number, item.Cabinet,
                        item.LessonStart, item.EndOfTheLesson,
                        item.TeacherId);
                    list.Add(day);
                }
            }
            return list;
        }

        public bool CreateSchedule(ScheduleList schedule)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                if (schedule.Teacher == null)
                    return false;

                if (schedule.SchoolClass == null)
                    return false;

                //Доделать

                db.ScheduleLists.Add(schedule);
                db.SaveChanges();
            }

            return true;
        }

        public bool RemoveSchedule(ScheduleList schedule)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                if (!db.ScheduleLists.Any(s => s.Id == schedule.Id).Equals(schedule))
                    return false;

                db.ScheduleLists.Remove(schedule);
                db.SaveChanges();
            }

            return true;
        }
    }

    public class Day
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Cabinet { get; set; }
        public DateTime LessonStart { get; set; }
        public DateTime EndOfTheLesson { get; set; }
        public int TeacherId { get; set; }

        public Day(int number, string cabinet, DateTime lessonStart,
            DateTime endOfTheLesson, int teacherId) 
        {
            Number = number;
            Cabinet = cabinet;
            LessonStart = lessonStart;
            EndOfTheLesson = endOfTheLesson;
            TeacherId = teacherId;
        }

        public Teacher Teacher { get; set;}
    }
}
