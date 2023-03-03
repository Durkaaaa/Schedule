using Schedule.Date;
using Schedule.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private List<SchoolClass> _schoolClasses = new List<SchoolClass>();

        public List<SchoolClass> SchoolClasses
        {
            get => _schoolClasses;
            set
            {
                Set(ref _schoolClasses, value, nameof(SchoolClasses));
            }
        }

        public MainWindowViewModel()
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                SchoolClasses =  db.SchoolClasses.ToList();
            }
        }
    }
}
