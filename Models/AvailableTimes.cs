using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempleToursProject.Models
{
    //Class for all available time slots to be used in the view where the user will select which time they would like to schedule an appointment for.
    public class AvailableTimes
    {
        public string Day1Time8am { get; set; } = "Monday at 8 am";
        public string Day1Time9am { get; set; } = "Monday at 9 am";
        public string Day1Time10am { get; set; } = "Monday at 10 am";
        public string Day1Time11am { get; set; } = "Monday at 11 am";
        public string Day1Time12pm { get; set; } = "Monday at 12 pm";
        public string Day1Time1pm { get; set; } = "Monday at 1 pm";
        public string Day1Time2pm { get; set; } = "Monday at 2 pm";
        public string Day1Time3pm { get; set; } = "Monday at 3 pm";
        public string Day1Time4pm { get; set; } = "Monday at 4 pm";
        public string Day1Time5pm { get; set; } = "Monday at 5 pm";
        public string Day1Time6pm { get; set; } = "Monday at 6 pm";
        public string Day1Time7pm { get; set; } = "Monday at 7 pm";
        public string Day1Time8pm { get; set; } = "Monday at 8 pm";

        public string Day2Time8am { get; set; } = "Tuesday at 8 am";
        public string Day2Time9am { get; set; } = "Tuesday at 9 am";
        public string Day2Time10am { get; set; } = "Tuesday at 10 am";
        public string Day2Time11am { get; set; } = "Tuesday at 11 am";
        public string Day2Time12pm { get; set; } = "Tuesday at 12 pm";
        public string Day2Time1pm { get; set; } = "Tuesday at 1 pm";
        public string Day2Time2pm { get; set; } = "Tuesday at 2 pm";
        public string Day2Time3pm { get; set; } = "Tuesday at 3 pm";
        public string Day2Time4pm { get; set; } = "Tuesday at 4 pm";
        public string Day2Time5pm { get; set; } = "Tuesday at 5 pm";
        public string Day2Time6pm { get; set; } = "Tuesday at 6 pm";
        public string Day2Time7pm { get; set; } = "Tuesday at 7 pm";
        public string Day2Time8pm { get; set; } = "Tuesday at 8 pm";

        public string Day3Time8am { get; set; } = "Wednesday at 8 am";
        public string Day3Time9am { get; set; } = "Wednesday at 9 am";
        public string Day3Time10am { get; set; } = "Wednesday at 10 am";
        public string Day3Time11am { get; set; } = "Wednesday at 11 am";
        public string Day3Time12pm { get; set; } = "Wednesday at 12 pm";
        public string Day3Time1pm { get; set; } = "Wednesday at 1 pm";
        public string Day3Time2pm { get; set; } = "Wednesday at 2 pm";
        public string Day3Time3pm { get; set; } = "Wednesday at 3 pm";
        public string Day3Time4pm { get; set; } = "Wednesday at 4 pm";
        public string Day3Time5pm { get; set; } = "Wednesday at 5 pm";
        public string Day3Time6pm { get; set; } = "Wednesday at 6 pm";
        public string Day3Time7pm { get; set; } = "Wednesday at 7 pm";
        public string Day3Time8pm { get; set; } = "Wednesday at 8 pm";

        public string Day4Time8am { get; set; } = "Thursday at 8 am";
        public string Day4Time9am { get; set; } = "Thursday at 9 am";
        public string Day4Time10am { get; set; } = "Thursday at 10 am";
        public string Day4Time11am { get; set; } = "Thursday at 11 am";
        public string Day4Time12pm { get; set; } = "Thursday at 12 pm";
        public string Day4Time1pm { get; set; } = "Thursday at 1 pm";
        public string Day4Time2pm { get; set; } = "Thursday at 2 pm";
        public string Day4Time3pm { get; set; } = "Thursday at 3 pm";
        public string Day4Time4pm { get; set; } = "Thursday at 4 pm";
        public string Day4Time5pm { get; set; } = "Thursday at 5 pm";
        public string Day4Time6pm { get; set; } = "Thursday at 6 pm";
        public string Day4Time7pm { get; set; } = "Thursday at 7 pm";
        public string Day4Time8pm { get; set; } = "Thursday at 8 pm";

        public string Day5Time8am { get; set; } = "Friday at 8 am";
        public string Day5Time9am { get; set; } = "Friday at 9 am";
        public string Day5Time10am { get; set; } = "Friday at 10 am";
        public string Day5Time11am { get; set; } = "Friday at 11 am";
        public string Day5Time12pm { get; set; } = "Friday at 12 pm";
        public string Day5Time1pm { get; set; } = "Friday at 1 pm";
        public string Day5Time2pm { get; set; } = "Friday at 2 pm";
        public string Day5Time3pm { get; set; } = "Friday at 3 pm";
        public string Day5Time4pm { get; set; } = "Friday at 4 pm";
        public string Day5Time5pm { get; set; } = "Friday at 5 pm";
        public string Day5Time6pm { get; set; } = "Friday at 6 pm";
        public string Day5Time7pm { get; set; } = "Friday at 7 pm";
        public string Day5Time8pm { get; set; } = "Friday at 8 pm";

        public string Day6Time8am { get; set; } = "Saturday at 8 am";
        public string Day6Time9am { get; set; } = "Saturday at 9 am";
        public string Day6Time10am { get; set; } = "Saturday at 10 am";
        public string Day6Time11am { get; set; } = "Saturday at 11 am";
        public string Day6Time12pm { get; set; } = "Saturday at 12 pm";
        public string Day6Time1pm { get; set; } = "Saturday at 1 pm";
        public string Day6Time2pm { get; set; } = "Saturday at 2 pm";
        public string Day6Time3pm { get; set; } = "Saturday at 3 pm";
        public string Day6Time4pm { get; set; } = "Saturday at 4 pm";
        public string Day6Time5pm { get; set; } = "Saturday at 5 pm";
        public string Day6Time6pm { get; set; } = "Saturday at 6 pm";
        public string Day6Time7pm { get; set; } = "Saturday at 7 pm";
        public string Day6Time8pm { get; set; } = "Saturday at 8 pm";

        public string Day7Time8am { get; set; } = "Sunday at 8 am";
        public string Day7Time9am { get; set; } = "Sunday at 9 am";
        public string Day7Time10am { get; set; } = "Sunday at 10 am";
        public string Day7Time11am { get; set; } = "Sunday at 11 am";
        public string Day7Time12pm { get; set; } = "Sunday at 12 pm";
        public string Day7Time1pm { get; set; } = "Sunday at 1 pm";
        public string Day7Time2pm { get; set; } = "Sunday at 2 pm";
        public string Day7Time3pm { get; set; } = "Sunday at 3 pm";
        public string Day7Time4pm { get; set; } = "Sunday at 4 pm";
        public string Day7Time5pm { get; set; } = "Sunday at 5 pm";
        public string Day7Time6pm { get; set; } = "Sunday at 6 pm";
        public string Day7Time7pm { get; set; } = "Sunday at 7 pm";
        public string Day7Time8pm { get; set; } = "Sunday at 8 pm";


    }
}
