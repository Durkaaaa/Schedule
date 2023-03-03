using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.Entities
{
    public class Teacher
    {
        public int Id { get; set; }
        public string SurName { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime BeginningOfWork { get;set; }
        public DateTime EndingOfWork { get;set; }
    }
}
