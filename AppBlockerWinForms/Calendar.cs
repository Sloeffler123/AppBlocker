using AppBlockerWinForms;
using AppBlockerRunApplication;
namespace AppBlockerCalendarWinForms
{
    public class Calendar
    {
        public enum Days
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        
        public static void ShowCalendarElements(Control tableLayout, List<string> days)
        {
            
            

            foreach (Control ctrl in tableLayout.Controls)
            {
                foreach(var day in days)
                {
                    if (day == ctrl.Name)
                    {
                        // if this is true need to find the time frame in the other 
                        // panel table layout

                    }
                }
            }
        }
        // find time the user input and compare it to the table layout panel
        
        public static string[] SplitTimes(string times)
        {
            return times.Split("-");
        }
        public static string[] SplitDays(string days)
        {
            return days.Split("-");
        }
        // loop through the enum and compare the days from split days to fill in the gaps
        public static List<string> LoopThroughEnumToFindMatchingDays(string[] daysSplit)
        {
            bool triggered = false;
            List<string> daysList = new();
            foreach (string days in Enum.GetNames(typeof(Days)))
            {
                if (triggered)
                {
                    daysList.Add(days);
                }
                else if (days == daysSplit[0])
                {
                    triggered = true;
                    daysList.Add(days);
                }
                else if (days == daysSplit[1])
                {
                    daysList.Add(days);
                    break;
                }
            }
            return daysList;
        }
        public static (int, int) ShowCalendarTimesElements(Control tableLayout, string times)
        {
            // need to get the location of the text box and make a text box 
            // based off of the most recent time and last time so the location should only have two numbers when this loop completes
            var splitTimes = SplitTimes(times);
            int locationOne = 0;
            int locationTwo = 0;
            foreach (Control ctrl in tableLayout.Controls)
            {
                if (ctrl.Text == splitTimes[0])
                {
                    locationOne = ctrl.Location.Y;
                }
                else if (ctrl.Text == splitTimes[1])
                {
                    locationTwo = ctrl.Location.Y;
                    break;
                }
            }
            // returns the y coord only locationOne is the first time Y coord locationTwo is the second time Y coord
            return (locationOne, locationTwo);
        }
    }
}