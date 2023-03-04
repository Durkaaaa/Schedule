using System;
using System.Collections.Generic;
using System.Text;

namespace Schedule.Entities
{
    public class Authorization
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
