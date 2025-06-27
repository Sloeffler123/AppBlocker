using AppBlockerWinForms;

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
        public static void ShowCalendarElements(Control tableLayout, string days)
        {
            // split the days 
            var splitDays = SplitDays(days);

            foreach (Control ctrl in tableLayout.Controls)
            {
                MessageBox.Show(ctrl.Text);
                if (ctrl.Text == "Friday")
                {
                    
                }
            }
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
        public static void ShowCalendarTimesElements(Control tableLayout)
        {
            foreach (Control ctrl in tableLayout.Controls)
            {
                MessageBox.Show(ctrl.Text);
            }
        }
    }
}