using System;
using System.Collections.Generic;
using System.Text;

namespace Schedule.Entities
{
    public class Cabinet
    {
        public int Id { get; set; }
        public string CabinetNumber { get; set; }
        public string CabinetName { get; set; }
        public int NumberOfSeats { get; set; }
    }
}
