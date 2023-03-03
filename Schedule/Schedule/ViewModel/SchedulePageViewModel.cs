using Schedule.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.ViewModel
{
    public class SchedulePageViewModel : ViewModelBase
    {
		private SchedulePageService _schedulePageService = new SchedulePageService();

		private List<Day> _dayMonday;

		public List<Day> DayMonday
        {
			get { return _dayMonday; }
			set { _dayMonday = value; }
		}

        private List<Day> _dayTuesday;

        public List<Day> DayTuesday
        {
            get { return _dayTuesday; }
            set { _dayTuesday = value; }
        }

        private List<Day> _dayWednesday;

        public List<Day> DayWednesday
        {
            get { return _dayWednesday; }
            set { _dayWednesday = value; }
        }

        private List<Day> _dayThursday;

        public List<Day> DayThursday
        {
            get { return _dayThursday; }
            set { _dayThursday = value; }
        }

        private List<Day> _dayFriday;

        public List<Day> DayFriday
        {
            get { return _dayFriday; }
            set { _dayFriday = value; }
        }

        public SchedulePageViewModel()
		{
			DayMonday = _schedulePageService.GetDay(1);
            DayTuesday = _schedulePageService.GetDay(2);
            DayWednesday = _schedulePageService.GetDay(3);
            DayThursday = _schedulePageService.GetDay(4);
            DayFriday = _schedulePageService.GetDay(5);
		}
	}
}
