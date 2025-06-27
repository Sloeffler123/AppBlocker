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
        public static void ShowCalendarTimesElements(Control tableLayout)
        {
            foreach (Control ctrl in tableLayout.Controls)
            {
                MessageBox.Show(ctrl.Text);
            }
        }
    }
}